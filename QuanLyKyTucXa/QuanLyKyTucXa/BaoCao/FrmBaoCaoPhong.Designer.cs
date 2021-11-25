namespace QuanLyKyTucXa
{
    partial class FrmBaoCaoPhong
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
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sosv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sosvtoida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeploai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
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
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong,
            this.tenphong,
            this.sosv,
            this.sosvtoida,
            this.tinhtrang,
            this.loaiphong,
            this.xeploai,
            this.day});
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.Location = new System.Drawing.Point(0, 24);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(684, 387);
            this.dgvPhong.TabIndex = 12;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.Name = "maphong";
            this.maphong.Width = 80;
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "tenphong";
            this.tenphong.HeaderText = "Tên phòng";
            this.tenphong.Name = "tenphong";
            // 
            // sosv
            // 
            this.sosv.DataPropertyName = "sosv";
            this.sosv.HeaderText = "Số sinh viên hiện tại";
            this.sosv.Name = "sosv";
            // 
            // sosvtoida
            // 
            this.sosvtoida.DataPropertyName = "sosvtoida";
            this.sosvtoida.HeaderText = "Sô sv tối đa";
            this.sosvtoida.Name = "sosvtoida";
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.Name = "tinhtrang";
            // 
            // loaiphong
            // 
            this.loaiphong.DataPropertyName = "loaiphong";
            this.loaiphong.HeaderText = "Loại phòng";
            this.loaiphong.Name = "loaiphong";
            // 
            // xeploai
            // 
            this.xeploai.DataPropertyName = "xeploai";
            this.xeploai.HeaderText = "Xếp loại";
            this.xeploai.Name = "xeploai";
            // 
            // day
            // 
            this.day.DataPropertyName = "day";
            this.day.HeaderText = "Dãy";
            this.day.Name = "day";
            // 
            // FrmBaoCaoPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmBaoCaoPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo phòng";
            this.Load += new System.EventHandler(this.FrmBaoCaoPhong_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sosv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sosvtoida;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn xeploai;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
    }
}