namespace QuanLySinhVien;

public partial class Main : Form
{
    private readonly SinhVienBUS sinhVienBUS = new();
    private readonly LopHocBUS lopHocBUS = new();

    public Main() => InitializeComponent();

    private void BaoLoi(Exception ex) => MessageBox.Show(ex.Message, "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);

    private void Main_Load(object? sender, EventArgs e)
    {
        try { NapLop(); NapSinhVien(); }
        catch (Exception ex) { BaoLoi(ex); }
    }

    private void NapLop()
    {
        var dsLop = lopHocBUS.LayDanhSach();
        cboLop.DataSource = null;
        cboLop.DisplayMember = nameof(LopHoc.TenLop);
        cboLop.ValueMember = nameof(LopHoc.MaLop);
        cboLop.DataSource = dsLop;

        var dsLoc = new List<LopHoc> { new() { MaLop = "", TenLop = "Tất cả lớp" } };
        dsLoc.AddRange(dsLop);
        cboLocLop.DataSource = null;
        cboLocLop.DisplayMember = nameof(LopHoc.TenLop);
        cboLocLop.ValueMember = nameof(LopHoc.MaLop);
        cboLocLop.DataSource = dsLoc;
    }

    private void NapSinhVien()
    {
        var ds = sinhVienBUS.TimKiem(txtTuKhoa.Text, cboLocLop.SelectedValue?.ToString() ?? "", numDiemTu.Value);
        grid.DataSource = null;
        grid.DataSource = ds;
        grid.ClearSelection();
        lblTong.Text = $"Tổng số: {ds.Count} sinh viên";
    }

    private SinhVien LayThongTin() => new()
    {
        MaSV = txtMaSV.Text,
        HoTen = txtHoTen.Text,
        NgaySinh = dtNgaySinh.Value.Date,
        GioiTinh = radNam.Checked ? "Nam" : "Nữ",
        Email = txtEmail.Text,
        DienThoai = txtDienThoai.Text,
        Diem = numDiem.Value,
        MaLop = cboLop.SelectedValue?.ToString() ?? "",
        TrangThai = cboTrangThai.Text
    };

    private void LamMoi()
    {
        txtMaSV.Clear(); txtHoTen.Clear(); txtEmail.Clear(); txtDienThoai.Clear();
        dtNgaySinh.Value = DateTime.Today; radNam.Checked = true; numDiem.Value = 8;
        if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
        cboTrangThai.SelectedIndex = 0;
        grid.ClearSelection(); txtMaSV.Focus();
    }

    private void btnThem_Click(object? sender, EventArgs e)
    {
        try
        {
            sinhVienBUS.Them(LayThongTin());
            NapSinhVien(); LamMoi();
            MessageBox.Show("Đã thêm sinh viên.");
        }
        catch (Exception ex) { BaoLoi(ex); }
    }

    private void btnSua_Click(object? sender, EventArgs e)
    {
        try
        {
            sinhVienBUS.Sua(LayThongTin());
            NapSinhVien();
            MessageBox.Show("Đã cập nhật sinh viên.");
        }
        catch (Exception ex) { BaoLoi(ex); }
    }

    private void btnXoa_Click(object? sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text)) throw new Exception("Hãy chọn sinh viên cần xóa.");
            if (MessageBox.Show("Xóa sinh viên " + txtMaSV.Text + "?", "Xác nhận", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes) return;
            sinhVienBUS.Xoa(txtMaSV.Text);
            NapSinhVien(); LamMoi();
            MessageBox.Show("Đã xóa sinh viên.");
        }
        catch (Exception ex) { BaoLoi(ex); }
    }

    private void btnLamMoi_Click(object? sender, EventArgs e) => LamMoi();

    private void btnTim_Click(object? sender, EventArgs e)
    {
        try { NapSinhVien(); }
        catch (Exception ex) { BaoLoi(ex); }
    }

    private void btnTatCa_Click(object? sender, EventArgs e)
    {
        try
        {
            txtTuKhoa.Clear(); cboLocLop.SelectedIndex = 0; numDiemTu.Value = 0;
            NapSinhVien();
        }
        catch (Exception ex) { BaoLoi(ex); }
    }

    private void grid_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || grid.Rows[e.RowIndex].DataBoundItem is not SinhVien sv) return;
        txtMaSV.Text = sv.MaSV; txtHoTen.Text = sv.HoTen; dtNgaySinh.Value = sv.NgaySinh;
        radNam.Checked = sv.GioiTinh == "Nam"; radNu.Checked = sv.GioiTinh == "Nữ";
        txtEmail.Text = sv.Email; txtDienThoai.Text = sv.DienThoai; numDiem.Value = sv.Diem;
        cboLop.SelectedValue = sv.MaLop; cboTrangThai.SelectedItem = sv.TrangThai;
    }

    private void btnLop_Click(object? sender, EventArgs e)
    {
        try
        {
            using var form = new FormLopHoc();
            form.ShowDialog(this);
            NapLop(); NapSinhVien();
        }
        catch (Exception ex) { BaoLoi(ex); }
    }

    private void lblHeader_Click(object sender, EventArgs e)
    {

    }
}
