using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan
{
    public partial class FrmPhongTienNghi : Form
    {
        public FrmPhongTienNghi()
        {
            InitializeComponent();
        }

        private void FrmPhongTienNghi_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhong();
            TaoMaPhieuTuDong();
        }

        // 1. Tải danh sách Phòng lên DataGridView
        private void LoadDanhSachPhong()
        {
            string query = @"SELECT P.SoPhong AS [Phòng], 
                                   K.TenKhuVuc AS [Khu], 
                                   P.SoNguoiToiDa AS [Sức chứa], 
                                   P.DonGiaNgay AS [Đơn giá], 
                                   P.TrangThai AS [Trạng thái] 
                            FROM Phong P 
                            INNER JOIN KhuVuc K ON P.MaKhuVuc = K.MaKhuVuc";

            DataTable? dt = Db.GetData(query);
            if (dt != null && dgvPhong != null)
            {
                dgvPhong.DataSource = dt;
            }
        }

        // 2. Click chọn dòng trong bảng để hiển thị lên TextBox
        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPhong != null && e.RowIndex >= 0 && dgvPhong.Rows[e.RowIndex].Cells["Phòng"].Value != DBNull.Value)
            {
                DataGridViewRow row = dgvPhong.Rows[e.RowIndex];

                txtSoPhong.Text = row.Cells["Phòng"].Value?.ToString() ?? string.Empty;
                txtKhuVuc.Text = row.Cells["Khu"].Value?.ToString() ?? string.Empty;
                txtSoNguoi.Text = row.Cells["Sức chứa"].Value?.ToString() ?? string.Empty;
                txtDonGia.Text = row.Cells["Đơn giá"].Value?.ToString() ?? string.Empty;

                txtPhongLap.Text = txtSoPhong.Text;
            }
        }

        // 3. Tự sinh mã phiếu tự động
        private void TaoMaPhieuTuDong()
        {
            txtSoPhieu.Text = "LD" + DateTime.Now.ToString("fff");
            txtTinhTrang.Text = "Tốt";
        }

        // 4. Xử lý Lập phiếu
        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoPhieu.Text) ||
                string.IsNullOrWhiteSpace(txtMaTienNghi.Text) ||
                string.IsNullOrWhiteSpace(txtPhongLap.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Mã phiếu, Mã tiện nghi và Số phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"INSERT INTO PhieuLapDat (SoPhieuLapDat, MaTienNghi, SoPhong, NgayLap, TinhTrang, MaNV, GhiChu) 
                            VALUES (@SoPhieu, @MaTienNghi, @SoPhong, @NgayLap, @TinhTrang, @MaNV, @GhiChu)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SoPhieu", txtSoPhieu.Text.Trim()),
                new SqlParameter("@MaTienNghi", txtMaTienNghi.Text.Trim()),
                new SqlParameter("@SoPhong", txtPhongLap.Text.Trim()),
                new SqlParameter("@NgayLap", DateTime.Now),
                new SqlParameter("@TinhTrang", txtTinhTrang.Text.Trim()),
                new SqlParameter("@MaNV", "NV01"),
                new SqlParameter("@GhiChu", "Lap tu giao dien Quan ly")
            };

            if (Db.ExecuteNonQuery(query, parameters))
            {
                MessageBox.Show($"Lập phiếu lắp đặt [{txtSoPhieu.Text}] cho phòng [{txtPhongLap.Text}] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaoMaPhieuTuDong();
                txtMaTienNghi.Clear();
            }
            else
            {
                MessageBox.Show("Không thể lập phiếu! Kiểm tra lại Mã tiện nghi có tồn tại trong CSDL chưa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}