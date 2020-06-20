﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SzczesliwyPlecak.Data;

namespace SzczesliwyPlecak.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20200620140928_TripUpdate")]
    partial class TripUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SzczesliwyPlecak.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Calories")
                        .HasColumnType("real");

                    b.Property<float>("Carbohydrates")
                        .HasColumnType("real");

                    b.Property<float>("Fat")
                        .HasColumnType("real");

                    b.Property<float>("Fibre")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Proteins")
                        .HasColumnType("real");

                    b.Property<float>("Salt")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("SzczesliwyPlecak.Models.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CaloriesNeeded")
                        .HasColumnType("real");

                    b.Property<float>("CarbohydratesNeeded")
                        .HasColumnType("real");

                    b.Property<int>("DurationInDays")
                        .HasColumnType("int");

                    b.Property<float>("FatNeeded")
                        .HasColumnType("real");

                    b.Property<int>("FemaleParticipants")
                        .HasColumnType("int");

                    b.Property<float>("FibreNeeded")
                        .HasColumnType("real");

                    b.Property<int>("MaleParticipants")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ProteinsNeeded")
                        .HasColumnType("real");

                    b.Property<float>("SaltNeeded")
                        .HasColumnType("real");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalTimeHiking")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Trip");
                });

            modelBuilder.Entity("SzczesliwyPlecak.Models.TripProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TripId");

                    b.ToTable("TripProduct");
                });

            modelBuilder.Entity("SzczesliwyPlecak.Models.TripProduct", b =>
                {
                    b.HasOne("SzczesliwyPlecak.Models.Product", "Product")
                        .WithMany("TripProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SzczesliwyPlecak.Models.Trip", "Trip")
                        .WithMany("TripProducts")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
