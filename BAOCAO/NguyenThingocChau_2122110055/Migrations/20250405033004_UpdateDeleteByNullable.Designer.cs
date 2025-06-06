﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NguyenThingocChau_2122110055.Data;

#nullable disable

namespace NguyenThingocChau_2122110055.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250405033004_UpdateDeleteByNullable")]
    partial class UpdateDeleteByNullable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NguyenThingocChau_2122110055.Model.Category", b =>
                {
                    b.Property<int>("Category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_id"));

                    b.Property<string>("Category_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Create_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Create_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Delete_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Delete_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Update_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Update_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Category_id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NguyenThingocChau_2122110055.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Category_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Create_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Create_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Delete_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Delete_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime?>("Update_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Update_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Category_id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("NguyenThingocChau_2122110055.Model.Product", b =>
                {
                    b.HasOne("NguyenThingocChau_2122110055.Model.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NguyenThingocChau_2122110055.Model.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
