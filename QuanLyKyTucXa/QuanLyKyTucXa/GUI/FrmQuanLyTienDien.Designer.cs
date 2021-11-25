namespace QuanLyKyTucXa
{
    partial class FrmQuanLyTienDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyTienDien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMahoadon = new System.Windows.Forms.TextBox();
            this.txtChisomoi = new System.Windows.Forms.TextBox();
            this.txtTiendien = new System.Windows.Forms.TextBox();
            this.dtpNgaylap = new System.Windows.Forms.DateTimePicker();
            this.cbTrangthai = new System.Windows.Forms.ComboBox();
            this.dgvTiendien = new System.Windows.Forms.DataGridView();
            this.mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodientieuthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTktheoma = new System.Windows.Forms.RadioButton();
            this.rbTktheott = new System.Windows.Forms.RadioButton();
            this.cbMaphong = new System.Windows.Forms.ComboBox();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ngày lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Chỉ số mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tiền điện";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Trạng thái";
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.Enabled = false;
            this.txtMahoadon.Location = new System.Drawing.Point(141, 43);
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.Size = new System.Drawing.Size(110, 20);
            this.txtMahoadon.TabIndex = 0;
            // 
            // txtChisomoi
            // 
            this.txtChisomoi.Location = new System.Drawing.Point(412, 43);
            this.txtChisomoi.Name = "txtChisomoi";
            this.txtChisomoi.Size = new System.Drawing.Size(110, 20);
            this.txtChisomoi.TabIndex = 3;
            // 
            // txtTiendien
            // 
            this.txtTiendien.Enabled = false;
            this.txtTiendien.Location = new System.Drawing.Point(412, 86);
            this.txtTiendien.Name = "txtTiendien";
            this.txtTiendien.Size = new System.Drawing.Size(110, 20);
            this.txtTiendien.TabIndex = 4;
            this.txtTiendien.Text = "3000đ / số";
            // 
            // dtpNgaylap
            // 
            this.dtpNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaylap.Location = new System.Drawing.Point(141, 129);
            this.dtpNgaylap.Name = "dtpNgaylap";
            this.dtpNgaylap.Size = new System.Drawing.Size(110, 20);
            this.dtpNgaylap.TabIndex = 2;
            // 
            // cbTrangthai
            // 
            this.cbTrangthai.FormattingEnabled = true;
            this.cbTrangthai.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cbTrangthai.Location = new System.Drawing.Point(412, 129);
            this.cbTrangthai.Name = "cbTrangthai";
            this.cbTrangthai.Size = new System.Drawing.Size(110, 21);
            this.cbTrangthai.TabIndex = 5;
            // 
            // dgvTiendien
            // 
            this.dgvTiendien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTiendien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiendien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahoadon,
            this.maphong,
            this.ngaylap,
            this.sodientieuthu,
            this.tongtien,
            this.trangthai});
            this.dgvTiendien.Location = new System.Drawing.Point(34, 253);
            this.dgvTiendien.Name = "dgvTiendien";
            this.dgvTiendien.Size = new System.Drawing.Size(487, 200);
            this.dgvTiendien.TabIndex = 11;
            this.dgvTiendien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiendien_CellClick);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbTktheoma);
            this.groupBox1.Controls.Add(this.rbTktheott);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Location = new System.Drawing.Point(573, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 126);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // rbTktheoma
            // 
            this.rbTktheoma.AutoSize = true;
            this.rbTktheoma.Location = new System.Drawing.Point(19, 19);
            this.rbTktheoma.Name = "rbTktheoma";
            this.rbTktheoma.Size = new System.Drawing.Size(141, 17);
            this.rbTktheoma.TabIndex = 0;
            this.rbTktheoma.TabStop = true;
            this.rbTktheoma.Text = "Tìm kiếm theo mã phòng";
            this.rbTktheoma.UseVisualStyleBackColor = true;
            this.rbTktheoma.CheckedChanged += new System.EventHandler(this.rbTktheoma_CheckedChanged);
            // 
            // rbTktheott
            // 
            this.rbTktheott.AutoSize = true;
            this.rbTktheott.Location = new System.Drawing.Point(19, 42);
            this.rbTktheott.Name = "rbTktheott";
            this.rbTktheott.Size = new System.Drawing.Size(138, 17);
            this.rbTktheott.TabIndex = 1;
            this.rbTktheott.TabStop = true;
            this.rbTktheott.Text = "Tìm kiếm theo trạng thái";
            this.rbTktheott.UseVisualStyleBackColor = true;
            this.rbTktheott.CheckedChanged += new System.EventHandler(this.rbTktheott_CheckedChanged);
            // 
            // cbMaphong
            // 
            this.cbMaphong.FormattingEnabled = true;
            this.cbMaphong.Location = new System.Drawing.Point(141, 86);
            this.cbMaphong.Name = "cbMaphong";
            this.cbMaphong.Size = new System.Drawing.Size(110, 21);
            this.cbMaphong.TabIndex = 1;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhtoan.Enabled = false;
            this.btnThanhtoan.Image = global::QuanLyKyTucXa.Properties.Resources.pay;
            this.btnThanhtoan.Location = new System.Drawing.Point(569, 250);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnThanhtoan.Size = new System.Drawing.Size(164, 39);
            this.btnThanhtoan.TabIndex = 12;
            this.btnThanhtoan.Text = "  Thanh toán";
            this.btnThanhtoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.FlatAppearance.BorderSize = 0;
            this.btnCapnhat.Image = global::QuanLyKyTucXa.Properties.Resources.reload;
            this.btnCapnhat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapnhat.Location = new System.Drawing.Point(461, 166);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCapnhat.Size = new System.Drawing.Size(60, 60);
            this.btnCapnhat.TabIndex = 9;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Image = global::QuanLyKyTucXa.Properties.Resources.close;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(319, 166);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnXoa.Size = new System.Drawing.Size(60, 60);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Image = global::QuanLyKyTucXa.Properties.Resources.clipboard;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(177, 166);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnSua.Size = new System.Drawing.Size(60, 60);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(35, 166);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnThem.Size = new System.Drawing.Size(60, 60);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.Image = global::QuanLyKyTucXa.Properties.Resources.search;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.Location = new System.Drawing.Point(19, 74);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnTimkiem.Size = new System.Drawing.Size(137, 37);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // FrmQuanLyTienDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 474);
            this.Controls.Add(this.cbMaphong);
            this.Controls.Add(this.btnThanhtoan);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTiendien);
            this.Controls.Add(this.cbTrangthai);
            this.Controls.Add(this.dtpNgaylap);
            this.Controls.Add(this.txtTiendien);
            this.Controls.Add(this.txtChisomoi);
            this.Controls.Add(this.txtMahoadon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuanLyTienDien";
            this.Text = "Quản lý tiền điện";
            this.Load += new System.EventHandler(this.FrmQuanLyTienDien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMahoadon;
        private System.Windows.Forms.TextBox txtChisomoi;
        private System.Windows.Forms.TextBox txtTiendien;
        private System.Windows.Forms.DateTimePicker dtpNgaylap;
        private System.Windows.Forms.ComboBox cbTrangthai;
        private System.Windows.Forms.DataGridView dgvTiendien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTktheoma;
        private System.Windows.Forms.RadioButton rbTktheott;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.ComboBox cbMaphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodientieuthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}