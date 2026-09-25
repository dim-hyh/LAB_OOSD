namespace QuanLyKhachSan
{
    partial class FrmDichVu
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
            this.txtPhieuLuuTru = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDichVu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgaySuDung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnGhiNhan = new System.Windows.Forms.Button();
            this.dgvSuDungDichVu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuDungDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu lưu trú:";
            // 
            // txtPhieuLuuTru
            // 
            this.txtPhieuLuuTru.Location = new System.Drawing.Point(112, 22);
            this.txtPhieuLuuTru.Name = "txtPhieuLuuTru";
            this.txtPhieuLuuTru.Size = new System.Drawing.Size(150, 23);
            this.txtPhieuLuuTru.TabIndex = 1;
            this.txtPhieuLuuTru.Text = "DP001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phòng:";
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(331, 22);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(110, 23);
            this.txtPhong.TabIndex = 3;
            this.txtPhong.Text = "A101";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dịch vụ:";
            // 
            // txtDichVu
            // 
            this.txtDichVu.Location = new System.Drawing.Point(516, 22);
            this.txtDichVu.Name = "txtDichVu";
            this.txtDichVu.Size = new System.Drawing.Size(180, 23);
            this.txtDichVu.TabIndex = 5;
            this.txtDichVu.Text = "Ăn sáng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày sử dụng:";
            // 
            // txtNgaySuDung
            // 
            this.txtNgaySuDung.Location = new System.Drawing.Point(112, 57);
            this.txtNgaySuDung.Name = "txtNgaySuDung";
            this.txtNgaySuDung.Size = new System.Drawing.Size(150, 23);
            this.txtNgaySuDung.TabIndex = 7;
            this.txtNgaySuDung.Text = "12/09/2026";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(343, 57);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(98, 23);
            this.txtSoLuong.TabIndex = 9;
            this.txtSoLuong.Text = "2";
            // 
            // btnGhiNhan
            // 
            this.btnGhiNhan.Location = new System.Drawing.Point(516, 54);
            this.btnGhiNhan.Name = "btnGhiNhan";
            this.btnGhiNhan.Size = new System.Drawing.Size(180, 28);
            this.btnGhiNhan.TabIndex = 10;
            this.btnGhiNhan.Text = "Ghi nhận";
            this.btnGhiNhan.UseVisualStyleBackColor = true;
            this.btnGhiNhan.Click += new System.EventHandler(this.btnGhiNhan_Click);
            // 
            // dgvSuDungDichVu
            // 
            this.dgvSuDungDichVu.AllowUserToAddRows = false;
            this.dgvSuDungDichVu.AllowUserToDeleteRows = false;
            this.dgvSuDungDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuDungDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuDungDichVu.Location = new System.Drawing.Point(28, 100);
            this.dgvSuDungDichVu.Name = "dgvSuDungDichVu";
            this.dgvSuDungDichVu.ReadOnly = true;
            this.dgvSuDungDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuDungDichVu.Size = new System.Drawing.Size(668, 220);
            this.dgvSuDungDichVu.TabIndex = 11;
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 341);
            this.Controls.Add(this.dgvSuDungDichVu);
            this.Controls.Add(this.btnGhiNhan);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNgaySuDung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDichVu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhieuLuuTru);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.FrmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuDungDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhieuLuuTru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDichVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNgaySuDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnGhiNhan;
        private System.Windows.Forms.DataGridView dgvSuDungDichVu;
    }
}