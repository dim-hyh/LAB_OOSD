namespace QuanLyKhachSan
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblHeader = new Label();
            btnDanhMuc = new Button();
            btnPhong = new Button();
            btnDatPhong = new Button();
            btnDichVu = new Button();
            btnTraPhong = new Button();
            btnThongKe = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(10, 40, 100);
            lblHeader.Location = new Point(14, 33);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(869, 53);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.Font = new Font("Segoe UI", 11F);
            btnDanhMuc.Location = new Point(57, 127);
            btnDanhMuc.Margin = new Padding(3, 4, 3, 4);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(240, 80);
            btnDanhMuc.TabIndex = 1;
            btnDanhMuc.Text = "📋  Danh mục";
            btnDanhMuc.UseVisualStyleBackColor = true;
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // btnPhong
            // 
            btnPhong.Font = new Font("Segoe UI", 11F);
            btnPhong.Location = new Point(326, 127);
            btnPhong.Margin = new Padding(3, 4, 3, 4);
            btnPhong.Name = "btnPhong";
            btnPhong.Size = new Size(240, 80);
            btnPhong.TabIndex = 2;
            btnPhong.Text = "🛏️  Phòng - Tiện nghi";
            btnPhong.UseVisualStyleBackColor = true;
            btnPhong.Click += btnPhong_Click;
            // 
            // btnDatPhong
            // 
            btnDatPhong.Font = new Font("Segoe UI", 11F);
            btnDatPhong.Location = new Point(594, 127);
            btnDatPhong.Margin = new Padding(3, 4, 3, 4);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(240, 80);
            btnDatPhong.TabIndex = 3;
            btnDatPhong.Text = "🔑  Đặt / Nhận phòng";
            btnDatPhong.UseVisualStyleBackColor = true;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // btnDichVu
            // 
            btnDichVu.Font = new Font("Segoe UI", 11F);
            btnDichVu.Location = new Point(57, 233);
            btnDichVu.Margin = new Padding(3, 4, 3, 4);
            btnDichVu.Name = "btnDichVu";
            btnDichVu.Size = new Size(240, 80);
            btnDichVu.TabIndex = 4;
            btnDichVu.Text = "⚙️  Sử dụng dịch vụ";
            btnDichVu.UseVisualStyleBackColor = true;
            btnDichVu.Click += btnDichVu_Click;
            // 
            // btnTraPhong
            // 
            btnTraPhong.Font = new Font("Segoe UI", 11F);
            btnTraPhong.Location = new Point(326, 233);
            btnTraPhong.Margin = new Padding(3, 4, 3, 4);
            btnTraPhong.Name = "btnTraPhong";
            btnTraPhong.Size = new Size(240, 80);
            btnTraPhong.TabIndex = 5;
            btnTraPhong.Text = "💵  Trả phòng - Thanh toán";
            btnTraPhong.UseVisualStyleBackColor = true;
            btnTraPhong.Click += btnTraPhong_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Font = new Font("Segoe UI", 11F);
            btnThongKe.Location = new Point(594, 233);
            btnThongKe.Margin = new Padding(3, 4, 3, 4);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(240, 80);
            btnThongKe.TabIndex = 6;
            btnThongKe.Text = "📊  Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnThoat.Location = new Point(326, 340);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(240, 80);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "🚪  Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 455);
            Controls.Add(lblHeader);
            Controls.Add(btnDanhMuc);
            Controls.Add(btnPhong);
            Controls.Add(btnDatPhong);
            Controls.Add(btnDichVu);
            Controls.Add(btnTraPhong);
            Controls.Add(btnThongKe);
            Controls.Add(btnThoat);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách sạn";
            ResumeLayout(false);

        }

        #endregion
    }
}