namespace QuanLySinhVien;

public class LopHoc
{
    public string MaLop { get; set; } = "";
    public string TenLop { get; set; } = "";
}

public class SinhVien
{
    public string MaSV { get; set; } = "";
    public string HoTen { get; set; } = "";
    public DateTime NgaySinh { get; set; } = DateTime.Today;
    public string GioiTinh { get; set; } = "Nam";
    public string Email { get; set; } = "";
    public string DienThoai { get; set; } = "";
    public decimal Diem { get; set; }
    public string MaLop { get; set; } = "";
    public string TrangThai { get; set; } = "Đang học";
}
