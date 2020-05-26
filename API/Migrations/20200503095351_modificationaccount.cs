using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class modificationaccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_batch_class_tb_m_employee_trainer",
                table: "tb_m_batch_class");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_employee_Users_Id",
                table: "tb_m_employee");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_employee_role_tb_m_employee_Employee_Id",
                table: "tb_tr_employee_role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_m_employee",
                table: "tb_m_employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "tb_m_employee");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "tb_m_account");

            migrationBuilder.AlterColumn<string>(
                name: "NIK",
                table: "tb_m_employee",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_m_employee",
                table: "tb_m_employee",
                column: "NIK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_m_account",
                table: "tb_m_account",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_batch_class_tb_m_employee_trainer",
                table: "tb_m_batch_class",
                column: "trainer",
                principalTable: "tb_m_employee",
                principalColumn: "NIK",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_employee_tb_m_account_NIK",
                table: "tb_m_employee",
                column: "NIK",
                principalTable: "tb_m_account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_employee_role_tb_m_employee_Employee_Id",
                table: "tb_tr_employee_role",
                column: "Employee_Id",
                principalTable: "tb_m_employee",
                principalColumn: "NIK",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_batch_class_tb_m_employee_trainer",
                table: "tb_m_batch_class");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_employee_tb_m_account_NIK",
                table: "tb_m_employee");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_employee_role_tb_m_employee_Employee_Id",
                table: "tb_tr_employee_role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_m_employee",
                table: "tb_m_employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_m_account",
                table: "tb_m_account");

            migrationBuilder.RenameTable(
                name: "tb_m_account",
                newName: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "NIK",
                table: "tb_m_employee",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "tb_m_employee",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_m_employee",
                table: "tb_m_employee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_batch_class_tb_m_employee_trainer",
                table: "tb_m_batch_class",
                column: "trainer",
                principalTable: "tb_m_employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_employee_Users_Id",
                table: "tb_m_employee",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_employee_role_tb_m_employee_Employee_Id",
                table: "tb_tr_employee_role",
                column: "Employee_Id",
                principalTable: "tb_m_employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
