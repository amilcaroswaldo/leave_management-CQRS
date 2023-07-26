﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using leave_management.Persistance.DataBaseContext;

#nullable disable

namespace leave_management.Persistance.Migrations
{
    [DbContext(typeof(DBContextPg))]
    partial class DBContextPgModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("leave_management.Domain.LeaveAllocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("text");

                    b.Property<int>("LeaveTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("NumberOfDays")
                        .HasColumnType("integer");

                    b.Property<int>("Period")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LeaveTypeId");

                    b.ToTable("LeaveAllocation");
                });

            modelBuilder.Entity("leave_management.Domain.LeaveRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Aproved")
                        .HasColumnType("boolean");

                    b.Property<bool>("Canceled")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateRequested")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("LeaveTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("RequestComments")
                        .HasColumnType("text");

                    b.Property<string>("RequestingEmployeeId")
                        .HasColumnType("text");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("LeaveTypeId");

                    b.ToTable("LeaveRequests");
                });

            modelBuilder.Entity("leave_management.Domain.LeaveType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DefaultDays")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("LeaveTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 7, 25, 15, 26, 45, 742, DateTimeKind.Local).AddTicks(698),
                            DateModified = new DateTime(2023, 7, 25, 15, 26, 45, 742, DateTimeKind.Local).AddTicks(714),
                            DefaultDays = 1,
                            Name = "Name"
                        });
                });

            modelBuilder.Entity("leave_management.Domain.LeaveAllocation", b =>
                {
                    b.HasOne("leave_management.Domain.LeaveType", "LeaveType")
                        .WithMany()
                        .HasForeignKey("LeaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LeaveType");
                });

            modelBuilder.Entity("leave_management.Domain.LeaveRequest", b =>
                {
                    b.HasOne("leave_management.Domain.LeaveType", "LeaveType")
                        .WithMany()
                        .HasForeignKey("LeaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LeaveType");
                });
#pragma warning restore 612, 618
        }
    }
}
