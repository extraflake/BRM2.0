using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Add_FK_Customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "District",
                table: "tb_m_customer");

            migrationBuilder.AlterColumn<string>(
                name: "RelationManager",
                table: "tb_m_customer",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "tb_m_customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_m_customer_DistrictId",
                table: "tb_m_customer",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_m_customer_RelationManager",
                table: "tb_m_customer",
                column: "RelationManager");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_customer_tb_m_district_DistrictId",
                table: "tb_m_customer",
                column: "DistrictId",
                principalTable: "tb_m_district",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_customer_tb_m_employee_RelationManager",
                table: "tb_m_customer",
                column: "RelationManager",
                principalTable: "tb_m_employee",
                principalColumn: "NIK",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_customer_tb_m_district_DistrictId",
                table: "tb_m_customer");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_customer_tb_m_employee_RelationManager",
                table: "tb_m_customer");

            migrationBuilder.DropIndex(
                name: "IX_tb_m_customer_DistrictId",
                table: "tb_m_customer");

            migrationBuilder.DropIndex(
                name: "IX_tb_m_customer_RelationManager",
                table: "tb_m_customer");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "tb_m_customer");

            migrationBuilder.AlterColumn<string>(
                name: "RelationManager",
                table: "tb_m_customer",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "tb_m_customer",
                nullable: true);
        }
    }
}
