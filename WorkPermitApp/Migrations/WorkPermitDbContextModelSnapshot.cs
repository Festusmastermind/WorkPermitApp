﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkPermitApp.Data;

#nullable disable

namespace WorkPermitApp.Migrations
{
    [DbContext(typeof(WorkPermitDbContext))]
    partial class WorkPermitDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WorkPermitApp.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("WorkPermitApp.Models.SiteChecker", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ByPassedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ByPassedReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ByPassedTagNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GasTesterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCriticalByPassed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCriticalLift")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGastested")
                        .HasColumnType("bit");

                    b.Property<bool>("IsIsolated")
                        .HasColumnType("bit");

                    b.Property<bool>("IsJsaReviewed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProvideAccess")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRestrictAccess")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSpecialiLightning")
                        .HasColumnType("bit");

                    b.Property<string>("LELPercentage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherSpecialRequirement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SiteTestingTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("WorkPermitId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("WorkPermitId")
                        .IsUnique()
                        .HasFilter("[WorkPermitId] IS NOT NULL");

                    b.ToTable("SiteCheckers");
                });

            modelBuilder.Entity("WorkPermitApp.Models.WorkPermit", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EquipmentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsTermAndCondition")
                        .HasColumnType("bit");

                    b.Property<string>("JsaNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PermitStatus")
                        .HasColumnType("int");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("WorkDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkLocation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("WorkPermits");
                });

            modelBuilder.Entity("WorkPermitApp.Models.SiteChecker", b =>
                {
                    b.HasOne("WorkPermitApp.Models.WorkPermit", "WorkPermit")
                        .WithOne("SiteChecker")
                        .HasForeignKey("WorkPermitApp.Models.SiteChecker", "WorkPermitId");

                    b.Navigation("WorkPermit");
                });

            modelBuilder.Entity("WorkPermitApp.Models.WorkPermit", b =>
                {
                    b.HasOne("WorkPermitApp.Models.AppUser", "AppUser")
                        .WithMany("WorkPermits")
                        .HasForeignKey("AppUserId");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("WorkPermitApp.Models.AppUser", b =>
                {
                    b.Navigation("WorkPermits");
                });

            modelBuilder.Entity("WorkPermitApp.Models.WorkPermit", b =>
                {
                    b.Navigation("SiteChecker");
                });
#pragma warning restore 612, 618
        }
    }
}
