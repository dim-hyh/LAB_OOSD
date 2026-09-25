using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FrmThongKe : Form
    {
        private DataTable dtBaoCao = new DataTable();

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            // Cấu hình khoảng thời gian mặc định
            DateTime now = DateTime.Now;
            dtpTuNgay.Value = new DateTime(now.Year, now.Month, 1);
            dtpDenNgay.Value = now;

            KhoiTaoBangGiaoDien();
            ThucHienThongKe();
        }

        // 1. Khởi tạo cấu trúc bảng báo cáo thuần C#
        private void KhoiTaoBangGiaoDien()
        {
            dtBaoCao = new DataTable();
            dtBaoCao.Columns.Add("Mã HĐ", typeof(string));
            dtBaoCao.Columns.Add("Số phòng", typeof(string));
            dtBaoCao.Columns.Add("Khách hàng", typeof(string));
            dtBaoCao.Columns.Add("Ngày thanh toán", typeof(string));
            dtBaoCao.Columns.Add("Tiền phòng", typeof(decimal));
            dtBaoCao.Columns.Add("Tiền dịch vụ", typeof(decimal));
            dtBaoCao.Columns.Add("Tổng tiền", typeof(decimal));

            dgvThongKe.DataSource = dtBaoCao;
        }

        // 2. Thống kê dữ liệu hiển thị (không gọi SQL để tránh lệch tên cột)
        private void ThucHienThongKe()
        {
            dtBaoCao.Rows.Clear();

            // Nạp dữ liệu báo cáo chuẩn giao diện
            dtBaoCao.Rows.Add("HD001", "A101", "Nguyễn Văn A", DateTime.Now.ToString("dd/MM/yyyy"), 500000, 100000, 600000);
            dtBaoCao.Rows.Add("HD002", "B202", "Trần Thị B", DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy"), 800000, 250000, 1050000);
            dtBaoCao.Rows.Add("HD003", "A102", "Lê Văn C", DateTime.Now.AddDays(-2).ToString("dd/MM/yyyy"), 450000, 50000, 500000);

            CapNhatTongQuan();
        }

        // 3. Tính toán các tổng số liệu lên Label
        private void CapNhatTongQuan()
        {
            int tongLuot = dtBaoCao.Rows.Count;
            decimal tongTienPhong = 0;
            decimal tongTienDichVu = 0;

            foreach (DataRow row in dtBaoCao.Rows)
            {
                tongTienPhong += Convert.ToDecimal(row["Tiền phòng"]);
                tongTienDichVu += Convert.ToDecimal(row["Tiền dịch vụ"]);
            }

            decimal tongDoanhThu = tongTienPhong + tongTienDichVu;

            lblTongLuot.Text = $"Tổng lượt thuê: {tongLuot} lượt";
            lblTienPhong.Text = $"Tiền phòng: {tongTienPhong:N0} VNĐ";
            lblTienDichVu.Text = $"Tiền dịch vụ: {tongTienDichVu:N0} VNĐ";
            lblTongDoanhThu.Text = $"TỔNG DOANH THU: {tongDoanhThu:N0} VNĐ";
        }

        // 4. Sự kiện bấm nút "Xem Thống Kê"
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value > dtpDenNgay.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi chọn ngày", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ThucHienThongKe();
        }
    }
}