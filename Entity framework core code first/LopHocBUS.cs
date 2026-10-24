namespace QuanLySinhVien;

public class LopHocBUS
{
    private readonly LopHocDAO dao = new();
    public List<LopHoc> LayDanhSach() => dao.LayDanhSach();

    public void Them(LopHoc lop)
    {
        if (string.IsNullOrWhiteSpace(lop.MaLop) || string.IsNullOrWhiteSpace(lop.TenLop))
            throw new Exception("Cần nhập mã lớp và tên lớp.");
        lop.MaLop = lop.MaLop.Trim().ToUpper();
        lop.TenLop = lop.TenLop.Trim();
        if (dao.TonTai(lop.MaLop)) throw new Exception("Mã lớp này đã tồn tại.");
        dao.Them(lop);
    }

    public void Sua(LopHoc lop)
    {
        if (string.IsNullOrWhiteSpace(lop.MaLop) || string.IsNullOrWhiteSpace(lop.TenLop))
            throw new Exception("Cần nhập mã lớp và tên lớp.");
        lop.MaLop = lop.MaLop.Trim().ToUpper();
        lop.TenLop = lop.TenLop.Trim();
        dao.Sua(lop);
    }

    public void Xoa(string maLop)
    {
        if (string.IsNullOrWhiteSpace(maLop)) throw new Exception("Hãy chọn lớp cần xóa.");
        maLop = maLop.Trim().ToUpper();
        if (dao.DemSinhVien(maLop) > 0) throw new Exception("Lớp vẫn còn sinh viên, không thể xóa.");
        dao.Xoa(maLop);
    }
}
