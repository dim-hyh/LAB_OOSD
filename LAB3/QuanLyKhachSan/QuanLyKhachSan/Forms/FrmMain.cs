using QuanLyKhachSan;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    // Lớp partial để định nghĩa code logic, kết nối với phần thiết kế
    public partial class FrmMain : Form
    {
        // Hàm khởi tạo nạp giao diện Form
        public FrmMain()
        {
            // Lệnh bắt buộc để khởi tạo các control trên Form
            InitializeComponent();
        }

        // --- Sự kiện cho các nút bấm ---

        // Mở Form Danh Mục
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            using (var form = new FrmDanhMuc())
            {
                form.ShowDialog(this);
            }
        }

        // Mở Form Phòng - Tiện Nghi
        private void btnPhong_Click(object sender, EventArgs e)
        {
            using (var form = new FrmPhongTienNghi())
            {
                form.ShowDialog(this);
            }
        }

        // Mở Form Đặt / Nhận phòng
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            using (var form = new FrmDatPhong())
            {
                form.ShowDialog(this);
            }
        }

        // Mở Form Sử dụng dịch vụ
        private void btnDichVu_Click(object sender, EventArgs e)
        {
            using (var form = new FrmDichVu())
            {
                form.ShowDialog(this);
            }
        }

        // Mở Form Trả phòng - Thanh toán
        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            using (var form = new FrmTraPhong())
            {
                form.ShowDialog(this);
            }
        }

        // Mở Form Thống Kê
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using (var form = new FrmThongKe())
            {
                form.ShowDialog(this);
            }
        }

        // Xử lý sự kiện Thoát chương trình
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show(
                "Bạn có thực sự muốn thoát ứng dụng không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (response == DialogResult.Yes)
            {
                // Dừng toàn bộ ứng dụng và diệt tiến trình ngầm ngay lập tức
                Environment.Exit(0);
            }
        }

        // Khi người dùng bấm nút [X] ở góc trên bên phải
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}