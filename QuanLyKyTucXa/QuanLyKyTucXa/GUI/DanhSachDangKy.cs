using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa
{
    public partial class DanhSachDangKy : Form
    {
        public DanhSachDangKy()
        {
            InitializeComponent();
        }
        BLL.BLL_SinhVien bLL_SinhVien = new BLL.BLL_SinhVien();
        BLL.BLL_SvDangKy BLL_SvDangKy = new BLL.BLL_SvDangKy();

        private void DanhSachDangKy_Load(object sender, EventArgs e)
        {
            cbMaphong.DataSource = bLL_SinhVien.SelectMaPhong();
            cbMaphong.ValueMember = "maphong";
            dgvSvDangKy.DataSource = BLL_SvDangKy.SelectSinhVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (BLL_SvDangKy.KiemTraPhongDay(cbMaphong.Text) == true)
            {
                MessageBox.Show("Phòng này đã đầy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BLL_SvDangKy.InsertSinhVien(txtMasv.Text, txtTensv.Text, cbGioitinh.Text, dtpNgaysinh.Value, txtQuequan.Text, cbKhoa.Text, txtLop.Text, cbMaphong.Text, cbLoaiuutien.Text);
            btnCapnhat_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BLL_SvDangKy.DeleteSinhVienDangKy(txtMasv.Text);
            btnCapnhat_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMasv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtTensv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbGioitinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giới tính!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtQuequan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập quê quán!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbKhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khóa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtLop.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lớp!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbMaphong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã phòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbLoaiuutien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn loại ưu tiên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BLL_SvDangKy.UpdateSinhVienDangKy(txtMasv.Text, txtTensv.Text, cbGioitinh.Text, dtpNgaysinh.Value, txtQuequan.Text, cbKhoa.Text, txtLop.Text, cbMaphong.Text, cbLoaiuutien.Text);
            btnCapnhat_Click(sender, e);
        }

        private void ClearBox()
        {
            txtMasv.Clear();
            txtTensv.Clear();
            cbGioitinh.Text = "";
            dtpNgaysinh.Value = DateTime.Now;
            txtQuequan.Clear();
            cbKhoa.Text = "";
            txtLop.Clear();
            cbMaphong.Text = "";
            cbLoaiuutien.Text = "";
        }

        private void dgvSvDangKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMasv.Text = dgvSvDangKy.Rows[vitri].Cells[0].Value.ToString();
                txtTensv.Text = dgvSvDangKy.Rows[vitri].Cells[1].Value.ToString();
                cbGioitinh.Text = dgvSvDangKy.Rows[vitri].Cells[2].Value.ToString();
                dtpNgaysinh.Text = dgvSvDangKy.Rows[vitri].Cells[3].Value.ToString();
                txtQuequan.Text = dgvSvDangKy.Rows[vitri].Cells[4].Value.ToString();
                cbKhoa.Text = dgvSvDangKy.Rows[vitri].Cells[5].Value.ToString();
                txtLop.Text = dgvSvDangKy.Rows[vitri].Cells[6].Value.ToString();
                cbMaphong.Text = dgvSvDangKy.Rows[vitri].Cells[7].Value.ToString();
                cbLoaiuutien.Text = dgvSvDangKy.Rows[vitri].Cells[8].Value.ToString();
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            DanhSachDangKy_Load(sender, e);
            ClearBox();
        }
    }
}
