using System.Data;
using MySqlConnector;

namespace QuanLySinhVien;

public class SinhVienDAO
{
    public List<SinhVien> TimKiem(string tuKhoa, string maLop, decimal diemTu)
    {
        try
        {
            const string sql = @"SELECT MaSV,HoTen,NgaySinh,GioiTinh,Email,DienThoai,Diem,MaLop,TrangThai
                                 FROM SinhVien
                                 WHERE (MaSV LIKE @TuKhoa OR HoTen LIKE @TuKhoa OR Email LIKE @TuKhoa OR DienThoai LIKE @TuKhoa)
                                   AND (@MaLop='' OR MaLop=@MaLop) AND Diem>=@DiemTu ORDER BY MaSV";
            DataTable table = Database.Select(sql, Database.Param("@TuKhoa", "%" + tuKhoa + "%"),
                Database.Param("@MaLop", maLop), Database.Param("@DiemTu", diemTu));
            var result = new List<SinhVien>();
            foreach (DataRow row in table.Rows)
                result.Add(new SinhVien
                {
                    MaSV = row["MaSV"].ToString()!, HoTen = row["HoTen"].ToString()!,
                    NgaySinh = (DateTime)row["NgaySinh"], GioiTinh = row["GioiTinh"].ToString()!,
                    Email = row["Email"].ToString()!, DienThoai = row["DienThoai"].ToString()!,
                    Diem = Convert.ToDecimal(row["Diem"]), MaLop = row["MaLop"].ToString()!,
                    TrangThai = row["TrangThai"].ToString()!
                });
            return result;
        }
        catch (Exception ex) { throw new Exception("Không đọc được dữ liệu sinh viên: " + ex.Message, ex); }
    }

    public bool TonTai(string maSV)
    {
        try { return Database.Count("SELECT COUNT(*) FROM SinhVien WHERE MaSV=@MaSV", Database.Param("@MaSV", maSV)) > 0; }
        catch (Exception ex) { throw new Exception("Không kiểm tra được mã sinh viên: " + ex.Message, ex); }
    }

    private static MySqlParameter[] ThamSo(SinhVien sv) => new[]
    {
        Database.Param("@MaSV", sv.MaSV), Database.Param("@HoTen", sv.HoTen),
        Database.Param("@NgaySinh", sv.NgaySinh), Database.Param("@GioiTinh", sv.GioiTinh),
        Database.Param("@Email", sv.Email), Database.Param("@DienThoai", sv.DienThoai),
        Database.Param("@Diem", sv.Diem), Database.Param("@MaLop", sv.MaLop),
        Database.Param("@TrangThai", sv.TrangThai)
    };

    public void Them(SinhVien sv)
    {
        try
        {
            Database.Execute(@"INSERT INTO SinhVien(MaSV,HoTen,NgaySinh,GioiTinh,Email,DienThoai,Diem,MaLop,TrangThai)
                               VALUES(@MaSV,@HoTen,@NgaySinh,@GioiTinh,@Email,@DienThoai,@Diem,@MaLop,@TrangThai)", ThamSo(sv));
        }
        catch (Exception ex) { throw new Exception("Không thêm được sinh viên: " + ex.Message, ex); }
    }

    public void Sua(SinhVien sv)
    {
        try
        {
            int count = Database.Execute(@"UPDATE SinhVien SET HoTen=@HoTen,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,
                Email=@Email,DienThoai=@DienThoai,Diem=@Diem,MaLop=@MaLop,TrangThai=@TrangThai WHERE MaSV=@MaSV", ThamSo(sv));
            if (count == 0) throw new Exception("Không tìm thấy sinh viên cần sửa.");
        }
        catch (Exception ex) { throw new Exception("Không sửa được sinh viên: " + ex.Message, ex); }
    }

    public void Xoa(string maSV)
    {
        try
        {
            if (Database.Execute("DELETE FROM SinhVien WHERE MaSV=@MaSV", Database.Param("@MaSV", maSV)) == 0)
                throw new Exception("Không tìm thấy sinh viên cần xóa.");
        }
        catch (Exception ex) { throw new Exception("Không xóa được sinh viên: " + ex.Message, ex); }
    }
}
