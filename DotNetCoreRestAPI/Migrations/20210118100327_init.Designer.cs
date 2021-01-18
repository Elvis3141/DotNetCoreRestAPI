﻿// <auto-generated />
using System;
using DotNetCoreRestAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetCoreRestAPI.Migrations
{
    [DbContext(typeof(PatientContext))]
    [Migration("20210118100327_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DotNetCoreRestAPI.Models.Patient", b =>
                {
                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.HasKey("PatientID");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("DotNetCoreRestAPI.Models.PersonalData", b =>
                {
                    b.Property<int>("DataID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.HasKey("DataID");

                    b.HasIndex("PatientID")
                        .IsUnique();

                    b.ToTable("PersonalData");
                });

            modelBuilder.Entity("DotNetCoreRestAPI.Models.Temperature", b =>
                {
                    b.Property<int>("TempID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("BodyTemperature")
                        .HasColumnType("float");

                    b.Property<DateTime>("MeasurementDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("PatientID")
                        .HasColumnType("int");

                    b.HasKey("TempID");

                    b.HasIndex("PatientID");

                    b.ToTable("TempeData");
                });

            modelBuilder.Entity("DotNetCoreRestAPI.Models.PersonalData", b =>
                {
                    b.HasOne("DotNetCoreRestAPI.Models.Patient", null)
                        .WithOne("personalData")
                        .HasForeignKey("DotNetCoreRestAPI.Models.PersonalData", "PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DotNetCoreRestAPI.Models.Temperature", b =>
                {
                    b.HasOne("DotNetCoreRestAPI.Models.Patient", null)
                        .WithMany("TempData")
                        .HasForeignKey("PatientID");
                });
#pragma warning restore 612, 618
        }
    }
}
