using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa
{
    public partial class FrmQuanLyNguoiDung : Form
    {
        public FrmQuanLyNguoiDung()
        {
            InitializeComponent();
        }
        BLL.BLL_NguoiDung bll = new BLL.BLL_NguoiDung();
        BLL_NhanVien bllNv = new BLL_NhanVien();
        private void QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            cbManv.DataSource = bllNv.SelectMaNhanVien();
            cbManv.DisplayMember = "Chọn";
            cbManv.ValueMember = "manv";
            dgvNguoidung.DataSource = bll.SelectNguoiDung();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbManv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtTendangnhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhâp mật khẩu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbQuyen.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn quyền!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bll.InsertNguoiDung(cbManv.Text, txtTendangnhap.Text, txtMatkhau.Text, cbQuyen.Text);
            btnCapnhat_Click(sender, e);
        }

        private void dgvNguoidung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtId.Text = dgvNguoidung.Rows[vitri].Cells[0].Value.ToString();
                cbManv.Text = dgvNguoidung.Rows[vitri].Cells[1].Value.ToString();
                txtTendangnhap.Text = dgvNguoidung.Rows[vitri].Cells[2].Value.ToString();
                txtMatkhau.Text = dgvNguoidung.Rows[vitri].Cells[3].Value.ToString();
                cbQuyen.Text = dgvNguoidung.Rows[vitri].Cells[4].Value.ToString();
            }
        }

        private void ClearBox()
        {
            txtId.Clear();
            cbManv.Text = "";
            txtTendangnhap.Clear();
            txtMatkhau.Clear();
            cbQuyen.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbManv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtTendangnhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhâp mật khẩu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbQuyen.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn quyền!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bll.UpdateNguoiDung(txtId.Text, cbManv.Text, txtTendangnhap.Text, txtMatkhau.Text, cbQuyen.Text);
            btnCapnhat_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                bll.DeleteNguoiDung(txtId.Text);
                btnCapnhat_Click(sender, e);
            }
            else if (dlr == DialogResult.No)
                return;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            QuanLyNguoiDung_Load(sender, e);
            ClearBox();
            cbManv.Enabled = true;
            txtTendangnhap.Enabled = true;
            txtMatkhau.Enabled = true;
            cbQuyen.Enabled = true;
            rbManv.Checked = false;
            rbTendangnhap.Checked = false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (rbManv.Checked)
            {
                if (cbManv.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã người dùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgvNguoidung.DataSource = bll.SearchNguoiDung(cbManv.Text, "manv");
            }
            else if (rbTendangnhap.Checked)
            {
                if (txtTendangnhap.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgvNguoidung.DataSource = bll.SearchNguoiDung(txtTendangnhap.Text, "tendangnhap");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 trường để tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void rbManv_CheckedChanged_1(object sender, EventArgs e)
        {
            cbManv.Enabled = true;
            txtTendangnhap.Enabled = false;
            txtMatkhau.Enabled = false;
            cbQuyen.Enabled = false;
        }

        private void rbTendangnhap_CheckedChanged_1(object sender, EventArgs e)
        {
            cbManv.Enabled = false;
            txtTendangnhap.Enabled = true;
            txtMatkhau.Enabled = false;
            cbQuyen.Enabled = false;
        }
    }
}
