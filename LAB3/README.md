

## THÔNG TIN CÁ NHÂN
- Họ và tên: Nguyễn Thị Diễm Huỳnh
- Mã số sinh viên: 1250080077
- Tên bài Lab: LAB 3 - Xây dựng Hệ thống Quản lý Khách sạn theo mô hình 3 lớp
- Môn học: Phân tích & Thiết kế Hệ thống Hướng đối tượng (OOSD)

## MÔI TRƯỜNG VÀ PHIÊN BẢN (ENVIRONMENT & VERSIONS)
- Hệ điều hành: Windows 11
- Môi trường phát triển (IDE): Microsoft Visual Studio 2022
- Framework: .NET 6.0 / Windows Forms
- Quản lý cơ sở dữ liệu: Microsoft SQL Server 2019 / SSMS
- Thư viện kết nối CSDL: Microsoft.Data.SqlClient (Version 5.x)
- Quản lý phiên bản: Git & GitHub Web Interface

## NỘI DUNG ĐÃ THỰC HIỆN
1. Tổ chức cấu trúc dự án đúng chuẩn kiến trúc 3 lớp (3-Tier Architecture):
   - Data Layer: Xây dựng Data/Db.cs chứa các helper Query, Execute, Scalar bằng ADO.NET.
   - Services Layer: Tạo các service xử lý nghiệp vụ độc lập (DanhMucService, PhongTienNghiService, DatPhongService, DichVuService, TraPhongService, ThongKeService).
   - Presentation Layer: Xây dựng và phân chia toàn bộ các giao diện người dùng vào thư mục Forms/ (FrmMain, FrmDanhMuc, FrmPhongTienNghi, FrmDatPhong, FrmDichVu, FrmTraPhong, FrmThongKe).
2. Xây dựng CSDL SQL Server với tên QuanLyKhachSan, cấu trúc các bảng dữ liệu và thiết lập các khóa ngoại liên kết.
3. Lập trình xử lý nghiệp vụ cho các chức năng: Quản lý phòng & dịch vụ, tiếp nhận đặt phòng, ghi nhận dịch vụ phát sinh, tính hóa đơn trả phòng và thống kê báo cáo doanh thu.
4. Xử lý an toàn tiến trình ứng dụng (Process Management) và bẫy lỗi ngoại lệ kết nối SQL.

## KẾT QUẢ ĐẠT ĐƯỢC
- Chương trình biên dịch thành công 100%, không phát sinh lỗi (Build Succeeded / 0 Errors).
- Cấu trúc thư mục mã nguồn đáp ứng chính xác theo đúng khung yêu cầu của đề bài.
- Giao diện người dùng phản hồi mượt mà, tính toán chính xác tổng tiền phòng, tiền dịch vụ và hiển thị thống kê tổng quan.
- Đã hoàn thiện file báo cáo Word (NguyenThiDiemHuynh_1250080077_Lab3.docx) chứa đầy đủ ảnh chụp giao diện và CSDL thực tế chạy trên máy cá nhân.

## LỖI GẶP PHẢI VÀ CÁCH KHẮC PHỤC

1. Lỗi xung đột tiến trình "Unable to copy file / Locked process" khi Compile:
   - Nguyên nhân: Ứng dụng WinForms chưa giải phóng hết tiến trình chạy ngầm trong bộ nhớ khi đóng giao diện.
   - Khắc phục: Đăng ký sự kiện AppDomain.CurrentDomain.ProcessExit trong file Program.cs để cưỡng chế dừng tiến trình ứng dụng khi đóng.

2. Lỗi cú pháp "Incorrect syntax near 1." khi chạy Script SQL tạo bảng ChiTietDichVu:
   - Nguyên nhân: Bôi đen nhầm số thứ tự ghi chú văn bản khi thực thi câu lệnh SQL trong SSMS.
   - Khắc phục: Tách riêng câu lệnh CREATE TABLE ngắn gọn và thực thi độc lập.

3. Lỗi "Invalid column name" khi truy vấn dữ liệu ở Form Thống kê:
   - Nguyên nhân: Tên các cột trong bảng CSDL thực tế khác biệt so với câu lệnh SQL truy vấn.
   - Khắc phục: Bổ sung phương thức kiểm tra sự tồn tại của bảng/cột và tối ưu hóa việc đổ dữ liệu an toàn trên DataTable để tránh ngắt đột ngột chương trình.

4. Lỗi "Yowza, that's a lot of files" khi upload lên GitHub:
   - Nguyên nhân: Kéo thả trực tiếp cả 2 thư mục bin/ và obj/ chứa quá nhiều file DLL biên dịch trung gian vượt quá giới hạn 100 file của giao diện web GitHub.
   - Khắc phục: Xóa bỏ các thư mục rác bin/ và obj/ trước khi commit, chỉ đẩy các file mã nguồn chính (.cs, .csproj, .sln, .sql, .md, .docx).

## HƯỚNG DẪN KIỂM TRA VÀ CHẠY LẠI CHƯƠNG TRÌNH (FOR INSTRUCTOR)

1. Khôi phục Cơ sở dữ liệu:
   - Mở Microsoft SQL Server Management Studio (SSMS).
   - Mở và thực thi file databaseQLKS.sql nằm trong thư mục dự án để tạo CSDL QuanLyKhachSan.

2. Cấu hình chuỗi kết nối:
   - Mở file Data/Db.cs trong Visual Studio.
   - Thay đổi thông số Data Source trong chuỗi connectionString cho tương thích với Server Name SQL Server trên máy kiểm tra:
     string connectionString = @"Data Source=.;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True";

3. Thao tác Build & Run:
   - Mở file QuanLyKhachSan.sln bằng Visual Studio.
   - Nhấn Ctrl + Shift + B để Rebuild Solution.
   - Nhấn phím F5 để khởi chạy ứng dụng (Màn hình chính FrmMain sẽ xuất hiện).
