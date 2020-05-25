using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class InitModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_m_account",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_batch",
                columns: table => new
                {
                    Create_Date = table.Column<DateTimeOffset>(nullable: false),
                    Update_Date = table.Column<DateTimeOffset>(nullable: false),
                    Created_By = table.Column<string>(nullable: true),
                    Updated_By = table.Column<string>(nullable: true),
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Start_Date = table.Column<DateTimeOffset>(nullable: false),
                    End_Date = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_batch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_class",
                columns: table => new
                {
                    Create_Date = table.Column<DateTimeOffset>(nullable: false),
                    Update_Date = table.Column<DateTimeOffset>(nullable: false),
                    Created_By = table.Column<string>(nullable: true),
                    Updated_By = table.Column<string>(nullable: true),
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_class", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_customer",
                columns: table => new
                {
                    Create_Date = table.Column<DateTimeOffset>(nullable: false),
                    Update_Date = table.Column<DateTimeOffset>(nullable: false),
                    Created_By = table.Column<string>(nullable: true),
                    Updated_By = table.Column<string>(nullable: true),
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    RelationManager = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_province",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_province", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_room",
                columns: table => new
                {
                    Create_Date = table.Column<DateTimeOffset>(nullable: false),
                    Update_Date = table.Column<DateTimeOffset>(nullable: false),
                    Created_By = table.Column<string>(nullable: true),
                    Updated_By = table.Column<string>(nullable: true),
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_room", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_type",
                columns: table => new
                {
                    Create_Date = table.Column<DateTimeOffset>(nullable: false),
                    Update_Date = table.Column<DateTimeOffset>(nullable: false),
                    Created_By = table.Column<string>(nullable: true),
                    Updated_By = table.Column<string>(nullable: true),
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_district",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Province_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_district", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_m_district_tb_m_province_Province_Id",
                        column: x => x.Province_Id,
                        principalTable: "tb_m_province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_employee",
                columns: table => new
                {
                    Create_Date = table.Column<DateTimeOffset>(nullable: false),
                    Update_Date = table.Column<DateTimeOffset>(nullable: false),
                    Created_By = table.Column<string>(nullable: true),
                    Updated_By = table.Column<string>(nullable: true),
                    NIK = table.Column<string>(nullable: false),
                    First_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Hiring_Location = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_employee", x => x.NIK);
                    table.ForeignKey(
                        name: "FK_tb_m_employee_tb_m_district_Hiring_Location",
                        column: x => x.Hiring_Location,
                        principalTable: "tb_m_district",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_m_employee_tb_m_account_NIK",
                        column: x => x.NIK,
                        principalTable: "tb_m_account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_batch_class",
                columns: table => new
                {
                    Create_Date = table.Column<DateTimeOffset>(nullable: false),
                    Update_Date = table.Column<DateTimeOffset>(nullable: false),
                    Created_By = table.Column<string>(nullable: true),
                    Updated_By = table.Column<string>(nullable: true),
                    Id = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Plan = table.Column<int>(nullable: false),
                    trainer = table.Column<string>(nullable: true),
                    batch = table.Column<string>(nullable: true),
                    room = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_batch_class", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_m_batch_class_tb_m_batch_batch",
                        column: x => x.batch,
                        principalTable: "tb_m_batch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_m_batch_class_tb_m_room_room",
                        column: x => x.room,
                        principalTable: "tb_m_room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_m_batch_class_tb_m_employee_trainer",
                        column: x => x.trainer,
                        principalTable: "tb_m_employee",
                        principalColumn: "NIK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_tr_employee_role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Is_Delete = table.Column<bool>(nullable: false),
                    Employee_Id = table.Column<string>(nullable: true),
                    Role_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_tr_employee_role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_tr_employee_role_tb_m_employee_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "tb_m_employee",
                        principalColumn: "NIK",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_tr_employee_role_tb_m_role_Role_Id",
                        column: x => x.Role_Id,
                        principalTable: "tb_m_role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_participant",
                columns: table => new
                {
                    Create_Date = table.Column<DateTimeOffset>(nullable: false),
                    Update_Date = table.Column<DateTimeOffset>(nullable: false),
                    Created_By = table.Column<string>(nullable: true),
                    Updated_By = table.Column<string>(nullable: true),
                    Id = table.Column<string>(nullable: false),
                    Grade = table.Column<string>(nullable: true),
                    batch_class = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_participant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_m_participant_tb_m_batch_class_batch_class",
                        column: x => x.batch_class,
                        principalTable: "tb_m_batch_class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_m_asset",
                columns: table => new
                {
                    Create_Date = table.Column<DateTimeOffset>(nullable: false),
                    Update_Date = table.Column<DateTimeOffset>(nullable: false),
                    Created_By = table.Column<string>(nullable: true),
                    Updated_By = table.Column<string>(nullable: true),
                    Id = table.Column<string>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    employee = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_m_asset_tb_m_participant_employee",
                        column: x => x.employee,
                        principalTable: "tb_m_participant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_m_asset_tb_m_type_type",
                        column: x => x.type,
                        principalTable: "tb_m_type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_m_asset_employee",
                table: "tb_m_asset",
                column: "employee");

            migrationBuilder.CreateIndex(
                name: "IX_tb_m_asset_type",
                table: "tb_m_asset",
                column: "type");

            migrationBuilder.CreateIndex(
                name: "IX_tb_m_batch_class_batch",
                table: "tb_m_batch_class",
                column: "batch");

            migrationBuilder.CreateIndex(
                name: "IX_tb_m_batch_class_room",
                table: "tb_m_batch_class",
                column: "room");

            migrationBuilder.CreateIndex(
                name: "IX_tb_m_batch_class_trainer",
                table: "tb_m_batch_class",
                column: "trainer");

            migrationBuilder.CreateIndex(
                name: "IX_tb_m_district_Province_Id",
                table: "tb_m_district",
                column: "Province_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_m_employee_Hiring_Location",
                table: "tb_m_employee",
                column: "Hiring_Location");

            migrationBuilder.CreateIndex(
                name: "IX_tb_m_participant_batch_class",
                table: "tb_m_participant",
                column: "batch_class");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_employee_role_Employee_Id",
                table: "tb_tr_employee_role",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_employee_role_Role_Id",
                table: "tb_tr_employee_role",
                column: "Role_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_m_asset");

            migrationBuilder.DropTable(
                name: "tb_m_class");

            migrationBuilder.DropTable(
                name: "tb_m_customer");

            migrationBuilder.DropTable(
                name: "tb_tr_employee_role");

            migrationBuilder.DropTable(
                name: "tb_m_participant");

            migrationBuilder.DropTable(
                name: "tb_m_type");

            migrationBuilder.DropTable(
                name: "tb_m_role");

            migrationBuilder.DropTable(
                name: "tb_m_batch_class");

            migrationBuilder.DropTable(
                name: "tb_m_batch");

            migrationBuilder.DropTable(
                name: "tb_m_room");

            migrationBuilder.DropTable(
                name: "tb_m_employee");

            migrationBuilder.DropTable(
                name: "tb_m_district");

            migrationBuilder.DropTable(
                name: "tb_m_account");

            migrationBuilder.DropTable(
                name: "tb_m_province");
        }
    }
}
