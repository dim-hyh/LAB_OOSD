using System;
using System.Data;
using Microsoft.Data.SqlClient; // Đổi dòng này thành Microsoft.Data.SqlClient
using System.Windows.Forms;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan
{
    public partial class FrmDanhMuc : Form
    {
        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT MaLoaiTN AS [MaDM], TenLoaiTN AS [TenDM] FROM LoaiTienNghi";
            DataTable dt = Db.GetData(query);
            dgvDanhMuc.DataSource = dt;
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDanhMuc.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dgvDanhMuc.Rows[e.RowIndex];
                txtMaDM.Text = row.Cells["MaDM"].Value?.ToString();
                txtTenDM.Text = row.Cells["TenDM"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaDM.Clear();
            txtTenDM.Clear();
            txtGhiChu.Clear();
            txtMaDM.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDM.Text) || string.IsNullOrWhiteSpace(txtTenDM.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã và Tên danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO LoaiTienNghi (MaLoaiTN, TenLoaiTN) VALUES (@Ma, @Ten)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Ma", txtMaDM.Text.Trim()),
                new SqlParameter("@Ten", txtTenDM.Text.Trim())
            };

            if (Db.ExecuteNonQuery(query, parameters))
            {
                MessageBox.Show("Thêm mới thành công vào CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDM.Text)) return;

            string query = "UPDATE LoaiTienNghi SET TenLoaiTN = @Ten WHERE MaLoaiTN = @Ma";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Ma", txtMaDM.Text.Trim()),
                new SqlParameter("@Ten", txtTenDM.Text.Trim())
            };

            if (Db.ExecuteNonQuery(query, parameters))
            {
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDM.Text)) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này khỏi CSDL?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM LoaiTienNghi WHERE MaLoaiTN = @Ma";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Ma", txtMaDM.Text.Trim())
                };

                if (Db.ExecuteNonQuery(query, parameters))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btnThem_Click(sender, e);
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}