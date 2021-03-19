﻿// <auto-generated />
using System;
using CircusGroupsBot.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CircusGroupsBot.Migrations
{
    [DbContext(typeof(CircusDbContext))]
    [Migration("20210319120120_AddUserIdToSignup")]
    partial class AddUserIdToSignup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CircusGroupsBot.Events.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DateAndTime")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<ulong>("EventMessageId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("EventName")
                        .HasColumnType("longtext");

                    b.Property<ulong>("LeaderUserID")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("CircusGroupsBot.Events.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            Name = "Tank"
                        },
                        new
                        {
                            RoleId = 2,
                            Name = "Healer"
                        },
                        new
                        {
                            RoleId = 3,
                            Name = "DD"
                        },
                        new
                        {
                            RoleId = 4,
                            Name = "Runner"
                        },
                        new
                        {
                            RoleId = 5,
                            Name = "Maybe"
                        });
                });

            modelBuilder.Entity("CircusGroupsBot.Events.Event", b =>
                {
                    b.OwnsMany("CircusGroupsBot.Events.Signup", "Signups", b1 =>
                        {
                            b1.Property<string>("SignupId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("varchar(255)");

                            b1.Property<int>("EventId")
                                .HasColumnType("int");

                            b1.Property<bool>("IsRequired")
                                .HasColumnType("tinyint(1)");

                            b1.Property<int?>("RoleId")
                                .HasColumnType("int");

                            b1.Property<ulong>("UserId")
                                .HasColumnType("bigint unsigned");

                            b1.HasKey("SignupId");

                            b1.HasIndex("EventId");

                            b1.HasIndex("RoleId");

                            b1.ToTable("Signup");

                            b1.WithOwner()
                                .HasForeignKey("EventId");

                            b1.HasOne("CircusGroupsBot.Events.Role", "Role")
                                .WithMany()
                                .HasForeignKey("RoleId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
