using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class addcustomermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    RelationManagerNIK = table.Column<string>(nullable: true),
                    DistrictId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_tb_m_district_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "tb_m_district",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_tb_m_employee_RelationManagerNIK",
                        column: x => x.RelationManagerNIK,
                        principalTable: "tb_m_employee",
                        principalColumn: "NIK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DistrictId",
                table: "Customers",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RelationManagerNIK",
                table: "Customers",
                column: "RelationManagerNIK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
