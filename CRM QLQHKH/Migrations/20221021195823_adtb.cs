using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_QLQHKH.Migrations
{
    public partial class adtb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LHKH",
                columns: table => new
                {
                    IdLHKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoTenKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDTKH = table.Column<long>(type: "bigint", nullable: false),
                    NSKH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TieuDe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LHKH", x => x.IdLHKH);
                });

            migrationBuilder.CreateTable(
                name: "LoaiNV",
                columns: table => new
                {
                    IdLoaiNV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNV = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiNV", x => x.IdLoaiNV);
                });

            migrationBuilder.CreateTable(
                name: "TrangThaiKHTN",
                columns: table => new
                {
                    IdTrangThai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThaiKHTN", x => x.IdTrangThai);
                });

            migrationBuilder.CreateTable(
                name: "TrangThaiNV",
                columns: table => new
                {
                    IdTrangThaiNV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTrangThaiNV = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThaiNV", x => x.IdTrangThaiNV);
                });

            migrationBuilder.CreateTable(
                name: "KHTN",
                columns: table => new
                {
                    IdKHTN = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HanChot = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    IdTrangThai = table.Column<int>(type: "int", nullable: false),
                    IdLHKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHTN", x => x.IdKHTN);
                    table.ForeignKey(
                        name: "FK_KHTN_LHKH_IdLHKH",
                        column: x => x.IdLHKH,
                        principalTable: "LHKH",
                        principalColumn: "IdLHKH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KHTN_NhanVien_Id",
                        column: x => x.Id,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KHTN_TrangThaiKHTN_IdTrangThai",
                        column: x => x.IdTrangThai,
                        principalTable: "TrangThaiKHTN",
                        principalColumn: "IdTrangThai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhiemVu",
                columns: table => new
                {
                    IdNV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhiemVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HanChotNV = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdKHTN = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLoaiNV = table.Column<int>(type: "int", nullable: false),
                    IdLoai = table.Column<int>(type: "int", nullable: true),
                    IdTrangThaiNV = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhiemVu", x => x.IdNV);
                    table.ForeignKey(
                        name: "FK_NhiemVu_KHTN_IdKHTN",
                        column: x => x.IdKHTN,
                        principalTable: "KHTN",
                        principalColumn: "IdKHTN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhiemVu_LoaiNV_IdLoai",
                        column: x => x.IdLoai,
                        principalTable: "LoaiNV",
                        principalColumn: "IdLoaiNV",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhiemVu_TrangThaiNV_IdTrangThaiNV",
                        column: x => x.IdTrangThaiNV,
                        principalTable: "TrangThaiNV",
                        principalColumn: "IdTrangThaiNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KHTN_Id",
                table: "KHTN",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_KHTN_IdLHKH",
                table: "KHTN",
                column: "IdLHKH");

            migrationBuilder.CreateIndex(
                name: "IX_KHTN_IdTrangThai",
                table: "KHTN",
                column: "IdTrangThai");

            migrationBuilder.CreateIndex(
                name: "IX_NhiemVu_IdKHTN",
                table: "NhiemVu",
                column: "IdKHTN");

            migrationBuilder.CreateIndex(
                name: "IX_NhiemVu_IdLoai",
                table: "NhiemVu",
                column: "IdLoai");

            migrationBuilder.CreateIndex(
                name: "IX_NhiemVu_IdTrangThaiNV",
                table: "NhiemVu",
                column: "IdTrangThaiNV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhiemVu");

            migrationBuilder.DropTable(
                name: "KHTN");

            migrationBuilder.DropTable(
                name: "LoaiNV");

            migrationBuilder.DropTable(
                name: "TrangThaiNV");

            migrationBuilder.DropTable(
                name: "LHKH");

            migrationBuilder.DropTable(
                name: "TrangThaiKHTN");
        }
    }
}
