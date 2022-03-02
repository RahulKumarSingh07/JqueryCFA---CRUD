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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("C_Id");

                    b.ToTable("Countries");
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
