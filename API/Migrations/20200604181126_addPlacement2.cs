using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class addPlacement2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_placement_tb_m_customer_Customer_Id",
                table: "tb_tr_placement");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_placement_tb_m_employee_Employee_Id",
                table: "tb_tr_placement");

            migrationBuilder.RenameColumn(
                name: "Employee_Id",
                table: "tb_tr_placement",
                newName: "Employee");

            migrationBuilder.RenameColumn(
                name: "Customer_Id",
                table: "tb_tr_placement",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_tb_tr_placement_Employee_Id",
                table: "tb_tr_placement",
                newName: "IX_tb_tr_placement_Employee");

            migrationBuilder.RenameIndex(
                name: "IX_tb_tr_placement_Customer_Id",
                table: "tb_tr_placement",
                newName: "IX_tb_tr_placement_Customer");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_placement_tb_m_customer_Customer",
                table: "tb_tr_placement",
                column: "Customer",
                principalTable: "tb_m_customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_placement_tb_m_employee_Employee",
                table: "tb_tr_placement",
                column: "Employee",
                principalTable: "tb_m_employee",
                principalColumn: "NIK",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_placement_tb_m_customer_Customer",
                table: "tb_tr_placement");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_placement_tb_m_employee_Employee",
                table: "tb_tr_placement");

            migrationBuilder.RenameColumn(
                name: "Employee",
                table: "tb_tr_placement",
                newName: "Employee_Id");

            migrationBuilder.RenameColumn(
                name: "Customer",
                table: "tb_tr_placement",
                newName: "Customer_Id");

            migrationBuilder.RenameIndex(
                name: "IX_tb_tr_placement_Employee",
                table: "tb_tr_placement",
                newName: "IX_tb_tr_placement_Employee_Id");

            migrationBuilder.RenameIndex(
                name: "IX_tb_tr_placement_Customer",
                table: "tb_tr_placement",
                newName: "IX_tb_tr_placement_Customer_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_placement_tb_m_customer_Customer_Id",
                table: "tb_tr_placement",
                column: "Customer_Id",
                principalTable: "tb_m_customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_placement_tb_m_employee_Employee_Id",
                table: "tb_tr_placement",
                column: "Employee_Id",
                principalTable: "tb_m_employee",
                principalColumn: "NIK",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
