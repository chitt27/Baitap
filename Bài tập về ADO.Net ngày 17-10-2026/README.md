# Quản lý sinh viên - Bài tập ADO.NET

Ứng dụng Windows Forms (.NET 8) quản lý sinh viên theo lớp, dùng ADO.NET với MySQL. Giao diện có thêm, sửa, xóa, tìm theo mã/tên/email/điện thoại, lọc theo lớp và điểm tối thiểu. Có cửa sổ quản lý lớp học riêng.

## Chạy chương trình

1. Start MySQL trong DBngin tại `127.0.0.1:3306` với tài khoản `root`, mật khẩu để trống.
2. Chạy `database.sql` để tạo cơ sở dữ liệu và dữ liệu mẫu. Script không xóa dữ liệu đã có.
3. Nếu cấu hình MySQL khác, đổi `ConnectionString` trong `Database.cs`.
4. Mở `QuanLySinhVien.slnx`, Restore NuGet packages, rồi chạy project.

Project dùng `MySqlConnector` để thực hiện câu lệnh SQL có tham số. DAO truy cập dữ liệu và ném ngoại lệ, BUS kiểm tra thông tin và ném ngoại lệ, Form bắt ngoại lệ để thông báo cho người dùng.
