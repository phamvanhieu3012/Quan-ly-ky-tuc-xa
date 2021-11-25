namespace QuanLyKyTucXa
{
    partial class FrmQuanLyKyLuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyKyLuat));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtKyluat = new System.Windows.Forms.TextBox();
            this.dtpNgaykyluat = new System.Windows.Forms.DateTimePicker();
            this.dgvKyluat = new System.Windows.Forms.DataGridView();
            this.cbMasv = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKyluat = new System.Windows.Forms.RadioButton();
            this.rbMasv = new System.Windows.Forms.RadioButton();
            this.txtTienphat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyluat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykyluat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienphat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyluat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày kỷ luật";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kỷ luật";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(102, 37);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(103, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtKyluat
            // 
            this.txtKyluat.Location = new System.Drawing.Point(102, 146);
            this.txtKyluat.Margin = new System.Windows.Forms.Padding(2);
            this.txtKyluat.Name = "txtKyluat";
            this.txtKyluat.Size = new System.Drawing.Size(103, 20);
            this.txtKyluat.TabIndex = 2;
            // 
            // dtpNgaykyluat
            // 
            this.dtpNgaykyluat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaykyluat.Location = new System.Drawing.Point(102, 200);
            this.dtpNgaykyluat.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaykyluat.Name = "dtpNgaykyluat";
            this.dtpNgaykyluat.Size = new System.Drawing.Size(103, 20);
            this.dtpNgaykyluat.TabIndex = 3;
            // 
            // dgvKyluat
            // 
            this.dgvKyluat.AllowUserToAddRows = false;
            this.dgvKyluat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKyluat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKyluat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.masv,
            this.kyluat,
            this.ngaykyluat,
            this.tienphat});
            this.dgvKyluat.Location = new System.Drawing.Point(221, 36);
            this.dgvKyluat.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKyluat.Name = "dgvKyluat";
            this.dgvKyluat.RowHeadersWidth = 62;
            this.dgvKyluat.RowTemplate.Height = 28;
            this.dgvKyluat.Size = new System.Drawing.Size(520, 288);
            this.dgvKyluat.TabIndex = 11;
            this.dgvKyluat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKyluat_CellClick);
            // 
            // cbMasv
            // 
            this.cbMasv.FormattingEnabled = true;
            this.cbMasv.Location = new System.Drawing.Point(102, 91);
            this.cbMasv.Margin = new System.Windows.Forms.Padding(2);
            this.cbMasv.Name = "cbMasv";
            this.cbMasv.Size = new System.Drawing.Size(103, 21);
            this.cbMasv.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKyluat);
            this.groupBox1.Controls.Add(this.rbMasv);
            this.groupBox1.Location = new System.Drawing.Point(26, 303);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(180, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // rbKyluat
            // 
            this.rbKyluat.AutoSize = true;
            this.rbKyluat.Location = new System.Drawing.Point(102, 18);
            this.rbKyluat.Margin = new System.Windows.Forms.Padding(2);
            this.rbKyluat.Name = "rbKyluat";
            this.rbKyluat.Size = new System.Drawing.Size(57, 17);
            this.rbKyluat.TabIndex = 1;
            this.rbKyluat.TabStop = true;
            this.rbKyluat.Text = "Kỷ luật";
            this.rbKyluat.UseVisualStyleBackColor = true;
            this.rbKyluat.CheckedChanged += new System.EventHandler(this.rbKyluat_CheckedChanged);
            // 
            // rbMasv
            // 
            this.rbMasv.AutoSize = true;
            this.rbMasv.Location = new System.Drawing.Point(13, 18);
            this.rbMasv.Margin = new System.Windows.Forms.Padding(2);
            this.rbMasv.Name = "rbMasv";
            this.rbMasv.Size = new System.Drawing.Size(85, 17);
            this.rbMasv.TabIndex = 0;
            this.rbMasv.TabStop = true;
            this.rbMasv.Text = "Mã sinh viên";
            this.rbMasv.UseVisualStyleBackColor = true;
            this.rbMasv.CheckedChanged += new System.EventHandler(this.rbMasv_CheckedChanged);
            // 
            // txtTienphat
            // 
            this.txtTienphat.Location = new System.Drawing.Point(102, 254);
            this.txtTienphat.Margin = new System.Windows.Forms.Padding(2);
            this.txtTienphat.Name = "txtTienphat";
            this.txtTienphat.Size = new System.Drawing.Size(103, 20);
            this.txtTienphat.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tiền phạt";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.Image = global::QuanLyKyTucXa.Properties.Resources.search;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimkiem.Location = new System.Drawing.Point(681, 349);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnTimkiem.Size = new System.Drawing.Size(60, 60);
            this.btnTimkiem.TabIndex = 10;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapnhat.FlatAppearance.BorderSize = 0;
            this.btnCapnhat.Image = global::QuanLyKyTucXa.Properties.Resources.reload;
            this.btnCapnhat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapnhat.Location = new System.Drawing.Point(584, 349);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnCapnhat.Size = new System.Drawing.Size(60, 60);
            this.btnCapnhat.TabIndex = 9;
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
            this.btnXoa.Location = new System.Drawing.Point(487, 349);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnXoa.Size = new System.Drawing.Size(60, 60);
            this.btnXoa.TabIndex = 8;
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
            this.btnSua.Location = new System.Drawing.Point(390, 350);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnSua.Size = new System.Drawing.Size(60, 60);
            this.btnSua.TabIndex = 7;
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
            this.btnThem.Location = new System.Drawing.Point(293, 350);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnThem.Size = new System.Drawing.Size(60, 60);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "makyluat";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 80;
            // 
            // masv
            // 
            this.masv.DataPropertyName = "masv";
            this.masv.HeaderText = "Mã sinh viên";
            this.masv.MinimumWidth = 8;
            this.masv.Name = "masv";
            this.masv.Width = 90;
            // 
            // kyluat
            // 
            this.kyluat.DataPropertyName = "kyluat";
            this.kyluat.HeaderText = "Kỷ luật";
            this.kyluat.MinimumWidth = 8;
            this.kyluat.Name = "kyluat";
            this.kyluat.Width = 110;
            // 
            // ngaykyluat
            // 
            this.ngaykyluat.DataPropertyName = "ngaykyluat";
            this.ngaykyluat.HeaderText = "Ngày kỷ luật";
            this.ngaykyluat.MinimumWidth = 8;
            this.ngaykyluat.Name = "ngaykyluat";
            // 
            // tienphat
            // 
            this.tienphat.DataPropertyName = "tienphat";
            this.tienphat.HeaderText = "Tiền phạt";
            this.tienphat.MinimumWidth = 8;
            this.tienphat.Name = "tienphat";
            // 
            // FrmQuanLyKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.txtTienphat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbMasv);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvKyluat);
            this.Controls.Add(this.dtpNgaykyluat);
            this.Controls.Add(this.txtKyluat);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmQuanLyKyLuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kỷ luật";
            this.Load += new System.EventHandler(this.QuanLyKyLuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyluat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtKyluat;
        private System.Windows.Forms.DateTimePicker dtpNgaykyluat;
        private System.Windows.Forms.DataGridView dgvKyluat;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbMasv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKyluat;
        private System.Windows.Forms.RadioButton rbMasv;
        private System.Windows.Forms.TextBox txtTienphat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyluat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykyluat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienphat;
    }
}