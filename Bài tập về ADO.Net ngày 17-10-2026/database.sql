-- Chạy file này trong DBngin / MySQL để tạo database và dữ liệu mẫu.
CREATE DATABASE IF NOT EXISTS quan_ly_sinh_vien CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE quan_ly_sinh_vien;

CREATE TABLE IF NOT EXISTS LopHoc (
    MaLop varchar(20) NOT NULL PRIMARY KEY,
    TenLop varchar(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS SinhVien (
    MaSV varchar(20) NOT NULL PRIMARY KEY,
    HoTen varchar(100) NOT NULL,
    NgaySinh date NOT NULL,
    GioiTinh varchar(10) NOT NULL,
    Email varchar(100) NOT NULL,
    DienThoai varchar(20) NOT NULL,
    Diem decimal(4,1) NOT NULL,
    MaLop varchar(20) NOT NULL,
    TrangThai varchar(30) NOT NULL,
    FOREIGN KEY (MaLop) REFERENCES LopHoc(MaLop)
);

INSERT IGNORE INTO LopHoc VALUES
('KTPM01','Kỹ thuật phần mềm 01'),
('CNTT01','Công nghệ thông tin 01'),
('KHMT01','Khoa học máy tính 01');

INSERT IGNORE INTO SinhVien VALUES
('SV001','Nguyễn Văn An','2005-08-15','Nam','an.nv@vju.ac.vn','0912345678',8.5,'KTPM01','Đang học'),
('SV002','Trần Minh Anh','2005-01-22','Nữ','anh.tm@vju.ac.vn','0987654321',9.0,'CNTT01','Đang học');
