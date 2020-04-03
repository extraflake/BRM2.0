using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class addemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_m_employee",
                columns: table => new
                {
                    Create_Date = table.Column<DateTimeOffset>(nullable: false),
                    Update_Date = table.Column<DateTimeOffset>(nullable: false),
                    Created_By = table.Column<string>(nullable: true),
                    Updated_By = table.Column<string>(nullable: true),
                    Id = table.Column<string>(nullable: false),
                    NIK = table.Column<string>(nullable: true),
                    First_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_m_employee_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_m_employee");
        }
    }
}
