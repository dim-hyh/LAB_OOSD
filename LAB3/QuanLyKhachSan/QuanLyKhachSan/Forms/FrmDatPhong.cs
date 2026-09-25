using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan
{
    public partial class FrmDatPhong : Form
    {
        private DataTable dtPhongChon = new DataTable();

        public FrmDatPhong()
        {
            InitializeComponent();
        }

        private void FrmDatPhong_Load(object sender, EventArgs e)
        {
            KhoiTaoBangPhongChon();
            LoadDanhSachPhongTrong();
            LoadDanhSachPhieuDat();
            TaoMaPhieuTuDong();
        }

        // 1. Cấu trúc bảng Phòng Chọn
        private void KhoiTaoBangPhongChon()
        {
            dtPhongChon = new DataTable();
            dtPhongChon.Columns.Add("Phòng chọn", typeof(string));
            dtPhongChon.Columns.Add("Số người", typeof(int));
            dtPhongChon.Columns.Add("Đơn giá/ngày", typeof(decimal));
            dgvPhongChon.DataSource = dtPhongChon;
        }

        // 2. Load danh sách Phòng trống
        private void LoadDanhSachPhongTrong()
        {
            string query = @"SELECT P.SoPhong AS [Phòng], 
                                   K.TenKhuVuc AS [Khu], 
                                   P.SoNguoiToiDa AS [Sức chứa], 
                                   P.DonGiaNgay AS [Đơn giá] 
                            FROM Phong P 
                            INNER JOIN KhuVuc K ON P.MaKhuVuc = K.MaKhuVuc
                            WHERE P.TrangThai = N'Trống' OR P.TrangThai = 'Trống'";

            DataTable? dt = Db.GetData(query);
            if (dt != null)
            {
                dgvPhongTrong.DataSource = dt;
            }
        }

        // 3. Load danh sách Phiếu Đặt Phòng (Sửa tên cột an toàn theo CSDL)
        private void LoadDanhSachPhieuDat()
        {
            string query = @"SELECT * FROM PhieuDatPhong";

            DataTable? dt = Db.GetData(query);
            if (dt != null)
            {
                dgvPhieuDat.DataSource = dt;
            }
        }

        // 4. Sinh mã phiếu tự động
        private void TaoMaPhieuTuDong()
        {
            txtSoPhieuDat.Text = "DP001";
            txtKhachHang.Text = "Nguyễn Văn A";
        }

        // 5. Chọn phòng từ danh sách trống
        private void dgvPhongTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPhongTrong.Rows[e.RowIndex].Cells["Phòng"].Value != DBNull.Value)
            {
                DataGridViewRow row = dgvPhongTrong.Rows[e.RowIndex];
                string soPhong = row.Cells["Phòng"].Value?.ToString() ?? string.Empty;
                int sucChua = Convert.ToInt32(row.Cells["Sức chứa"].Value);
                decimal donGia = Convert.ToDecimal(row.Cells["Đơn giá"].Value);

                foreach (DataRow r in dtPhongChon.Rows)
                {
                    if (r["Phòng chọn"].ToString() == soPhong)
                    {
                        MessageBox.Show("Phòng này đã được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                dtPhongChon.Rows.Add(soPhong, sucChua, donGia);
            }
        }

        // 6. Xử lý Lập phiếu đặt
        private void btnLapPhieuDat_Click(object sender, EventArgs e)
        {
            if (dtPhongChon.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Lập phiếu đặt phòng [{txtSoPhieuDat.Text}] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dtPhongChon.Rows.Clear();
            LoadDanhSachPhieuDat();
        }
    }
}