namespace QuanLyKyTucXa
{
    partial class FrmQuanLyNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyNguoiDung));
            this.dgvNguoidung = new System.Windows.Forms.DataGridView();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rbTendangnhap = new System.Windows.Forms.RadioButton();
            this.rbManv = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbQuyen = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoidung)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNguoidung
            // 
            this.dgvNguoidung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoidung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.manv,
            this.tendangnhap,
            this.matkhau,
            this.quyen});
            this.dgvNguoidung.Location = new System.Drawing.Point(285, 40);
            this.dgvNguoidung.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNguoidung.Name = "dgvNguoidung";
            this.dgvNguoidung.RowHeadersWidth = 62;
            this.dgvNguoidung.RowTemplate.Height = 28;
            this.dgvNguoidung.Size = new System.Drawing.Size(460, 310);
            this.dgvNguoidung.TabIndex = 11;
            this.dgvNguoidung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoidung_CellClick);
            // 
            // cbManv
            // 
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(119, 91);
            this.cbManv.Margin = new System.Windows.Forms.Padding(2);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(121, 21);
            this.cbManv.TabIndex = 1;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(119, 187);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(121, 21);
            this.txtMatkhau.TabIndex = 3;
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendangnhap.Location = new System.Drawing.Point(119, 139);
            this.txtTendangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(121, 21);
            this.txtTendangnhap.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 191);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mật khẩu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 142);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tên đăng nhập";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(119, 43);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 21);
            this.txtId.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 93);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Mã nhân viên";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 44);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "ID";
            // 
            // rbTendangnhap
            // 
            this.rbTendangnhap.AutoSize = true;
            this.rbTendangnhap.Location = new System.Drawing.Point(105, 18);
            this.rbTendangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.rbTendangnhap.Name = "rbTendangnhap";
            this.rbTendangnhap.Size = new System.Drawing.Size(108, 19);
            this.rbTendangnhap.TabIndex = 1;
            this.rbTendangnhap.TabStop = true;
            this.rbTendangnhap.Text = "Tên đăng nhập";
            this.rbTendangnhap.UseVisualStyleBackColor = true;
            this.rbTendangnhap.CheckedChanged += new System.EventHandler(this.rbTendangnhap_CheckedChanged_1);
            // 
            // rbManv
            // 
            this.rbManv.AutoSize = true;
            this.rbManv.Location = new System.Drawing.Point(5, 18);
            this.rbManv.Margin = new System.Windows.Forms.Padding(2);
            this.rbManv.Name = "rbManv";
            this.rbManv.Size = new System.Drawing.Size(99, 19);
            this.rbManv.TabIndex = 0;
            this.rbManv.TabStop = true;
            this.rbManv.Text = "Mã nhân viên";
            this.rbManv.UseVisualStyleBackColor = true;
            this.rbManv.CheckedChanged += new System.EventHandler(this.rbManv_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTendangnhap);
            this.groupBox1.Controls.Add(this.rbManv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.Image = global::QuanLyKyTucXa.Properties.Resources.search;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimkiem.Location = new System.Drawing.Point(682, 377);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnTimkiem.Size = new System.Drawing.Size(63, 63);
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
            this.btnCapnhat.Location = new System.Drawing.Point(583, 377);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnCapnhat.Size = new System.Drawing.Size(63, 63);
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
            this.btnXoa.Location = new System.Drawing.Point(484, 377);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnXoa.Size = new System.Drawing.Size(63, 63);
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
            this.btnSua.Location = new System.Drawing.Point(385, 377);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnSua.Size = new System.Drawing.Size(63, 63);
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
            this.btnThem.Location = new System.Drawing.Point(286, 377);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnThem.Size = new System.Drawing.Size(63, 63);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 240);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quyền";
            // 
            // cbQuyen
            // 
            this.cbQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuyen.FormattingEnabled = true;
            this.cbQuyen.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cbQuyen.Location = new System.Drawing.Point(119, 235);
            this.cbQuyen.Margin = new System.Windows.Forms.Padding(2);
            this.cbQuyen.Name = "cbQuyen";
            this.cbQuyen.Size = new System.Drawing.Size(121, 23);
            this.cbQuyen.TabIndex = 4;
            // 
            // id
            // 
            this.id.DataPropertyName = "manguoidung";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 60;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.MinimumWidth = 8;
            this.manv.Name = "manv";
            this.manv.Width = 70;
            // 
            // tendangnhap
            // 
            this.tendangnhap.DataPropertyName = "tendangnhap";
            this.tendangnhap.HeaderText = "Tên đăng nhập";
            this.tendangnhap.MinimumWidth = 8;
            this.tendangnhap.Name = "tendangnhap";
            // 
            // matkhau
            // 
            this.matkhau.DataPropertyName = "matkhau";
            this.matkhau.HeaderText = "Mật khẩu";
            this.matkhau.MinimumWidth = 8;
            this.matkhau.Name = "matkhau";
            this.matkhau.Width = 130;
            // 
            // quyen
            // 
            this.quyen.DataPropertyName = "quyen";
            this.quyen.HeaderText = "Quyền";
            this.quyen.MinimumWidth = 8;
            this.quyen.Name = "quyen";
            this.quyen.Width = 60;
            // 
            // FrmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 478);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbManv);
            this.Controls.Add(this.dgvNguoidung);
            this.Controls.Add(this.cbQuyen);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.txtTendangnhap);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmQuanLyNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.QuanLyNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoidung)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNguoidung;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbTendangnhap;
        private System.Windows.Forms.RadioButton rbManv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyen;
    }
}