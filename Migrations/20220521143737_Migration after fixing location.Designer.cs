﻿// <auto-generated />
using System;
using Let_sTalk.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LetsTalkBackend.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220521143737_Migration after fixing location")]
    partial class Migrationafterfixinglocation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Let_sTalk.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Let_sTalk.Models.Match", b =>
                {
                    b.Property<int>("IdMatch")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Created")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int>("IsMatched")
                        .HasColumnType("int");

                    b.Property<string>("Updated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User1")
                        .HasColumnType("int");

                    b.Property<int>("User2")
                        .HasColumnType("int");

                    b.HasKey("IdMatch");

                    b.ToTable("matches");
                });

            modelBuilder.Entity("Let_sTalk.Models.Preference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CuisineCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CuisineName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("preferences");
                });

            modelBuilder.Entity("Let_sTalk.Models.Reservation", b =>
                {
                    b.Property<int>("IdReservation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApiUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdReservation");

                    b.ToTable("reservations");
                });

            modelBuilder.Entity("Let_sTalk.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DOB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirebaseId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("LocationId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Let_sTalk.Models.UserPreference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int>("PreferenceId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PreferenceId");

                    b.HasIndex("UserId");

                    b.ToTable("userPreferences");
                });

            modelBuilder.Entity("Let_sTalk.Models.User", b =>
                {
                    b.HasOne("Let_sTalk.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Let_sTalk.Models.UserPreference", b =>
                {
                    b.HasOne("Let_sTalk.Models.Preference", "Preference")
                        .WithMany("UserPreferences")
                        .HasForeignKey("PreferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Let_sTalk.Models.User", "User")
                        .WithMany("UserPreferences")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Preference");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Let_sTalk.Models.Preference", b =>
                {
                    b.Navigation("UserPreferences");
                });

            modelBuilder.Entity("Let_sTalk.Models.User", b =>
                {
                    b.Navigation("UserPreferences");
                });
#pragma warning restore 612, 618
        }
    }
}
