using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class addPlacement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_tr_placement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Department = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Employee_Id = table.Column<string>(nullable: true),
                    Customer_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_tr_placement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_tr_placement_tb_m_customer_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "tb_m_customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_tr_placement_tb_m_employee_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "tb_m_employee",
                        principalColumn: "NIK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_placement_Customer_Id",
                table: "tb_tr_placement",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_placement_Employee_Id",
                table: "tb_tr_placement",
                column: "Employee_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_tr_placement");
        }
    }
}
