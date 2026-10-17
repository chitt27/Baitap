#nullable disable
using System.Drawing;

namespace QuanLySinhVien;

partial class Main
{
    private System.ComponentModel.IContainer components = null;
    private Panel header;
    private Label lblHeader;
    private Label lblFooter;
    private GroupBox grpInfo;
    private GroupBox grpSearch;
    private GroupBox grpList;
    private Label lblMa;
    private Label lblHoTen;
    private Label lblLop;
    private Label lblNgaySinh;
    private Label lblGioiTinh;
    private Label lblDiem;
    private Label lblEmail;
    private Label lblDienThoai;
    private Label lblTrangThai;
    private Label lblTuKhoa;
    private Label lblLocLop;
    private Label lblDiemTu;
    private Label lblTong;
    private TextBox txtMaSV;
    private TextBox txtHoTen;
    private TextBox txtEmail;
    private TextBox txtDienThoai;
    private TextBox txtTuKhoa;
    private ComboBox cboLop;
    private ComboBox cboTrangThai;
    private ComboBox cboLocLop;
    private DateTimePicker dtNgaySinh;
    private RadioButton radNam;
    private RadioButton radNu;
    private NumericUpDown numDiem;
    private NumericUpDown numDiemTu;
    private Button btnThem;
    private Button btnSua;
    private Button btnXoa;
    private Button btnLamMoi;
    private Button btnTim;
    private Button btnTatCa;
    private Button btnLop;
    private DataGridView grid;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        header = new Panel();
        this.lblHeader = new Label();
        btnLop = new Button();
        grpInfo = new GroupBox();
        lblMa = new Label();
        lblHoTen = new Label();
        lblLop = new Label();
        lblNgaySinh = new Label();
        lblGioiTinh = new Label();
        lblDiem = new Label();
        lblEmail = new Label();
        lblDienThoai = new Label();
        lblTrangThai = new Label();
        txtMaSV = new TextBox();
        txtHoTen = new TextBox();
        cboLop = new ComboBox();
        dtNgaySinh = new DateTimePicker();
        radNam = new RadioButton();
        radNu = new RadioButton();
        numDiem = new NumericUpDown();
        txtEmail = new TextBox();
        txtDienThoai = new TextBox();
        cboTrangThai = new ComboBox();
        btnThem = new Button();
        btnSua = new Button();
        btnXoa = new Button();
        btnLamMoi = new Button();
        grpSearch = new GroupBox();
        lblTuKhoa = new Label();
        lblLocLop = new Label();
        lblDiemTu = new Label();
        txtTuKhoa = new TextBox();
        cboLocLop = new ComboBox();
        numDiemTu = new NumericUpDown();
        btnTim = new Button();
        btnTatCa = new Button();
        grpList = new GroupBox();
        lblTong = new Label();
        grid = new DataGridView();
        this.lblFooter = new Label();
        header.SuspendLayout();
        grpInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numDiem).BeginInit();
        grpSearch.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numDiemTu).BeginInit();
        grpList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
        SuspendLayout();
        // 
        // header
        // 
        header.BackColor = Color.FromArgb(28, 68, 103);
        header.Controls.Add(this.lblHeader);
        header.Controls.Add(btnLop);
        header.Location = new Point(0, 0);
        header.Name = "header";
        header.Size = new Size(1110, 47);
        header.TabIndex = 0;
        // 
        // lblHeader
        // 
        this.lblHeader.AutoSize = true;
        this.lblHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        this.lblHeader.ForeColor = Color.White;
        this.lblHeader.Location = new Point(20, 10);
        this.lblHeader.Name = "lblHeader";
        this.lblHeader.Size = new Size(321, 28);
        this.lblHeader.TabIndex = 0;
        this.lblHeader.Text = "ỨNG DỤNG QUẢN LÝ SINH VIÊN";
        this.lblHeader.Click += this.lblHeader_Click;
        // 
        // btnLop
        // 
        btnLop.BackColor = Color.FromArgb(46, 102, 144);
        btnLop.FlatStyle = FlatStyle.Flat;
        btnLop.ForeColor = Color.White;
        btnLop.Location = new Point(940, 8);
        btnLop.Name = "btnLop";
        btnLop.Size = new Size(150, 31);
        btnLop.TabIndex = 1;
        btnLop.Text = "Quản lý lớp học";
        btnLop.UseVisualStyleBackColor = false;
        btnLop.Click += btnLop_Click;
        // 
        // grpInfo
        // 
        grpInfo.Controls.Add(lblMa);
        grpInfo.Controls.Add(lblHoTen);
        grpInfo.Controls.Add(lblLop);
        grpInfo.Controls.Add(lblNgaySinh);
        grpInfo.Controls.Add(lblGioiTinh);
        grpInfo.Controls.Add(lblDiem);
        grpInfo.Controls.Add(lblEmail);
        grpInfo.Controls.Add(lblDienThoai);
        grpInfo.Controls.Add(lblTrangThai);
        grpInfo.Controls.Add(txtMaSV);
        grpInfo.Controls.Add(txtHoTen);
        grpInfo.Controls.Add(cboLop);
        grpInfo.Controls.Add(dtNgaySinh);
        grpInfo.Controls.Add(radNam);
        grpInfo.Controls.Add(radNu);
        grpInfo.Controls.Add(numDiem);
        grpInfo.Controls.Add(txtEmail);
        grpInfo.Controls.Add(txtDienThoai);
        grpInfo.Controls.Add(cboTrangThai);
        grpInfo.Controls.Add(btnThem);
        grpInfo.Controls.Add(btnSua);
        grpInfo.Controls.Add(btnXoa);
        grpInfo.Controls.Add(btnLamMoi);
        grpInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpInfo.ForeColor = Color.FromArgb(31, 68, 93);
        grpInfo.Location = new Point(20, 67);
        grpInfo.Name = "grpInfo";
        grpInfo.Size = new Size(1070, 211);
        grpInfo.TabIndex = 2;
        grpInfo.TabStop = false;
        grpInfo.Text = "Thông tin sinh viên";
        // 
        // lblMa
        // 
        lblMa.Location = new Point(10, 34);
        lblMa.Name = "lblMa";
        lblMa.Size = new Size(100, 25);
        lblMa.TabIndex = 0;
        lblMa.Text = "Mã sinh viên *";
        lblMa.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblHoTen
        // 
        lblHoTen.Location = new Point(350, 34);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new Size(100, 25);
        lblHoTen.TabIndex = 1;
        lblHoTen.Text = "Họ và tên *";
        lblHoTen.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblLop
        // 
        lblLop.Location = new Point(700, 34);
        lblLop.Name = "lblLop";
        lblLop.Size = new Size(100, 25);
        lblLop.TabIndex = 2;
        lblLop.Text = "Lớp học *";
        lblLop.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblNgaySinh
        // 
        lblNgaySinh.Location = new Point(10, 75);
        lblNgaySinh.Name = "lblNgaySinh";
        lblNgaySinh.Size = new Size(100, 25);
        lblNgaySinh.TabIndex = 3;
        lblNgaySinh.Text = "Ngày sinh";
        lblNgaySinh.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblGioiTinh
        // 
        lblGioiTinh.Location = new Point(350, 75);
        lblGioiTinh.Name = "lblGioiTinh";
        lblGioiTinh.Size = new Size(100, 25);
        lblGioiTinh.TabIndex = 4;
        lblGioiTinh.Text = "Giới tính";
        lblGioiTinh.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblDiem
        // 
        lblDiem.Location = new Point(700, 75);
        lblDiem.Name = "lblDiem";
        lblDiem.Size = new Size(100, 25);
        lblDiem.TabIndex = 5;
        lblDiem.Text = "Điểm";
        lblDiem.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblEmail
        // 
        lblEmail.Location = new Point(10, 116);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(100, 25);
        lblEmail.TabIndex = 6;
        lblEmail.Text = "Email *";
        lblEmail.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblDienThoai
        // 
        lblDienThoai.Location = new Point(350, 116);
        lblDienThoai.Name = "lblDienThoai";
        lblDienThoai.Size = new Size(100, 25);
        lblDienThoai.TabIndex = 7;
        lblDienThoai.Text = "Điện thoại *";
        lblDienThoai.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblTrangThai
        // 
        lblTrangThai.Location = new Point(700, 116);
        lblTrangThai.Name = "lblTrangThai";
        lblTrangThai.Size = new Size(100, 25);
        lblTrangThai.TabIndex = 8;
        lblTrangThai.Text = "Trạng thái";
        lblTrangThai.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtMaSV
        // 
        txtMaSV.Location = new Point(120, 34);
        txtMaSV.Name = "txtMaSV";
        txtMaSV.Size = new Size(190, 27);
        txtMaSV.TabIndex = 9;
        // 
        // txtHoTen
        // 
        txtHoTen.Location = new Point(460, 34);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new Size(190, 27);
        txtHoTen.TabIndex = 10;
        // 
        // cboLop
        // 
        cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLop.Location = new Point(810, 34);
        cboLop.Name = "cboLop";
        cboLop.Size = new Size(230, 28);
        cboLop.TabIndex = 11;
        // 
        // dtNgaySinh
        // 
        dtNgaySinh.Format = DateTimePickerFormat.Short;
        dtNgaySinh.Location = new Point(120, 75);
        dtNgaySinh.Name = "dtNgaySinh";
        dtNgaySinh.Size = new Size(190, 27);
        dtNgaySinh.TabIndex = 12;
        // 
        // radNam
        // 
        radNam.Checked = true;
        radNam.Location = new Point(460, 77);
        radNam.Name = "radNam";
        radNam.Size = new Size(75, 25);
        radNam.TabIndex = 13;
        radNam.TabStop = true;
        radNam.Text = "Nam";
        // 
        // radNu
        // 
        radNu.Location = new Point(550, 77);
        radNu.Name = "radNu";
        radNu.Size = new Size(70, 25);
        radNu.TabIndex = 14;
        radNu.Text = "Nữ";
        // 
        // numDiem
        // 
        numDiem.DecimalPlaces = 1;
        numDiem.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
        numDiem.Location = new Point(810, 75);
        numDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
        numDiem.Name = "numDiem";
        numDiem.Size = new Size(230, 27);
        numDiem.TabIndex = 15;
        numDiem.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(120, 116);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(190, 27);
        txtEmail.TabIndex = 16;
        // 
        // txtDienThoai
        // 
        txtDienThoai.Location = new Point(460, 116);
        txtDienThoai.Name = "txtDienThoai";
        txtDienThoai.Size = new Size(190, 27);
        txtDienThoai.TabIndex = 17;
        // 
        // cboTrangThai
        // 
        cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTrangThai.Items.AddRange(new object[] { "Đang học", "Bảo lưu", "Đã tốt nghiệp" });
        cboTrangThai.Location = new Point(810, 116);
        cboTrangThai.Name = "cboTrangThai";
        cboTrangThai.Size = new Size(230, 28);
        cboTrangThai.TabIndex = 18;
        // 
        // btnThem
        // 
        btnThem.BackColor = Color.FromArgb(37, 132, 95);
        btnThem.FlatStyle = FlatStyle.Flat;
        btnThem.ForeColor = Color.White;
        btnThem.Location = new Point(610, 162);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(98, 31);
        btnThem.TabIndex = 19;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = false;
        btnThem.Click += btnThem_Click;
        // 
        // btnSua
        // 
        btnSua.BackColor = Color.FromArgb(44, 112, 165);
        btnSua.FlatStyle = FlatStyle.Flat;
        btnSua.ForeColor = Color.White;
        btnSua.Location = new Point(718, 162);
        btnSua.Name = "btnSua";
        btnSua.Size = new Size(98, 31);
        btnSua.TabIndex = 20;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = false;
        btnSua.Click += btnSua_Click;
        // 
        // btnXoa
        // 
        btnXoa.BackColor = Color.FromArgb(184, 73, 81);
        btnXoa.FlatStyle = FlatStyle.Flat;
        btnXoa.ForeColor = Color.White;
        btnXoa.Location = new Point(826, 162);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(98, 31);
        btnXoa.TabIndex = 21;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = false;
        btnXoa.Click += btnXoa_Click;
        // 
        // btnLamMoi
        // 
        btnLamMoi.BackColor = Color.FromArgb(104, 117, 130);
        btnLamMoi.FlatStyle = FlatStyle.Flat;
        btnLamMoi.ForeColor = Color.White;
        btnLamMoi.Location = new Point(934, 162);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new Size(106, 31);
        btnLamMoi.TabIndex = 22;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = false;
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // grpSearch
        // 
        grpSearch.Controls.Add(lblTuKhoa);
        grpSearch.Controls.Add(lblLocLop);
        grpSearch.Controls.Add(lblDiemTu);
        grpSearch.Controls.Add(txtTuKhoa);
        grpSearch.Controls.Add(cboLocLop);
        grpSearch.Controls.Add(numDiemTu);
        grpSearch.Controls.Add(btnTim);
        grpSearch.Controls.Add(btnTatCa);
        grpSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpSearch.ForeColor = Color.FromArgb(31, 68, 93);
        grpSearch.Location = new Point(20, 299);
        grpSearch.Name = "grpSearch";
        grpSearch.Size = new Size(1070, 80);
        grpSearch.TabIndex = 3;
        grpSearch.TabStop = false;
        grpSearch.Text = "Tìm kiếm và lọc";
        // 
        // lblTuKhoa
        // 
        lblTuKhoa.Location = new Point(8, 31);
        lblTuKhoa.Name = "lblTuKhoa";
        lblTuKhoa.Size = new Size(62, 25);
        lblTuKhoa.TabIndex = 0;
        lblTuKhoa.Text = "Từ khóa";
        lblTuKhoa.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblLocLop
        // 
        lblLocLop.Location = new Point(338, 31);
        lblLocLop.Name = "lblLocLop";
        lblLocLop.Size = new Size(52, 25);
        lblLocLop.TabIndex = 1;
        lblLocLop.Text = "Lớp";
        lblLocLop.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblDiemTu
        // 
        lblDiemTu.Location = new Point(595, 31);
        lblDiemTu.Name = "lblDiemTu";
        lblDiemTu.Size = new Size(62, 25);
        lblDiemTu.TabIndex = 2;
        lblDiemTu.Text = "Điểm từ";
        lblDiemTu.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtTuKhoa
        // 
        txtTuKhoa.Location = new Point(78, 31);
        txtTuKhoa.Name = "txtTuKhoa";
        txtTuKhoa.Size = new Size(250, 27);
        txtTuKhoa.TabIndex = 3;
        // 
        // cboLocLop
        // 
        cboLocLop.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLocLop.Location = new Point(400, 31);
        cboLocLop.Name = "cboLocLop";
        cboLocLop.Size = new Size(190, 28);
        cboLocLop.TabIndex = 4;
        // 
        // numDiemTu
        // 
        numDiemTu.DecimalPlaces = 1;
        numDiemTu.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
        numDiemTu.Location = new Point(667, 31);
        numDiemTu.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
        numDiemTu.Name = "numDiemTu";
        numDiemTu.Size = new Size(75, 27);
        numDiemTu.TabIndex = 5;
        // 
        // btnTim
        // 
        btnTim.BackColor = Color.FromArgb(44, 112, 165);
        btnTim.FlatStyle = FlatStyle.Flat;
        btnTim.ForeColor = Color.White;
        btnTim.Location = new Point(758, 28);
        btnTim.Name = "btnTim";
        btnTim.Size = new Size(120, 31);
        btnTim.TabIndex = 6;
        btnTim.Text = "Tìm kiếm";
        btnTim.UseVisualStyleBackColor = false;
        btnTim.Click += btnTim_Click;
        // 
        // btnTatCa
        // 
        btnTatCa.BackColor = Color.FromArgb(104, 117, 130);
        btnTatCa.FlatStyle = FlatStyle.Flat;
        btnTatCa.ForeColor = Color.White;
        btnTatCa.Location = new Point(890, 28);
        btnTatCa.Name = "btnTatCa";
        btnTatCa.Size = new Size(150, 31);
        btnTatCa.TabIndex = 7;
        btnTatCa.Text = "Hiển thị tất cả";
        btnTatCa.UseVisualStyleBackColor = false;
        btnTatCa.Click += btnTatCa_Click;
        // 
        // grpList
        // 
        grpList.Controls.Add(lblTong);
        grpList.Controls.Add(grid);
        grpList.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpList.ForeColor = Color.FromArgb(31, 68, 93);
        grpList.Location = new Point(20, 397);
        grpList.Name = "grpList";
        grpList.Size = new Size(1070, 267);
        grpList.TabIndex = 4;
        grpList.TabStop = false;
        grpList.Text = "Danh sách sinh viên";
        // 
        // lblTong
        // 
        lblTong.Location = new Point(880, 1);
        lblTong.Name = "lblTong";
        lblTong.Size = new Size(170, 24);
        lblTong.TabIndex = 0;
        lblTong.Text = "Tổng số: 0 sinh viên";
        lblTong.TextAlign = ContentAlignment.MiddleRight;
        // 
        // grid
        // 
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.BackgroundColor = Color.White;
        grid.ColumnHeadersHeight = 29;
        grid.Location = new Point(12, 28);
        grid.MultiSelect = false;
        grid.Name = "grid";
        grid.ReadOnly = true;
        grid.RowHeadersVisible = false;
        grid.RowHeadersWidth = 51;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.Size = new Size(1046, 225);
        grid.TabIndex = 1;
        grid.CellClick += grid_CellClick;
        // 
        // lblFooter
        // 
        this.lblFooter.AutoSize = true;
        this.lblFooter.ForeColor = Color.DimGray;
        this.lblFooter.Location = new Point(25, 680);
        this.lblFooter.Name = "lblFooter";
        this.lblFooter.Size = new Size(388, 20);
        this.lblFooter.TabIndex = 5;
        this.lblFooter.Text = "Chọn một dòng để xem, sửa hoặc xóa thông tin sinh viên.";
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(1110, 710);
        Controls.Add(header);
        Controls.Add(grpInfo);
        Controls.Add(grpSearch);
        Controls.Add(grpList);
        Controls.Add(this.lblFooter);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Main";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Quản lý sinh viên";
        Load += Main_Load;
        header.ResumeLayout(false);
        header.PerformLayout();
        grpInfo.ResumeLayout(false);
        grpInfo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numDiem).EndInit();
        grpSearch.ResumeLayout(false);
        grpSearch.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numDiemTu).EndInit();
        grpList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)grid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}

