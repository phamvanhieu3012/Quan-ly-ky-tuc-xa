namespace QuanLyKyTucXa
{
    partial class FrmQuanLyDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyDay));
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.dgvDay = new System.Windows.Forms.DataGridView();
            this.maday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaday = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenday = new System.Windows.Forms.TextBox();
            this.cbQuanly = new System.Windows.Forms.ComboBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(129, 208);
            this.txtTrangthai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(123, 20);
            this.txtTrangthai.TabIndex = 3;
            // 
            // dgvDay
            // 
            this.dgvDay.AllowUserToAddRows = false;
            this.dgvDay.AllowUserToDeleteRows = false;
            this.dgvDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maday,
            this.tenday,
            this.quanly,
            this.trangthai});
            this.dgvDay.Location = new System.Drawing.Point(285, 45);
            this.dgvDay.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDay.Name = "dgvDay";
            this.dgvDay.RowHeadersWidth = 62;
            this.dgvDay.RowTemplate.Height = 28;
            this.dgvDay.Size = new System.Drawing.Size(440, 227);
            this.dgvDay.TabIndex = 8;
            this.dgvDay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDay_CellClick);
            // 
            // maday
            // 
            this.maday.DataPropertyName = "maday";
            this.maday.HeaderText = "Mã dãy";
            this.maday.MinimumWidth = 8;
            this.maday.Name = "maday";
            // 
            // tenday
            // 
            this.tenday.DataPropertyName = "tenday";
            this.tenday.HeaderText = "Tên dãy";
            this.tenday.MinimumWidth = 8;
            this.tenday.Name = "tenday";
            // 
            // quanly
            // 
            this.quanly.DataPropertyName = "quanly";
            this.quanly.HeaderText = "Quản lý";
            this.quanly.MinimumWidth = 8;
            this.quanly.Name = "quanly";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 8;
            this.trangthai.Name = "trangthai";
            // 
            // txtMaday
            // 
            this.txtMaday.Location = new System.Drawing.Point(129, 45);
            this.txtMaday.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaday.Name = "txtMaday";
            this.txtMaday.Size = new System.Drawing.Size(123, 20);
            this.txtMaday.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Quản lý";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên dãy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã dãy";
            // 
            // txtTenday
            // 
            this.txtTenday.Location = new System.Drawing.Point(129, 99);
            this.txtTenday.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenday.Name = "txtTenday";
            this.txtTenday.Size = new System.Drawing.Size(123, 20);
            this.txtTenday.TabIndex = 1;
            // 
            // cbQuanly
            // 
            this.cbQuanly.FormattingEnabled = true;
            this.cbQuanly.Location = new System.Drawing.Point(129, 153);
            this.cbQuanly.Margin = new System.Windows.Forms.Padding(2);
            this.cbQuanly.Name = "cbQuanly";
            this.cbQuanly.Size = new System.Drawing.Size(123, 21);
            this.cbQuanly.TabIndex = 2;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapnhat.FlatAppearance.BorderSize = 0;
            this.btnCapnhat.Image = global::QuanLyKyTucXa.Properties.Resources.reload;
            this.btnCapnhat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapnhat.Location = new System.Drawing.Point(665, 292);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnCapnhat.Size = new System.Drawing.Size(60, 60);
            this.btnCapnhat.TabIndex = 7;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Image = global::QuanLyKyTucXa.Properties.Resources.close;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(564, 292);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnXoa.Size = new System.Drawing.Size(60, 60);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Image = global::QuanLyKyTucXa.Properties.Resources.clipboard;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(463, 292);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnSua.Size = new System.Drawing.Size(60, 60);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(362, 292);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnThem.Size = new System.Drawing.Size(60, 60);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmQuanLyDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 386);
            this.Controls.Add(this.cbQuanly);
            this.Controls.Add(this.txtTenday);
            this.Controls.Add(this.txtTrangthai);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDay);
            this.Controls.Add(this.txtMaday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmQuanLyDay";
            this.Text = "Quản lý dãy";
            this.Load += new System.EventHandler(this.FrmQuanLyDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDay;
        private System.Windows.Forms.TextBox txtMaday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenday;
        private System.Windows.Forms.ComboBox cbQuanly;
        private System.Windows.Forms.DataGridViewTextBoxColumn maday;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenday;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanly;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}