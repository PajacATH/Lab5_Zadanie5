﻿// <auto-generated />
using System;
using Lab5_Zadanie5;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab5_Zadanie5.Migrations
{
    [DbContext(typeof(ConcertContext))]
    [Migration("20200402165538_Mig1")]
    partial class Mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab5_Zadanie5.Models.Address", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<int?>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Lab5_Zadanie5.Models.Band", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Band");
                });

            modelBuilder.Entity("Lab5_Zadanie5.Models.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voivodeship")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Lab5_Zadanie5.Models.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BandID")
                        .HasColumnType("int");

                    b.Property<int?>("CityID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("BandID");

                    b.HasIndex("CityID");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("Lab5_Zadanie5.Models.Ticket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EventID")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EventID");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Lab5_Zadanie5.Models.Address", b =>
                {
                    b.HasOne("Lab5_Zadanie5.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID");

                    b.HasOne("Lab5_Zadanie5.Models.Band", "Band")
                        .WithOne("Address")
                        .HasForeignKey("Lab5_Zadanie5.Models.Address", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lab5_Zadanie5.Models.Event", b =>
                {
                    b.HasOne("Lab5_Zadanie5.Models.Band", "Band")
                        .WithMany("Events")
                        .HasForeignKey("BandID");

                    b.HasOne("Lab5_Zadanie5.Models.City", "City")
                        .WithMany("Events")
                        .HasForeignKey("CityID");
                });

            modelBuilder.Entity("Lab5_Zadanie5.Models.Ticket", b =>
                {
                    b.HasOne("Lab5_Zadanie5.Models.Event", "Event")
                        .WithMany("Tickets")
                        .HasForeignKey("EventID");
                });
#pragma warning restore 612, 618
        }
    }
}
