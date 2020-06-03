using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class interviewmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_tr_interview_history",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    interview_datetime = table.Column<DateTimeOffset>(nullable: false),
                    PIC = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    Employee = table.Column<string>(nullable: true),
                    Customer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_tr_interview_history", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_tr_interview_history_tb_m_customer_Customer",
                        column: x => x.Customer,
                        principalTable: "tb_m_customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_tr_interview_history_tb_m_employee_Employee",
                        column: x => x.Employee,
                        principalTable: "tb_m_employee",
                        principalColumn: "NIK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_interview_history_Customer",
                table: "tb_tr_interview_history",
                column: "Customer");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_interview_history_Employee",
                table: "tb_tr_interview_history",
                column: "Employee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_tr_interview_history");
        }
    }
}
