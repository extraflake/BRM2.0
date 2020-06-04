using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class implementbasemodeloninterview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Create_Date",
                table: "tb_tr_interview_history",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "Created_By",
                table: "tb_tr_interview_history",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Update_Date",
                table: "tb_tr_interview_history",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "Updated_By",
                table: "tb_tr_interview_history",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Create_Date",
                table: "tb_tr_interview_history");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "tb_tr_interview_history");

            migrationBuilder.DropColumn(
                name: "Update_Date",
                table: "tb_tr_interview_history");

            migrationBuilder.DropColumn(
                name: "Updated_By",
                table: "tb_tr_interview_history");
        }
    }
}
