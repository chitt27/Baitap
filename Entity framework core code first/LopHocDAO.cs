using System.Data;

namespace QuanLySinhVien;

public class LopHocDAO
{
    public List<LopHoc> LayDanhSach()
    {
        try
        {
            var result = new List<LopHoc>();
            foreach (DataRow row in Database.Select("SELECT MaLop, TenLop FROM LopHoc ORDER BY MaLop").Rows)
                result.Add(new LopHoc { MaLop = row["MaLop"].ToString()!, TenLop = row["TenLop"].ToString()! });
            return result;
        }
        catch (Exception ex) { throw new Exception("Không đọc được danh sách lớp: " + ex.Message, ex); }
    }

    public bool TonTai(string maLop)
    {
        try { return Database.Count("SELECT COUNT(*) FROM LopHoc WHERE MaLop=@MaLop", Database.Param("@MaLop", maLop)) > 0; }
        catch (Exception ex) { throw new Exception("Không kiểm tra được mã lớp: " + ex.Message, ex); }
    }

    public int DemSinhVien(string maLop)
    {
        try { return Database.Count("SELECT COUNT(*) FROM SinhVien WHERE MaLop=@MaLop", Database.Param("@MaLop", maLop)); }
        catch (Exception ex) { throw new Exception("Không đếm được sinh viên trong lớp: " + ex.Message, ex); }
    }

    public void Them(LopHoc lop)
    {
        try { Database.Execute("INSERT INTO LopHoc(MaLop,TenLop) VALUES(@MaLop,@TenLop)", Database.Param("@MaLop", lop.MaLop), Database.Param("@TenLop", lop.TenLop)); }
        catch (Exception ex) { throw new Exception("Không thêm được lớp: " + ex.Message, ex); }
    }

    public void Sua(LopHoc lop)
    {
        try
        {
            if (Database.Execute("UPDATE LopHoc SET TenLop=@TenLop WHERE MaLop=@MaLop", Database.Param("@MaLop", lop.MaLop), Database.Param("@TenLop", lop.TenLop)) == 0)
                throw new Exception("Không tìm thấy lớp cần sửa.");
        }
        catch (Exception ex) { throw new Exception("Không sửa được lớp: " + ex.Message, ex); }
    }

    public void Xoa(string maLop)
    {
        try
        {
            if (Database.Execute("DELETE FROM LopHoc WHERE MaLop=@MaLop", Database.Param("@MaLop", maLop)) == 0)
                throw new Exception("Không tìm thấy lớp cần xóa.");
        }
        catch (Exception ex) { throw new Exception("Không xóa được lớp: " + ex.Message, ex); }
    }
}
