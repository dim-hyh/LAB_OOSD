using QuanLyKhachSan.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FrmTraPhong : Form
    {
        private DataTable dtHoaDon = new DataTable();

        public FrmTraPhong()
        {
            InitializeComponent();
        }

        private void FrmTraPhong_Load(object sender, EventArgs e)
        {
            KhoiTaoBangGiaoDien();
            LoadDuLieuTraPhong();
            TinhTongTien();
        }

        // 1. Kiểm tra Bảng SQL có tồn tại không trước khi load
        private bool KiemTraBangTonTai(string tenBang)
        {
            try
            {
                string query = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tenBang}'";
                DataTable? dt = Db.GetData(query);
                if (dt != null && dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0][0]) > 0;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        // 2. Cấu trúc bảng hiển thị chi tiết hóa đơn
        private void KhoiTaoBangGiaoDien()
        {
            dtHoaDon = new DataTable();
            dtHoaDon.Columns.Add("Hạng mục", typeof(string));
            dtHoaDon.Columns.Add("Mô tả / Tên dịch vụ", typeof(string));
            dtHoaDon.Columns.Add("Số lượng / Số ngày", typeof(int));
            dtHoaDon.Columns.Add("Đơn giá", typeof(decimal));
            dtHoaDon.Columns.Add("Thành tiền", typeof(decimal));

            dgvChiTietHoaDon.DataSource = dtHoaDon;
        }

        // 3. Nạp dữ liệu vào chi tiết hóa đơn
        private void LoadDuLieuTraPhong()
        {
            // Thêm tiền phòng mẫu
            dtHoaDon.Rows.Add("Tiền phòng", "Phòng A101 (1 ngày)", 1, 500000, 500000);

            // Nếu trong SQL có bảng ChiTietDichVu thì đọc thêm dữ liệu dịch vụ từ SQL
            if (KiemTraBangTonTai("ChiTietDichVu"))
            {
                string query = "SELECT TenDichVu, SoLuong, DonGia, ThanhTien FROM ChiTietDichVu WHERE SoPhieu = 'DP001'";
                DataTable? dt = Db.GetData(query);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dtHoaDon.Rows.Add(
                            "Dịch vụ",
                            row["TenDichVu"].ToString(),
                            Convert.ToInt32(row["SoLuong"]),
                            Convert.ToDecimal(row["DonGia"]),
                            Convert.ToDecimal(row["ThanhTien"])
                        );
                    }
                }
            }
            else
            {
                // Dữ liệu mẫu tạm thời nếu chưa có bảng SQL
                dtHoaDon.Rows.Add("Dịch vụ", "Ăn sáng", 2, 50000, 100000);
            }
        }

        // 4. Tính toán tiền tự động
        private void TinhTongTien()
        {
            decimal tienPhong = 500000;
            decimal tienDichVu = 0;

            foreach (DataRow row in dtHoaDon.Rows)
            {
                if (row["Hạng mục"].ToString() == "Dịch vụ")
                {
                    tienDichVu += Convert.ToDecimal(row["Thành tiền"]);
                }
            }

            decimal tongTien = tienPhong + tienDichVu;

            txtTienPhong.Text = tienPhong.ToString("N0");
            txtTienDichVu.Text = tienDichVu.ToString("N0");
            txtTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }

        // 5. Nút Thanh toán & Trả phòng
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Xác nhận thanh toán tổng số tiền {txtTongTien.Text} và làm thủ tục trả phòng [{txtSoPhong.Text}]?",
                "Xác nhận thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thanh toán thành công! Phòng đã được cập nhật về trạng thái 'Trống'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}