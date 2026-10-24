# Quản lý sinh viên - tuần 6

Bài này thêm EF Core Code First cho hai lớp `LopHoc` và `SinhVien` trong `Models.cs`. Phần cấu hình bảng và quan hệ giữa lớp, sinh viên nằm ở `QLSVContext.cs`. Migration đầu tiên nằm trong thư mục `Migrations`.

## Chạy chương trình

1. Bật MySQL trong DBngin (127.0.0.1:3306, tài khoản root, mật khẩu trống).
2. Mở `QuanLySinhVien.slnx` bằng Visual Studio rồi chạy. Lần đầu chương trình sẽ tạo database `quan_ly_sinh_vien_w6` và thêm vài dòng dữ liệu mẫu.

Giao diện thêm, sửa, xóa và tìm kiếm vẫn dùng các lớp DAO của bài trước. `database.sql` là file của tuần 5, không cần chạy khi dùng database tuần 6.
