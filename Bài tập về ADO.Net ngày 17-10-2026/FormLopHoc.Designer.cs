#nullable disable
using System.Drawing;

namespace QuanLySinhVien;

partial class FormLopHoc
{
    private System.ComponentModel.IContainer components = null;
    private Label lblMa, lblTen;
    private TextBox txtMa, txtTen;
    private Button btnThem, btnSua, btnXoa, btnMoi;
    private DataGridView grid;
    private DataGridViewTextBoxColumn colMa, colTen;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblMa = new Label(); lblTen = new Label();
        txtMa = new TextBox(); txtTen = new TextBox();
        btnThem = new Button(); btnSua = new Button(); btnXoa = new Button(); btnMoi = new Button();
        grid = new DataGridView(); colMa = new DataGridViewTextBoxColumn(); colTen = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
        SuspendLayout();

        lblMa.AutoSize = true; lblMa.Location = new Point(20, 29); lblMa.Name = "lblMa"; lblMa.Text = "Mã lớp";
        lblTen.AutoSize = true; lblTen.Location = new Point(280, 29); lblTen.Name = "lblTen"; lblTen.Text = "Tên lớp";
        txtMa.Location = new Point(105, 26); txtMa.Name = "txtMa"; txtMa.Size = new Size(145, 27);
        txtTen.Location = new Point(350, 26); txtTen.Name = "txtTen"; txtTen.Size = new Size(225, 27);
        btnThem.Location = new Point(65, 72); btnThem.Name = "btnThem"; btnThem.Size = new Size(95, 31);
        btnThem.Text = "Thêm"; btnThem.BackColor = Color.FromArgb(44, 112, 165); btnThem.ForeColor = Color.White;
        btnThem.FlatStyle = FlatStyle.Flat; btnThem.Click += btnThem_Click;
        btnSua.Location = new Point(185, 72); btnSua.Name = "btnSua"; btnSua.Size = new Size(95, 31);
        btnSua.Text = "Sửa"; btnSua.BackColor = Color.FromArgb(44, 112, 165); btnSua.ForeColor = Color.White;
        btnSua.FlatStyle = FlatStyle.Flat; btnSua.Click += btnSua_Click;
        btnXoa.Location = new Point(305, 72); btnXoa.Name = "btnXoa"; btnXoa.Size = new Size(95, 31);
        btnXoa.Text = "Xóa"; btnXoa.BackColor = Color.FromArgb(44, 112, 165); btnXoa.ForeColor = Color.White;
        btnXoa.FlatStyle = FlatStyle.Flat; btnXoa.Click += btnXoa_Click;
        btnMoi.Location = new Point(425, 72); btnMoi.Name = "btnMoi"; btnMoi.Size = new Size(95, 31);
        btnMoi.Text = "Làm mới"; btnMoi.BackColor = Color.FromArgb(44, 112, 165); btnMoi.ForeColor = Color.White;
        btnMoi.FlatStyle = FlatStyle.Flat; btnMoi.Click += btnMoi_Click;

        grid.AllowUserToAddRows = false; grid.AllowUserToDeleteRows = false; grid.AutoGenerateColumns = false;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.Location = new Point(20, 118); grid.Name = "grid"; grid.ReadOnly = true;
        grid.MultiSelect = false; grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.Size = new Size(555, 258); grid.Columns.AddRange(new DataGridViewColumn[] { colMa, colTen });
        grid.CellClick += grid_CellClick;
        colMa.DataPropertyName = "MaLop"; colMa.HeaderText = "Mã lớp"; colMa.Name = "colMa"; colMa.FillWeight = 40;
        colTen.DataPropertyName = "TenLop"; colTen.HeaderText = "Tên lớp"; colTen.Name = "colTen"; colTen.FillWeight = 60;

        AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(595, 398);
        Controls.Add(lblMa); Controls.Add(lblTen); Controls.Add(txtMa); Controls.Add(txtTen);
        Controls.Add(btnThem); Controls.Add(btnSua); Controls.Add(btnXoa); Controls.Add(btnMoi); Controls.Add(grid);
        Font = new Font("Segoe UI", 9F); FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false; Name = "FormLopHoc"; StartPosition = FormStartPosition.CenterParent;
        Text = "Quản lý lớp học"; Load += FormLopHoc_Load;
        ((System.ComponentModel.ISupportInitialize)grid).EndInit();
        ResumeLayout(false); PerformLayout();
    }
}
