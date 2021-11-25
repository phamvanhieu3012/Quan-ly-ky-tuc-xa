namespace QuanLyKyTucXa
{
    partial class FrmQuanLyThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyThietBi));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.txtTentb = new System.Windows.Forms.TextBox();
            this.numericUpDownSoluong = new System.Windows.Forms.NumericUpDown();
            this.txtTinhtrang = new System.Windows.Forms.TextBox();
            this.dgvThietbi = new System.Windows.Forms.DataGridView();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietbi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên thiết bị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng";
            // 
            // txtMaphong
            // 
            this.txtMaphong.Enabled = false;
            this.txtMaphong.Location = new System.Drawing.Point(122, 94);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(100, 20);
            this.txtMaphong.TabIndex = 1;
            // 
            // txtTentb
            // 
            this.txtTentb.Location = new System.Drawing.Point(122, 145);
            this.txtTentb.Name = "txtTentb";
            this.txtTentb.Size = new System.Drawing.Size(100, 20);
            this.txtTentb.TabIndex = 2;
            // 
            // numericUpDownSoluong
            // 
            this.numericUpDownSoluong.Location = new System.Drawing.Point(122, 196);
            this.numericUpDownSoluong.Name = "numericUpDownSoluong";
            this.numericUpDownSoluong.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownSoluong.TabIndex = 3;
            // 
            // txtTinhtrang
            // 
            this.txtTinhtrang.Location = new System.Drawing.Point(122, 247);
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.Size = new System.Drawing.Size(100, 20);
            this.txtTinhtrang.TabIndex = 4;
            // 
            // dgvThietbi
            // 
            this.dgvThietbi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietbi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong,
            this.tenthietbi,
            this.soluong,
            this.tinhtrang});
            this.dgvThietbi.Location = new System.Drawing.Point(267, 94);
            this.dgvThietbi.Name = "dgvThietbi";
            this.dgvThietbi.Size = new System.Drawing.Size(437, 231);
            this.dgvThietbi.TabIndex = 9;
            this.dgvThietbi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThietbi_CellClick);
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.Name = "maphong";
            // 
            // tenthietbi
            // 
            this.tenthietbi.DataPropertyName = "tenthietbi";
            this.tenthietbi.HeaderText = "Tên thiết bị";
            this.tenthietbi.Name = "tenthietbi";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.Name = "tinhtrang";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.bntMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 60);
            this.panel1.TabIndex = 21;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // bntMinimize
            // 
            this.bntMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bntMinimize.FlatAppearance.BorderSize = 0;
            this.bntMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bntMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMinimize.Location = new System.Drawing.Point(623, 8);
            this.bntMinimize.Name = "bntMinimize";
            this.bntMinimize.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.bntMinimize.Size = new System.Drawing.Size(33, 33);
            this.bntMinimize.TabIndex = 5;
            this.bntMinimize.Text = "-";
            this.bntMinimize.UseVisualStyleBackColor = true;
            this.bntMinimize.Click += new System.EventHandler(this.bntMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.Location = new System.Drawing.Point(662, 8);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnMaximize.Size = new System.Drawing.Size(33, 33);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.Text = "☐";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(701, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(33, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(299, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Quản lý thiết bị";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapnhat.FlatAppearance.BorderSize = 0;
            this.btnCapnhat.Image = global::QuanLyKyTucXa.Properties.Resources.reload;
            this.btnCapnhat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapnhat.Location = new System.Drawing.Point(642, 350);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCapnhat.Size = new System.Drawing.Size(60, 60);
            this.btnCapnhat.TabIndex = 8;
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
            this.btnXoa.Location = new System.Drawing.Point(552, 350);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnXoa.Size = new System.Drawing.Size(60, 60);
            this.btnXoa.TabIndex = 7;
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
            this.btnSua.Location = new System.Drawing.Point(462, 350);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnSua.Size = new System.Drawing.Size(60, 60);
            this.btnSua.TabIndex = 6;
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
            this.btnThem.Location = new System.Drawing.Point(372, 350);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnThem.Size = new System.Drawing.Size(60, 60);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmQuanLyThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvThietbi);
            this.Controls.Add(this.numericUpDownSoluong);
            this.Controls.Add(this.txtTinhtrang);
            this.Controls.Add(this.txtTentb);
            this.Controls.Add(this.txtMaphong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmQuanLyThietBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuanLyThietBi";
            this.Load += new System.EventHandler(this.FrmQuanLyThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietbi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.TextBox txtTentb;
        private System.Windows.Forms.NumericUpDown numericUpDownSoluong;
        private System.Windows.Forms.TextBox txtTinhtrang;
        private System.Windows.Forms.DataGridView dgvThietbi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
    }
}