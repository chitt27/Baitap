namespace QuanLySinhVien;

public partial class FormLopHoc : Form
{
    private readonly LopHocBUS bus = new();

    public FormLopHoc() => InitializeComponent();

    private LopHoc LayThongTin() => new() { MaLop = txtMa.Text, TenLop = txtTen.Text };
    private void Nap()
    {
        grid.DataSource = null;
        grid.DataSource = bus.LayDanhSach();
        grid.ClearSelection();
    }
    private void LamMoi()
    {
        txtMa.Clear(); txtTen.Clear(); grid.ClearSelection(); txtMa.Focus();
    }
    private static void Chay(Action action)
    {
        try { action(); }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void FormLopHoc_Load(object? sender, EventArgs e) => Chay(Nap);
    private void btnThem_Click(object? sender, EventArgs e) => Chay(() => { bus.Them(LayThongTin()); Nap(); LamMoi(); });
    private void btnSua_Click(object? sender, EventArgs e) => Chay(() => { bus.Sua(LayThongTin()); Nap(); });
    private void btnXoa_Click(object? sender, EventArgs e) => Chay(() =>
    {
        if (MessageBox.Show("Xóa lớp " + txtMa.Text + "?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
        bus.Xoa(txtMa.Text); Nap(); LamMoi();
    });
    private void btnMoi_Click(object? sender, EventArgs e) => LamMoi();
    private void grid_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && grid.Rows[e.RowIndex].DataBoundItem is LopHoc lop)
        { txtMa.Text = lop.MaLop; txtTen.Text = lop.TenLop; }
    }
}
