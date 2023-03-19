using Microsoft.EntityFrameworkCore;

namespace CRM_QLQHKH.Data
{
    public class CRMDbContext: DbContext
    {
        public CRMDbContext(DbContextOptions option) : base(option) { }

        
            public DbSet<NhanVien> NhanViens { get; set; }
            public DbSet<TaiKhoan> TaiKhoans { get; set; }
            public DbSet<ChucVu>ChucVus { get; set; }   
            public DbSet<KHTN> KHTNs { get; set; }
            public DbSet<LHKH> LHKHs { get; set; }
            public DbSet<LoaiNV> loaiNVs { get; set; }
            public DbSet<NhiemVu> nhiemVus { get; set; }
            public DbSet<TrangThaiNV> trangThaiNVs { get; set; }
            public DbSet<TrangThaiKHTN> trangThaiKHTNs { get; set; }

    }
}
