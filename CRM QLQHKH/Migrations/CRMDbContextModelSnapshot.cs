﻿// <auto-generated />
using System;
using CRM_QLQHKH.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRM_QLQHKH.Migrations
{
    [DbContext(typeof(CRMDbContext))]
    partial class CRMDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("CRM_QLQHKH.Data.KHTN", b =>
                {
                    b.Property<Guid>("IdKHTN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("HanChot")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("Id")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdLHKH")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("IdTrangThai")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("IdKHTN");

                    b.HasIndex("Id");

                    b.HasIndex("IdLHKH");

                    b.HasIndex("IdTrangThai");

                    b.ToTable("KHTN");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.LHKH", b =>
                {
                    b.Property<Guid>("IdLHKH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTenKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NSKH")
                        .HasColumnType("datetime2");

                    b.Property<long>("SDTKH")
                        .HasColumnType("bigint");

                    b.Property<string>("TieuDe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLHKH");

                    b.ToTable("LHKH");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.LoaiNV", b =>
                {
                    b.Property<int>("IdLoaiNV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLoaiNV");

                    b.ToTable("LoaiNV");
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

            modelBuilder.Entity("CRM_QLQHKH.Data.NhiemVu", b =>
                {
                    b.Property<int>("IdNV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("HanChotNV")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("IdKHTN")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("IdLoai")
                        .HasColumnType("int");

                    b.Property<int?>("IdLoaiNV")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("IdTrangThaiNV")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("TenNhiemVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdNV");

                    b.HasIndex("IdKHTN");

                    b.HasIndex("IdLoai");

                    b.HasIndex("IdTrangThaiNV");

                    b.ToTable("NhiemVu");
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

            modelBuilder.Entity("CRM_QLQHKH.Data.TrangThaiKHTN", b =>
                {
                    b.Property<int>("IdTrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenTrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTrangThai");

                    b.ToTable("TrangThaiKHTN");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.TrangThaiNV", b =>
                {
                    b.Property<int>("IdTrangThaiNV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenTrangThaiNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTrangThaiNV");

                    b.ToTable("TrangThaiNV");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.KHTN", b =>
                {
                    b.HasOne("CRM_QLQHKH.Data.NhanVien", "nhanVien")
                        .WithMany("KHTNs")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRM_QLQHKH.Data.LHKH", "lHKH")
                        .WithMany("KHTNs")
                        .HasForeignKey("IdLHKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRM_QLQHKH.Data.TrangThaiKHTN", "trangThaiKHTN")
                        .WithMany("KHTNs")
                        .HasForeignKey("IdTrangThai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("lHKH");

                    b.Navigation("nhanVien");

                    b.Navigation("trangThaiKHTN");
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

            modelBuilder.Entity("CRM_QLQHKH.Data.NhiemVu", b =>
                {
                    b.HasOne("CRM_QLQHKH.Data.KHTN", "kHTN")
                        .WithMany("NhiemVus")
                        .HasForeignKey("IdKHTN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRM_QLQHKH.Data.LoaiNV", "loaiNV")
                        .WithMany("NhiemVus")
                        .HasForeignKey("IdLoai");

                    b.HasOne("CRM_QLQHKH.Data.TrangThaiNV", "trangThaiNV")
                        .WithMany("NhiemVus")
                        .HasForeignKey("IdTrangThaiNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("kHTN");

                    b.Navigation("loaiNV");

                    b.Navigation("trangThaiNV");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.KHTN", b =>
                {
                    b.Navigation("NhiemVus");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.LHKH", b =>
                {
                    b.Navigation("KHTNs");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.LoaiNV", b =>
                {
                    b.Navigation("NhiemVus");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.NhanVien", b =>
                {
                    b.Navigation("KHTNs");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.TaiKhoan", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.TrangThaiKHTN", b =>
                {
                    b.Navigation("KHTNs");
                });

            modelBuilder.Entity("CRM_QLQHKH.Data.TrangThaiNV", b =>
                {
                    b.Navigation("NhiemVus");
                });
#pragma warning restore 612, 618
        }
    }
}
