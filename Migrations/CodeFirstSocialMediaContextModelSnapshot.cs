﻿// <auto-generated />
using System;
using CodeFirstSocialMediaDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstSocialMediaDb.Migrations
{
    [DbContext(typeof(CodeFirstSocialMediaContext))]
    partial class CodeFirstSocialMediaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.AspNetRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedName" }, "RoleNameIndex")
                        .IsUnique()
                        .HasFilter("([NormalizedName] IS NOT NULL)");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.AspNetRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetRoleClaims_RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.AspNetUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedEmail" }, "EmailIndex");

                    b.HasIndex(new[] { "NormalizedUserName" }, "UserNameIndex")
                        .IsUnique()
                        .HasFilter("([NormalizedUserName] IS NOT NULL)");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.AspNetUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserClaims_UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.AspNetUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserLogins_UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.AspNetUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.AspNetUserToken", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.FollowedUser", b =>
                {
                    b.Property<string>("FollowingUser")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserTofollow")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FollowingUser", "UserTofollow");

                    b.ToTable("FollowedUser");
                });

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AspNetUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(280)
                        .HasColumnType("nvarchar(280)");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.AspNetRoleClaim", b =>
                {
                    b.HasOne("CodeFirstSocialMediaDb.Models.AspNetRole", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.AspNetUserClaim", b =>
                {
                    b.HasOne("CodeFirstSocialMediaDb.Models.AspNetUser", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.AspNetUserLogin", b =>
                {
                    b.HasOne("CodeFirstSocialMediaDb.Models.AspNetUser", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.AspNetUserRole", b =>
                {
                    b.HasOne("CodeFirstSocialMediaDb.Models.AspNetRole", "Role")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstSocialMediaDb.Models.AspNetUser", "User")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.AspNetUserToken", b =>
                {
                    b.HasOne("CodeFirstSocialMediaDb.Models.AspNetUser", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.Post", b =>
                {
                    b.HasOne("CodeFirstSocialMediaDb.Models.AspNetUser", "AspNetUser")
                        .WithMany("Posts")
                        .HasForeignKey("AspNetUserId");

                    b.Navigation("AspNetUser");
                });

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.AspNetRole", b =>
                {
                    b.Navigation("AspNetRoleClaims");

                    b.Navigation("AspNetUserRoles");
                });

            modelBuilder.Entity("CodeFirstSocialMediaDb.Models.AspNetUser", b =>
                {
                    b.Navigation("AspNetUserClaims");

                    b.Navigation("AspNetUserLogins");

                    b.Navigation("AspNetUserRoles");

                    b.Navigation("AspNetUserTokens");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
