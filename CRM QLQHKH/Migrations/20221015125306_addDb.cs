using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_QLQHKH.Migrations
{
    public partial class addDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    IdCV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.IdCV);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    IdTK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.IdTK);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<long>(type: "bigint", nullable: false),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTK = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCV = table.Column<int>(type: "int", nullable: true),
                    IdQuyen = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdCV",
                        column: x => x.IdCV,
                        principalTable: "ChucVu",
                        principalColumn: "IdCV",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanVien_TaiKhoan_IdTK",
                        column: x => x.IdTK,
                        principalTable: "TaiKhoan",
                        principalColumn: "IdTK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCV",
                table: "NhanVien",
                column: "IdCV");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdTK",
                table: "NhanVien",
                column: "IdTK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "TaiKhoan");
        }
    }
}
