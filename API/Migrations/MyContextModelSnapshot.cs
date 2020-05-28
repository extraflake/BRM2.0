﻿// <auto-generated />
using System;
using API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API.Models.Asset", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Create_Date");

                    b.Property<string>("Created_By");

                    b.Property<string>("Number");

                    b.Property<DateTimeOffset>("Update_Date");

                    b.Property<string>("Updated_By");

                    b.Property<string>("employee");

                    b.Property<string>("type");

                    b.HasKey("Id");

                    b.HasIndex("employee");

                    b.HasIndex("type");

                    b.ToTable("tb_m_asset");
                });

            modelBuilder.Entity("API.Models.Batch", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Create_Date");

                    b.Property<string>("Created_By");

                    b.Property<DateTimeOffset>("End_Date");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset>("Start_Date");

                    b.Property<string>("Type");

                    b.Property<DateTimeOffset>("Update_Date");

                    b.Property<string>("Updated_By");

                    b.HasKey("Id");

                    b.ToTable("tb_m_batch");
                });

            modelBuilder.Entity("API.Models.BatchClass", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Create_Date");

                    b.Property<string>("Created_By");

                    b.Property<int>("Plan");

                    b.Property<int>("Quantity");

                    b.Property<DateTimeOffset>("Update_Date");

                    b.Property<string>("Updated_By");

                    b.Property<string>("batch");

                    b.Property<string>("room");

                    b.Property<string>("trainer");

                    b.HasKey("Id");

                    b.HasIndex("batch");

                    b.HasIndex("room");

                    b.HasIndex("trainer");

                    b.ToTable("tb_m_batch_class");
                });

            modelBuilder.Entity("API.Models.Class", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Create_Date");

                    b.Property<string>("Created_By");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset>("Update_Date");

                    b.Property<string>("Updated_By");

                    b.HasKey("Id");

                    b.ToTable("tb_m_class");
                });

            modelBuilder.Entity("API.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTimeOffset>("Create_Date");

                    b.Property<string>("Created_By");

                    b.Property<int>("District_Id");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("RelationManager");

                    b.Property<DateTimeOffset>("Update_Date");

                    b.Property<string>("Updated_By");

                    b.HasKey("Id");

                    b.HasIndex("District_Id");

                    b.HasIndex("RelationManager");

                    b.ToTable("tb_m_customer");
                });

            modelBuilder.Entity("API.Models.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Province_Id");

                    b.HasKey("Id");

                    b.HasIndex("Province_Id");

                    b.ToTable("tb_m_district");
                });

            modelBuilder.Entity("API.Models.Employee", b =>
                {
                    b.Property<string>("NIK");

                    b.Property<DateTimeOffset>("Create_Date");

                    b.Property<string>("Created_By");

                    b.Property<string>("Email");

                    b.Property<string>("First_Name");

                    b.Property<bool>("Gender");

                    b.Property<int>("Hiring_Location");

                    b.Property<string>("Last_Name");

                    b.Property<string>("Phone");

                    b.Property<DateTimeOffset>("Update_Date");

                    b.Property<string>("Updated_By");

                    b.HasKey("NIK");

                    b.HasIndex("Hiring_Location");

                    b.ToTable("tb_m_employee");
                });

            modelBuilder.Entity("API.Models.EmployeeRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Employee_Id");

                    b.Property<bool>("Is_Delete");

                    b.Property<int>("Role_Id");

                    b.HasKey("Id");

                    b.HasIndex("Employee_Id");

                    b.HasIndex("Role_Id");

                    b.ToTable("tb_tr_employee_role");
                });

            modelBuilder.Entity("API.Models.Participant", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Create_Date");

                    b.Property<string>("Created_By");

                    b.Property<string>("Grade");

                    b.Property<DateTimeOffset>("Update_Date");

                    b.Property<string>("Updated_By");

                    b.Property<string>("batch_class");

                    b.HasKey("Id");

                    b.HasIndex("batch_class");

                    b.ToTable("tb_m_participant");
                });

            modelBuilder.Entity("API.Models.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("tb_m_province");
                });

            modelBuilder.Entity("API.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("tb_m_role");
                });

            modelBuilder.Entity("API.Models.Room", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Create_Date");

                    b.Property<string>("Created_By");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset>("Update_Date");

                    b.Property<string>("Updated_By");

                    b.HasKey("Id");

                    b.ToTable("tb_m_room");
                });

            modelBuilder.Entity("API.Models.Type", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Create_Date");

                    b.Property<string>("Created_By");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset>("Update_Date");

                    b.Property<string>("Updated_By");

                    b.HasKey("Id");

                    b.ToTable("tb_m_type");
                });

            modelBuilder.Entity("API.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("tb_m_account");
                });

            modelBuilder.Entity("API.Models.Asset", b =>
                {
                    b.HasOne("API.Models.Participant", "Participant")
                        .WithMany()
                        .HasForeignKey("employee");

                    b.HasOne("API.Models.Type", "Types")
                        .WithMany()
                        .HasForeignKey("type");
                });

            modelBuilder.Entity("API.Models.BatchClass", b =>
                {
                    b.HasOne("API.Models.Batch", "Batches")
                        .WithMany()
                        .HasForeignKey("batch");

                    b.HasOne("API.Models.Room", "Rooms")
                        .WithMany()
                        .HasForeignKey("room");

                    b.HasOne("API.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("trainer");
                });

            modelBuilder.Entity("API.Models.Customer", b =>
                {
                    b.HasOne("API.Models.District", "District")
                        .WithMany("Customers")
                        .HasForeignKey("District_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("API.Models.Employee", "Employee")
                        .WithMany("Customers")
                        .HasForeignKey("RelationManager");
                });

            modelBuilder.Entity("API.Models.District", b =>
                {
                    b.HasOne("API.Models.Province", "Province")
                        .WithMany()
                        .HasForeignKey("Province_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("API.Models.Employee", b =>
                {
                    b.HasOne("API.Models.District", "District")
                        .WithMany()
                        .HasForeignKey("Hiring_Location")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("API.Models.User", "User")
                        .WithOne("Employee")
                        .HasForeignKey("API.Models.Employee", "NIK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("API.Models.EmployeeRole", b =>
                {
                    b.HasOne("API.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("Employee_Id");

                    b.HasOne("API.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("Role_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("API.Models.Participant", b =>
                {
                    b.HasOne("API.Models.BatchClass", "BatchClass")
                        .WithMany()
                        .HasForeignKey("batch_class");
                });
#pragma warning restore 612, 618
        }
    }
}
