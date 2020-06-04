using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class changedatetodatetimeonbase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Update_Date",
                table: "tb_tr_interview_history",
                newName: "Update_Datetime");

            migrationBuilder.RenameColumn(
                name: "Create_Date",
                table: "tb_tr_interview_history",
                newName: "Create_Datetime");

            migrationBuilder.RenameColumn(
                name: "Update_Date",
                table: "tb_m_type",
                newName: "Update_Datetime");

            migrationBuilder.RenameColumn(
                name: "Create_Date",
                table: "tb_m_type",
                newName: "Create_Datetime");

            migrationBuilder.RenameColumn(
                name: "Update_Date",
                table: "tb_m_room",
                newName: "Update_Datetime");

            migrationBuilder.RenameColumn(
                name: "Create_Date",
                table: "tb_m_room",
                newName: "Create_Datetime");

            migrationBuilder.RenameColumn(
                name: "Update_Date",
                table: "tb_m_participant",
                newName: "Update_Datetime");

            migrationBuilder.RenameColumn(
                name: "Create_Date",
                table: "tb_m_participant",
                newName: "Create_Datetime");

            migrationBuilder.RenameColumn(
                name: "Update_Date",
                table: "tb_m_employee",
                newName: "Update_Datetime");

            migrationBuilder.RenameColumn(
                name: "Create_Date",
                table: "tb_m_employee",
                newName: "Create_Datetime");

            migrationBuilder.RenameColumn(
                name: "Update_Date",
                table: "tb_m_class",
                newName: "Update_Datetime");

            migrationBuilder.RenameColumn(
                name: "Create_Date",
                table: "tb_m_class",
                newName: "Create_Datetime");

            migrationBuilder.RenameColumn(
                name: "Update_Date",
                table: "tb_m_batch_class",
                newName: "Update_Datetime");

            migrationBuilder.RenameColumn(
                name: "Create_Date",
                table: "tb_m_batch_class",
                newName: "Create_Datetime");

            migrationBuilder.RenameColumn(
                name: "Update_Date",
                table: "tb_m_batch",
                newName: "Update_Datetime");

            migrationBuilder.RenameColumn(
                name: "Create_Date",
                table: "tb_m_batch",
                newName: "Create_Datetime");

            migrationBuilder.RenameColumn(
                name: "Update_Date",
                table: "tb_m_asset",
                newName: "Update_Datetime");

            migrationBuilder.RenameColumn(
                name: "Create_Date",
                table: "tb_m_asset",
                newName: "Create_Datetime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Update_Datetime",
                table: "tb_tr_interview_history",
                newName: "Update_Date");

            migrationBuilder.RenameColumn(
                name: "Create_Datetime",
                table: "tb_tr_interview_history",
                newName: "Create_Date");

            migrationBuilder.RenameColumn(
                name: "Update_Datetime",
                table: "tb_m_type",
                newName: "Update_Date");

            migrationBuilder.RenameColumn(
                name: "Create_Datetime",
                table: "tb_m_type",
                newName: "Create_Date");

            migrationBuilder.RenameColumn(
                name: "Update_Datetime",
                table: "tb_m_room",
                newName: "Update_Date");

            migrationBuilder.RenameColumn(
                name: "Create_Datetime",
                table: "tb_m_room",
                newName: "Create_Date");

            migrationBuilder.RenameColumn(
                name: "Update_Datetime",
                table: "tb_m_participant",
                newName: "Update_Date");

            migrationBuilder.RenameColumn(
                name: "Create_Datetime",
                table: "tb_m_participant",
                newName: "Create_Date");

            migrationBuilder.RenameColumn(
                name: "Update_Datetime",
                table: "tb_m_employee",
                newName: "Update_Date");

            migrationBuilder.RenameColumn(
                name: "Create_Datetime",
                table: "tb_m_employee",
                newName: "Create_Date");

            migrationBuilder.RenameColumn(
                name: "Update_Datetime",
                table: "tb_m_class",
                newName: "Update_Date");

            migrationBuilder.RenameColumn(
                name: "Create_Datetime",
                table: "tb_m_class",
                newName: "Create_Date");

            migrationBuilder.RenameColumn(
                name: "Update_Datetime",
                table: "tb_m_batch_class",
                newName: "Update_Date");

            migrationBuilder.RenameColumn(
                name: "Create_Datetime",
                table: "tb_m_batch_class",
                newName: "Create_Date");

            migrationBuilder.RenameColumn(
                name: "Update_Datetime",
                table: "tb_m_batch",
                newName: "Update_Date");

            migrationBuilder.RenameColumn(
                name: "Create_Datetime",
                table: "tb_m_batch",
                newName: "Create_Date");

            migrationBuilder.RenameColumn(
                name: "Update_Datetime",
                table: "tb_m_asset",
                newName: "Update_Date");

            migrationBuilder.RenameColumn(
                name: "Create_Datetime",
                table: "tb_m_asset",
                newName: "Create_Date");
        }
    }
}
