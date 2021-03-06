﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class modulemployeeparticipantclassasset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_class", x => x.Id);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_tb_m_participant_batch_class",
                table: "tb_m_participant",
                column: "batch_class");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_m_asset");

            migrationBuilder.DropTable(
                name: "tb_m_class");

            migrationBuilder.DropTable(
                name: "tb_m_participant");

            migrationBuilder.DropTable(
                name: "tb_m_type");

            migrationBuilder.DropTable(
                name: "tb_m_batch_class");

            migrationBuilder.DropTable(
                name: "tb_m_batch");

            migrationBuilder.DropTable(
                name: "tb_m_room");
        }
    }
}
