﻿// <auto-generated />
using System;
using MessageBoard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MessageBoard.Migrations
{
    [DbContext(typeof(MessageBoardContext))]
    [Migration("20221025175758_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MessageBoard.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            Name = "Halloweenie Parties"
                        },
                        new
                        {
                            GroupId = 2,
                            Name = "Video Gaymezzzzz"
                        },
                        new
                        {
                            GroupId = 3,
                            Name = "Locate the PSL goodies"
                        });
                });

            modelBuilder.Entity("MessageBoard.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Body")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("MessageId");

                    b.HasIndex("GroupId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            MessageId = 1,
                            Author = "GhostiniLinguini",
                            Body = "I'm looking for the spookiest party of all, please help???",
                            Date = new DateTime(2006, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 1,
                            Title = "Scary Party???"
                        },
                        new
                        {
                            MessageId = 2,
                            Author = "NoScariesPlease",
                            Body = "I hate ghosts!!!  I want to go to a halloween party but if I see a ghost I'll p** my pants, please don't recommend parties w/ ghosts",
                            Date = new DateTime(2010, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 1,
                            Title = "No ghosts please"
                        },
                        new
                        {
                            MessageId = 3,
                            Author = "DewForMeAndU",
                            Body = "Holy CRUD I love gaming, particularly as a non-heterosexual/non-binary person.  It RULES!!!  I love Mountain Dew, also (unrelated).",
                            Date = new DateTime(2003, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 2,
                            Title = "Gaming!!!!"
                        },
                        new
                        {
                            MessageId = 4,
                            Author = "DewForMeAndU",
                            Body = "It's been ten years and I'm still gaming.  Darn, it still rules so hard.  Still not straight btw.",
                            Date = new DateTime(2013, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 2,
                            Title = "GAMING!!!!"
                        },
                        new
                        {
                            MessageId = 5,
                            Author = "WitchyTwitchy123",
                            Body = "I'm looking for a magician that serves alchemical potions for all my spooky spells.",
                            Date = new DateTime(1700, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 1,
                            Title = "Magical Drinks Needed!"
                        },
                        new
                        {
                            MessageId = 6,
                            Author = "PSLlov3rkissessxoxo",
                            Body = "I'm looking for the best Trader Joe's PSL treats. Please Help!!",
                            Date = new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 3,
                            Title = "Trader Joes PSL?"
                        });
                });

            modelBuilder.Entity("MessageBoard.Models.Message", b =>
                {
                    b.HasOne("MessageBoard.Models.Group", null)
                        .WithMany("Messages")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MessageBoard.Models.Group", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
