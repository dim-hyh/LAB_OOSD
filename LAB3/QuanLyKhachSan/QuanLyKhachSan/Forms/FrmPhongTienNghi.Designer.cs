namespace QuanLyKhachSan
{
    partial class FrmPhongTienNghi
    {
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.txtKhuVuc = new System.Windows.Forms.TextBox();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.txtMaTienNghi = new System.Windows.Forms.TextBox();
            this.txtPhongLap = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.lblTabPhong = new System.Windows.Forms.Label();
            this.lblTabTienNghi = new System.Windows.Forms.Label();
            this.lblTabLapDat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTabPhong
            // 
            this.lblTabPhong.AutoSize = true;
            this.lblTabPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTabPhong.Location = new System.Drawing.Point(20, 15);
            this.lblTabPhong.Name = "lblTabPhong";
            this.lblTabPhong.Size = new System.Drawing.Size(56, 15);
            this.lblTabPhong.TabIndex = 0;
            this.lblTabPhong.Text = "[Phòng]";
            // 
            // lblTabTienNghi
            // 
            this.lblTabTienNghi.AutoSize = true;
            this.lblTabTienNghi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblTabTienNghi.Location = new System.Drawing.Point(82, 15);
            this.lblTabTienNghi.Name = "lblTabTienNghi";
            this.lblTabTienNghi.Size = new System.Drawing.Size(69, 15);
            this.lblTabTienNghi.TabIndex = 1;
            this.lblTabTienNghi.Text = "[Tiện nghi]";
            // 
            // lblTabLapDat
            // 
            this.lblTabLapDat.AutoSize = true;
            this.lblTabLapDat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblTabLapDat.Location = new System.Drawing.Point(157, 15);
            this.lblTabLapDat.Name = "lblTabLapDat";
            this.lblTabLapDat.Size = new System.Drawing.Size(126, 15);
            this.lblTabLapDat.TabIndex = 2;
            this.lblTabLapDat.Text = "[Lắp đặt / luân chuyển]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số phòng:";
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(87, 47);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(130, 23);
            this.txtSoPhong.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Khu vực:";
            // 
            // txtKhuVuc
            // 
            this.txtKhuVuc.Location = new System.Drawing.Point(294, 47);
            this.txtKhuVuc.Name = "txtKhuVuc";
            this.txtKhuVuc.Size = new System.Drawing.Size(120, 23);
            this.txtKhuVuc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số người tối đa:";
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Location = new System.Drawing.Point(525, 47);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Size = new System.Drawing.Size(70, 23);
            this.txtSoNguoi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đơn giá/ngày:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(700, 47);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(120, 23);
            this.txtDonGia.TabIndex = 10;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(23, 85);
            this.dgvPhong.MultiSelect = false;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(797, 240);
            this.dgvPhong.TabIndex = 11;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phiếu lắp đặt:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(109, 342);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(110, 23);
            this.txtSoPhieu.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tiện nghi:";
            // 
            // txtMaTienNghi
            // 
            this.txtMaTienNghi.Location = new System.Drawing.Point(299, 342);
            this.txtMaTienNghi.Name = "txtMaTienNghi";
            this.txtMaTienNghi.Size = new System.Drawing.Size(110, 23);
            this.txtMaTienNghi.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Phòng:";
            // 
            // txtPhongLap
            // 
            this.txtPhongLap.Location = new System.Drawing.Point(483, 342);
            this.txtPhongLap.Name = "txtPhongLap";
            this.txtPhongLap.Size = new System.Drawing.Size(110, 23);
            this.txtPhongLap.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(613, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tình trạng:";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(684, 342);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(136, 23);
            this.txtTinhTrang.TabIndex = 19;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(700, 380);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(120, 30);
            this.btnLapPhieu.TabIndex = 20;
            this.btnLapPhieu.Text = "Lập phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // FrmPhongTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 425);
            this.Controls.Add(this.btnLapPhieu);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPhongLap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaTienNghi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoPhieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoNguoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKhuVuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTabLapDat);
            this.Controls.Add(this.lblTabTienNghi);
            this.Controls.Add(this.lblTabPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPhongTienNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng - Tiện nghi - Phiếu lắp đặt";
            this.Load += new System.EventHandler(this.FrmPhongTienNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTabPhong;
        private System.Windows.Forms.Label lblTabTienNghi;
        private System.Windows.Forms.Label lblTabLapDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.TextBox txtKhuVuc;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.TextBox txtMaTienNghi;
        private System.Windows.Forms.TextBox txtPhongLap;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Button btnLapPhieu;
    }
}