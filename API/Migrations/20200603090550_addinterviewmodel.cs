using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class addinterviewmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_district_tb_m_province_Province_Id",
                table: "tb_m_district");

            migrationBuilder.RenameColumn(
                name: "Province_Id",
                table: "tb_m_district",
                newName: "Province");

            migrationBuilder.RenameIndex(
                name: "IX_tb_m_district_Province_Id",
                table: "tb_m_district",
                newName: "IX_tb_m_district_Province");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_district_tb_m_province_Province",
                table: "tb_m_district",
                column: "Province",
                principalTable: "tb_m_province",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_district_tb_m_province_Province",
                table: "tb_m_district");

            migrationBuilder.RenameColumn(
                name: "Province",
                table: "tb_m_district",
                newName: "Province_Id");

            migrationBuilder.RenameIndex(
                name: "IX_tb_m_district_Province",
                table: "tb_m_district",
                newName: "IX_tb_m_district_Province_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_district_tb_m_province_Province_Id",
                table: "tb_m_district",
                column: "Province_Id",
                principalTable: "tb_m_province",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
