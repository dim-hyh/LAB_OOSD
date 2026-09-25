namespace QuanLyKhachSan
{
    partial class FrmDatPhong
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
            this.lblTabKhachHang = new System.Windows.Forms.Label();
            this.lblTabDatPhong = new System.Windows.Forms.Label();
            this.lblTabNhanPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoPhieuDat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKenhDat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.dgvPhongTrong = new System.Windows.Forms.DataGridView();
            this.dgvPhongChon = new System.Windows.Forms.DataGridView();
            this.btnLapPhieuDat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPhieuDat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTabKhachHang
            // 
            this.lblTabKhachHang.AutoSize = true;
            this.lblTabKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTabKhachHang.Location = new System.Drawing.Point(18, 12);
            this.lblTabKhachHang.Name = "lblTabKhachHang";
            this.lblTabKhachHang.Size = new System.Drawing.Size(78, 15);
            this.lblTabKhachHang.TabIndex = 0;
            this.lblTabKhachHang.Text = "[Khách hàng]";
            // 
            // lblTabDatPhong
            // 
            this.lblTabDatPhong.AutoSize = true;
            this.lblTabDatPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTabDatPhong.Location = new System.Drawing.Point(102, 12);
            this.lblTabDatPhong.Name = "lblTabDatPhong";
            this.lblTabDatPhong.Size = new System.Drawing.Size(74, 15);
            this.lblTabDatPhong.TabIndex = 1;
            this.lblTabDatPhong.Text = "[Đặt phòng]";
            // 
            // lblTabNhanPhong
            // 
            this.lblTabNhanPhong.AutoSize = true;
            this.lblTabNhanPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTabNhanPhong.Location = new System.Drawing.Point(182, 12);
            this.lblTabNhanPhong.Name = "lblTabNhanPhong";
            this.lblTabNhanPhong.Size = new System.Drawing.Size(149, 15);
            this.lblTabNhanPhong.TabIndex = 2;
            this.lblTabNhanPhong.Text = "[Nhận phòng / Người lưu trú]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số phiếu đặt:";
            // 
            // txtSoPhieuDat
            // 
            this.txtSoPhieuDat.Location = new System.Drawing.Point(102, 39);
            this.txtSoPhieuDat.Name = "txtSoPhieuDat";
            this.txtSoPhieuDat.Size = new System.Drawing.Size(120, 23);
            this.txtSoPhieuDat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Khách:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(284, 39);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(150, 23);
            this.txtKhachHang.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kênh đặt:";
            // 
            // txtKenhDat
            // 
            this.txtKenhDat.Location = new System.Drawing.Point(511, 39);
            this.txtKenhDat.Name = "txtKenhDat";
            this.txtKenhDat.Size = new System.Drawing.Size(110, 23);
            this.txtKenhDat.TabIndex = 8;
            this.txtKenhDat.Text = "Website";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tiền cọc:";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(698, 39);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(120, 23);
            this.txtTienCoc.TabIndex = 10;
            this.txtTienCoc.Text = "500000";
            // 
            // dgvPhongTrong
            // 
            this.dgvPhongTrong.AllowUserToAddRows = false;
            this.dgvPhongTrong.AllowUserToDeleteRows = false;
            this.dgvPhongTrong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongTrong.Location = new System.Drawing.Point(21, 75);
            this.dgvPhongTrong.MultiSelect = false;
            this.dgvPhongTrong.Name = "dgvPhongTrong";
            this.dgvPhongTrong.ReadOnly = true;
            this.dgvPhongTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongTrong.Size = new System.Drawing.Size(380, 160);
            this.dgvPhongTrong.TabIndex = 11;
            this.dgvPhongTrong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongTrong_CellClick);
            // 
            // dgvPhongChon
            // 
            this.dgvPhongChon.AllowUserToAddRows = false;
            this.dgvPhongChon.AllowUserToDeleteRows = false;
            this.dgvPhongChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongChon.Location = new System.Drawing.Point(420, 75);
            this.dgvPhongChon.MultiSelect = false;
            this.dgvPhongChon.Name = "dgvPhongChon";
            this.dgvPhongChon.ReadOnly = true;
            this.dgvPhongChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongChon.Size = new System.Drawing.Size(398, 160);
            this.dgvPhongChon.TabIndex = 12;
            // 
            // btnLapPhieuDat
            // 
            this.btnLapPhieuDat.Location = new System.Drawing.Point(698, 243);
            this.btnLapPhieuDat.Name = "btnLapPhieuDat";
            this.btnLapPhieuDat.Size = new System.Drawing.Size(120, 30);
            this.btnLapPhieuDat.TabIndex = 13;
            this.btnLapPhieuDat.Text = "Lập phiếu đặt";
            this.btnLapPhieuDat.UseVisualStyleBackColor = true;
            this.btnLapPhieuDat.Click += new System.EventHandler(this.btnLapPhieuDat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phiếu đặt phòng:";
            // 
            // dgvPhieuDat
            // 
            this.dgvPhieuDat.AllowUserToAddRows = false;
            this.dgvPhieuDat.AllowUserToDeleteRows = false;
            this.dgvPhieuDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDat.Location = new System.Drawing.Point(21, 279);
            this.dgvPhieuDat.MultiSelect = false;
            this.dgvPhieuDat.Name = "dgvPhieuDat";
            this.dgvPhieuDat.ReadOnly = true;
            this.dgvPhieuDat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuDat.Size = new System.Drawing.Size(797, 130);
            this.dgvPhieuDat.TabIndex = 15;
            // 
            // FrmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 421);
            this.Controls.Add(this.dgvPhieuDat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLapPhieuDat);
            this.Controls.Add(this.dgvPhongChon);
            this.Controls.Add(this.dgvPhongTrong);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKenhDat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoPhieuDat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTabNhanPhong);
            this.Controls.Add(this.lblTabDatPhong);
            this.Controls.Add(this.lblTabKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng - Đặt phòng - Nhận phòng";
            this.Load += new System.EventHandler(this.FrmDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTabKhachHang;
        private System.Windows.Forms.Label lblTabDatPhong;
        private System.Windows.Forms.Label lblTabNhanPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoPhieuDat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKenhDat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.DataGridView dgvPhongTrong;
        private System.Windows.Forms.DataGridView dgvPhongChon;
        private System.Windows.Forms.Button btnLapPhieuDat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPhieuDat;
    }
}