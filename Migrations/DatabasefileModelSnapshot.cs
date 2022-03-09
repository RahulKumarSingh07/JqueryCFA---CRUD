﻿// <auto-generated />
using System;
using First.DATABASE;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace First.Migrations
{
    [DbContext(typeof(Databasefile))]
    partial class DatabasefileModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("First.Models.Country", b =>
                {
                    b.Property<int>("C_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("C_Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("First.Models.Designation", b =>
                {
                    b.Property<int>("Did")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Designations")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Did");

                    b.ToTable("Designations_Col");
                });

            modelBuilder.Entity("First.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryC_Id")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QfId")
                        .HasColumnType("int");

                    b.Property<int?>("StateS_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryC_Id");

                    b.HasIndex("QfId");

                    b.HasIndex("StateS_Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("First.Models.EmployeeNew", b =>
                {
                    b.Property<int>("Empid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Bonus")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DegisnationDid")
                        .HasColumnType("int");

                    b.Property<int?>("EmptypeTid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pincode")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("salary")
                        .HasColumnType("int");

                    b.HasKey("Empid");

                    b.HasIndex("DegisnationDid");

                    b.HasIndex("EmptypeTid");

                    b.ToTable("NewEmployees");
                });

            modelBuilder.Entity("First.Models.Emptype", b =>
                {
                    b.Property<int>("Tid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Types")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Tid");

                    b.ToTable("Emptypes");
                });

            modelBuilder.Entity("First.Models.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Qualifications");
                });

            modelBuilder.Entity("First.Models.State", b =>
                {
                    b.Property<int>("S_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GetCountryC_Id")
                        .HasColumnType("int");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("S_Id");

                    b.HasIndex("GetCountryC_Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("First.Models.Student", b =>
                {
                    b.Property<int>("studentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("studentAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("studentClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("studentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("studentId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("First.Models.Employee", b =>
                {
                    b.HasOne("First.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryC_Id");

                    b.HasOne("First.Models.Qualification", "Qf")
                        .WithMany()
                        .HasForeignKey("QfId");

                    b.HasOne("First.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateS_Id");

                    b.Navigation("Country");

                    b.Navigation("Qf");

                    b.Navigation("State");
                });

            modelBuilder.Entity("First.Models.EmployeeNew", b =>
                {
                    b.HasOne("First.Models.Designation", "Degisnation")
                        .WithMany()
                        .HasForeignKey("DegisnationDid");

                    b.HasOne("First.Models.Emptype", "Emptype")
                        .WithMany()
                        .HasForeignKey("EmptypeTid");

                    b.Navigation("Degisnation");

                    b.Navigation("Emptype");
                });

            modelBuilder.Entity("First.Models.State", b =>
                {
                    b.HasOne("First.Models.Country", "GetCountry")
                        .WithMany()
                        .HasForeignKey("GetCountryC_Id");

                    b.Navigation("GetCountry");
                });
#pragma warning restore 612, 618
        }
    }
}
