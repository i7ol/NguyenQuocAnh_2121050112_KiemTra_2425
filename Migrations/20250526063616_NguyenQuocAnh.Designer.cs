﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcTest.Data;

#nullable disable

namespace MvcTest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250526063616_NguyenQuocAnh")]
    partial class NguyenQuocAnh
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MvcTest.Models.NguyenQuocAnh", b =>
                {
                    b.Property<string>("MaSv")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("maso")
                        .HasColumnType("int");

                    b.Property<int>("sdt")
                        .HasColumnType("int");

                    b.HasKey("MaSv");

                    b.ToTable("NguyenQuocAnh");
                });
#pragma warning restore 612, 618
        }
    }
}
