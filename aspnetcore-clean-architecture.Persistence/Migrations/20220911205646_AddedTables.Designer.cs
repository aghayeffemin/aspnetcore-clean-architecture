﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aspnetcore_clean_architecture.Persistence;

#nullable disable

namespace aspnetcore_clean_architecture.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220911205646_AddedTables")]
    partial class AddedTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("aspnetcore_clean_architecture.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5304733a-7656-469c-b03c-83de78a45101"),
                            DateCreated = new DateTime(2022, 9, 11, 22, 56, 46, 833, DateTimeKind.Local).AddTicks(8904),
                            DateModified = new DateTime(2022, 9, 11, 22, 56, 46, 833, DateTimeKind.Local).AddTicks(8938),
                            Name = "John",
                            Surname = "Doe"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
