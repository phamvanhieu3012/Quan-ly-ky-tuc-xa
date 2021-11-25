namespace QuanLyKyTucXa
{
    partial class FrmBaoCao
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
            this.btnSinhvien = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnTiendien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSinhvien
            // 
            this.btnSinhvien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSinhvien.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSinhvien.FlatAppearance.BorderSize = 0;
            this.btnSinhvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhvien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSinhvien.Location = new System.Drawing.Point(116, 59);
            this.btnSinhvien.Name = "btnSinhvien";
            this.btnSinhvien.Size = new System.Drawing.Size(149, 58);
            this.btnSinhvien.TabIndex = 0;
            this.btnSinhvien.Text = "Sinh Viên";
            this.btnSinhvien.UseVisualStyleBackColor = true;
            this.btnSinhvien.Click += new System.EventHandler(this.btnSinhvien_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPhong.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPhong.FlatAppearance.BorderSize = 0;
            this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.ForeColor = System.Drawing.Color.White;
            this.btnPhong.Location = new System.Drawing.Point(410, 59);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(149, 58);
            this.btnPhong.TabIndex = 0;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.UseVisualStyleBackColor = false;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNhanvien.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNhanvien.FlatAppearance.BorderSize = 0;
            this.btnNhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanvien.ForeColor = System.Drawing.Color.White;
            this.btnNhanvien.Location = new System.Drawing.Point(116, 166);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(149, 58);
            this.btnNhanvien.TabIndex = 0;
            this.btnNhanvien.Text = "Nhân viên";
            this.btnNhanvien.UseVisualStyleBackColor = false;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnTiendien
            // 
            this.btnTiendien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTiendien.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTiendien.FlatAppearance.BorderSize = 0;
            this.btnTiendien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiendien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiendien.ForeColor = System.Drawing.Color.White;
            this.btnTiendien.Location = new System.Drawing.Point(410, 166);
            this.btnTiendien.Name = "btnTiendien";
            this.btnTiendien.Size = new System.Drawing.Size(149, 58);
            this.btnTiendien.TabIndex = 0;
            this.btnTiendien.Text = "Tiền điện";
            this.btnTiendien.UseVisualStyleBackColor = false;
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 303);
            this.Controls.Add(this.btnTiendien);
            this.Controls.Add(this.btnNhanvien);
            this.Controls.Add(this.btnPhong);
            this.Controls.Add(this.btnSinhvien);
            this.Name = "FrmBaoCao";
            this.Text = "Xuất Excel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSinhvien;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button btnTiendien;
    }
}