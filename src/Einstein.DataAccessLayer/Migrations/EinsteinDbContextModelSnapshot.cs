﻿// <auto-generated />
using System;
using Einstein.DataAccessLayer.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Einstein.DataAccessLayer.Migrations
{
    [DbContext(typeof(EinsteinDbContext))]
    partial class EinsteinDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Einstein.DataAccessLayer.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvailabilityPerWeek")
                        .HasColumnType("int");

                    b.Property<Guid>("EffectiveEndedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EffectiveEndedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EffectiveModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EffectiveModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EffectiveStartedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EffectiveStartedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EmployedSince")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeNumber")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FunctionLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FunctionTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Einstein.DataAccessLayer.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid>("EffectiveEndedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EffectiveEndedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EffectiveModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EffectiveModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EffectiveStartedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EffectiveStartedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FailedAttempts")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GoodLogins")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3593c7d7-43b2-4dd1-a900-3618e29d5ffa"),
                            Active = true,
                            EffectiveEndedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            EffectiveEndedOn = new DateTime(9999, 12, 31, 23, 59, 59, 997, DateTimeKind.Unspecified),
                            EffectiveModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            EffectiveModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EffectiveStartedBy = new Guid("3593c7d7-43b2-4dd1-a900-3618e29d5ffa"),
                            EffectiveStartedOn = new DateTime(2019, 12, 6, 23, 33, 45, 641, DateTimeKind.Local).AddTicks(1637),
                            Email = "einstein@bloemert.com",
                            FailedAttempts = 0,
                            Firstname = "Administrator",
                            GoodLogins = 0,
                            Lastname = "Bloemert",
                            PasswordData = "8a8ab4ae3b063c19103ddf08ab7fda9ec118abc73fbb65c1cd12217adbdaed1d52e5db1337cbf0f275641494823c36e631ccc8ac353459177bd41718df0b56f6",
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Einstein.DataAccessLayer.Entities.Employee", b =>
                {
                    b.HasOne("Einstein.DataAccessLayer.Entities.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");
                });

            modelBuilder.Entity("Einstein.DataAccessLayer.Entities.User", b =>
                {
                    b.HasOne("Einstein.DataAccessLayer.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");
                });
#pragma warning restore 612, 618
        }
    }
}
