namespace QuanLySinhVien;

public class SinhVienBUS
{
    private readonly SinhVienDAO dao = new();
    private readonly LopHocDAO lopDao = new();

    public List<SinhVien> TimKiem(string tuKhoa, string maLop, decimal diemTu)
    {
        if (diemTu < 0 || diemTu > 10) throw new Exception("Điểm lọc phải từ 0 đến 10.");
        return dao.TimKiem(tuKhoa.Trim(), maLop, diemTu);
    }

    private void KiemTra(SinhVien sv)
    {
        sv.MaSV = sv.MaSV.Trim().ToUpper();
        sv.HoTen = sv.HoTen.Trim();
        sv.Email = sv.Email.Trim();
        sv.DienThoai = sv.DienThoai.Trim();
        if (sv.MaSV.Length == 0 || sv.HoTen.Length == 0 || sv.MaLop.Length == 0 || sv.Email.Length == 0 || sv.DienThoai.Length == 0)
            throw new Exception("Hãy nhập đủ mã SV, họ tên, lớp, email và điện thoại.");
        if (sv.Diem < 0 || sv.Diem > 10) throw new Exception("Điểm phải từ 0 đến 10.");
        if (!sv.Email.Contains('@')) throw new Exception("Email chưa đúng định dạng.");
        if (!lopDao.TonTai(sv.MaLop)) throw new Exception("Lớp được chọn không tồn tại.");
    }

    public void Them(SinhVien sv)
    {
        KiemTra(sv);
        if (dao.TonTai(sv.MaSV)) throw new Exception("Mã sinh viên này đã tồn tại.");
        dao.Them(sv);
    }

    public void Sua(SinhVien sv)
    {
        KiemTra(sv);
        dao.Sua(sv);
    }

    public void Xoa(string maSV)
    {
        if (string.IsNullOrWhiteSpace(maSV)) throw new Exception("Hãy chọn sinh viên cần xóa.");
        dao.Xoa(maSV.Trim().ToUpper());
    }
}
