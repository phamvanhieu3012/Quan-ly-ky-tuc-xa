namespace QuanLyKyTucXa.BaoCao
{
    partial class FrmBaoCaoTienDien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTiendien = new System.Windows.Forms.DataGridView();
            this.mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chisocu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chisomoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodientieuthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xuấtExcelToolStripMenuItem
            // 
            this.xuấtExcelToolStripMenuItem.Name = "xuấtExcelToolStripMenuItem";
            this.xuấtExcelToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.xuấtExcelToolStripMenuItem.Text = "Xuất excel";
            this.xuấtExcelToolStripMenuItem.Click += new System.EventHandler(this.xuấtExcelToolStripMenuItem_Click);
            // 
            // dgvTiendien
            // 
            this.dgvTiendien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiendien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahoadon,
            this.maphong,
            this.ngaylap,
            this.chisocu,
            this.chisomoi,
            this.sodientieuthu,
            this.tongtien,
            this.trangthai});
            this.dgvTiendien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTiendien.Location = new System.Drawing.Point(0, 24);
            this.dgvTiendien.Name = "dgvTiendien";
            this.dgvTiendien.Size = new System.Drawing.Size(724, 337);
            this.dgvTiendien.TabIndex = 14;
            // 
            // mahoadon
            // 
            this.mahoadon.DataPropertyName = "mahoadon";
            this.mahoadon.HeaderText = "Mã hóa đơn";
            this.mahoadon.Name = "mahoadon";
            this.mahoadon.Width = 80;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.Name = "maphong";
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "ngaylap";
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.Name = "ngaylap";
            // 
            // chisocu
            // 
            this.chisocu.DataPropertyName = "chisocu";
            this.chisocu.HeaderText = "Chỉ số cũ";
            this.chisocu.Name = "chisocu";
            this.chisocu.Width = 80;
            // 
            // chisomoi
            // 
            this.chisomoi.DataPropertyName = "chisomoi";
            this.chisomoi.HeaderText = "Chỉ số mới";
            this.chisomoi.Name = "chisomoi";
            this.chisomoi.Width = 80;
            // 
            // sodientieuthu
            // 
            this.sodientieuthu.DataPropertyName = "sodientieuthu";
            this.sodientieuthu.HeaderText = "Lượng điện tiêu thụ";
            this.sodientieuthu.Name = "sodientieuthu";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // FrmBaoCaoTienDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 361);
            this.Controls.Add(this.dgvTiendien);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmBaoCaoTienDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tiền điện";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTiendien;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn chisocu;
        private System.Windows.Forms.DataGridViewTextBoxColumn chisomoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodientieuthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}