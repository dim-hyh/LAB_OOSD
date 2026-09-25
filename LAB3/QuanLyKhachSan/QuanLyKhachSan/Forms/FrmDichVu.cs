using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FrmDichVu : Form
    {
        private DataTable dtDichVu = new DataTable();

        public FrmDichVu()
        {
            InitializeComponent();
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            KhoiTaoBangGiaoDien();
        }

        // Tạo cấu trúc bảng hiển thị trên DataGridView
        private void KhoiTaoBangGiaoDien()
        {
            dtDichVu = new DataTable();
            dtDichVu.Columns.Add("Số phiếu", typeof(string));
            dtDichVu.Columns.Add("Phòng", typeof(string));
            dtDichVu.Columns.Add("Ngày", typeof(string));
            dtDichVu.Columns.Add("Dịch vụ", typeof(string));
            dtDichVu.Columns.Add("Số lượng", typeof(int));
            dtDichVu.Columns.Add("Đơn giá", typeof(decimal));
            dtDichVu.Columns.Add("Thành tiền", typeof(decimal));

            dgvSuDungDichVu.DataSource = dtDichVu;
        }

        // Nút "Ghi nhận" dịch vụ
        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhieuLuuTru.Text) ||
                string.IsNullOrWhiteSpace(txtPhong.Text) ||
                string.IsNullOrWhiteSpace(txtDichVu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal donGia = 50000; // Đơn giá mặc định
            decimal thanhTien = soLuong * donGia;

            // Thêm trực tiếp dòng mới vào DataGridView
            dtDichVu.Rows.Add(
                txtPhieuLuuTru.Text.Trim(),
                txtPhong.Text.Trim(),
                txtNgaySuDung.Text.Trim(),
                txtDichVu.Text.Trim(),
                soLuong,
                donGia,
                thanhTien
            );

            MessageBox.Show($"Ghi nhận dịch vụ [{txtDichVu.Text}] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}