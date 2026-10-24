using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace QuanLySinhVien;

public class QLSVContext : DbContext
{
    public DbSet<SinhVien> SinhViens => Set<SinhVien>();
    public DbSet<LopHoc> LopHocs => Set<LopHoc>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseMySql(QuanLySinhVien.Database.ConnectionString, new MySqlServerVersion(new Version(8, 0, 0)));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LopHoc>(entity =>
        {
            entity.ToTable("LopHoc");
            entity.HasKey(x => x.MaLop);
            entity.Property(x => x.MaLop).HasMaxLength(20).IsRequired();
            entity.Property(x => x.TenLop).HasMaxLength(100).IsRequired();
            entity.HasData(
                new LopHoc { MaLop = "CNTT01", TenLop = "Công nghệ thông tin 01" },
                new LopHoc { MaLop = "KTPM01", TenLop = "Kỹ thuật phần mềm 01" });
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.ToTable("SinhVien");
            entity.HasKey(x => x.MaSV);
            entity.Property(x => x.MaSV).HasMaxLength(20).IsRequired();
            entity.Property(x => x.HoTen).HasMaxLength(100).IsRequired();
            entity.Property(x => x.NgaySinh).HasColumnType("date").IsRequired();
            entity.Property(x => x.GioiTinh).HasMaxLength(10).IsRequired();
            entity.Property(x => x.Email).HasMaxLength(100).IsRequired();
            entity.Property(x => x.DienThoai).HasMaxLength(20).IsRequired();
            entity.Property(x => x.Diem).HasPrecision(4, 1).IsRequired();
            entity.Property(x => x.MaLop).HasMaxLength(20).IsRequired();
            entity.Property(x => x.TrangThai).HasMaxLength(30).IsRequired();
            entity.HasOne<LopHoc>().WithMany().HasForeignKey(x => x.MaLop)
                .OnDelete(DeleteBehavior.Restrict);
            entity.HasData(
                new SinhVien { MaSV = "SV001", HoTen = "Nguyễn Văn An", NgaySinh = new DateTime(2005, 8, 15),
                    GioiTinh = "Nam", Email = "an.nv@vju.ac.vn", DienThoai = "0912345678", Diem = 8.5m,
                    MaLop = "KTPM01", TrangThai = "Đang học" },
                new SinhVien { MaSV = "SV002", HoTen = "Trần Minh Anh", NgaySinh = new DateTime(2005, 1, 22),
                    GioiTinh = "Nữ", Email = "anh.tm@vju.ac.vn", DienThoai = "0987654321", Diem = 9.0m,
                    MaLop = "CNTT01", TrangThai = "Đang học" });
        });
    }
}
