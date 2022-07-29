﻿// <auto-generated />
using System;
using MeetingsUsers.WpApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MeetingsUsers.WpApi.Migrations
{
    [DbContext(typeof(MeetingContext))]
    [Migration("20220729171914_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("MeetingsUsers.WpApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 7, 29, 19, 19, 14, 262, DateTimeKind.Local).AddTicks(6684),
                            Email = "mm@example.com",
                            FirstName = "Mariusz",
                            LastName = "Malec",
                            PasswordHash = "mm13@!",
                            PhoneNumber = ""
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 7, 29, 19, 19, 14, 265, DateTimeKind.Local).AddTicks(5621),
                            Email = "bm@example.com",
                            FirstName = "Barbara",
                            LastName = "Malec",
                            PasswordHash = "bm01@!",
                            PhoneNumber = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
