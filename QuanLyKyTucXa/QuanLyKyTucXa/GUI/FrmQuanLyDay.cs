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
    public partial class FrmQuanLyDay : Form
    {
        public FrmQuanLyDay()
        {
            InitializeComponent();
        }

        BLL.BLL_Day bll = new BLL.BLL_Day();
        BLL_NhanVien bllNhanvien = new BLL_NhanVien();
        private void FrmQuanLyDay_Load(object sender, EventArgs e)
        {
            cbQuanly.DataSource = bllNhanvien.SelectTenNhanVien();
            cbQuanly.ValueMember = "tennv";
            dgvDay.DataSource = bll.SelectDay();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaday.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtTenday.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên dãy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbQuanly.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tên người quản lý!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bll.InsertDay(txtMaday.Text, txtTenday.Text, cbQuanly.Text, txtTrangthai.Text);
            btnCapnhat_Click(sender, e);
        }

        private void dgvDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMaday.Text = dgvDay.Rows[vitri].Cells[0].Value.ToString();
                txtTenday.Text = dgvDay.Rows[vitri].Cells[1].Value.ToString();
                cbQuanly.Text = dgvDay.Rows[vitri].Cells[2].Value.ToString();
                txtTrangthai.Text = dgvDay.Rows[vitri].Cells[3].Value.ToString();
            }
        }

        private void ClearBox()
        {
            txtMaday.Clear();
            cbQuanly.Text = "";
            txtTenday.Clear();
            txtTrangthai.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenday.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtTenday.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên dãy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbQuanly.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tên người quản lý!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bll.UpdateDay(txtMaday.Text, txtTenday.Text, cbQuanly.Text, txtTrangthai.Text);
            btnCapnhat_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaday.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                bll.DeleteDay(txtMaday.Text);
                btnCapnhat_Click(sender, e);
            }
            else if (dlr == DialogResult.No)
                return;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            FrmQuanLyDay_Load(sender, e);
            ClearBox();
        }
    }
}
