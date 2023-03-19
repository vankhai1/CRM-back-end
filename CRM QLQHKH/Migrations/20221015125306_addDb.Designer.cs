﻿// <auto-generated />
using System;
using CRM_QLQHKH.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRM_QLQHKH.Migrations
{
    [DbContext(typeof(CRMDbContext))]
    [Migration("20221015125306_addDb")]
    partial class addDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRM_QLQHKH.Data.ChucVu", b =>
                {
                    b.Property<int>("IdCV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MoTa")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("TenChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCV");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("IdCV")
                        .HasColumnType("int");

                    b.Property<int?>("IdQuyen")
                        .HasColumnType("int");

                    b.Property<Guid?>("IdTK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("SDT")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("IdCV");

                    b.HasIndex("IdTK");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.TaiKhoan", b =>
                {
                    b.Property<Guid>("IdTK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTaiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTK");

                    b.ToTable("TaiKhoan");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.NhanVien", b =>
                {
                    b.HasOne("CRM_QLQHKH.Data.ChucVu", "chucVu")
                        .WithMany("NhanViens")
                        .HasForeignKey("IdCV");

                    b.HasOne("CRM_QLQHKH.Data.TaiKhoan", "TaiKhoan")
                        .WithMany("NhanViens")
                        .HasForeignKey("IdTK");

                    b.Navigation("chucVu");

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.TaiKhoan", b =>
                {
                    b.Navigation("NhanViens");
                });
#pragma warning restore 612, 618
        }
    }
}
