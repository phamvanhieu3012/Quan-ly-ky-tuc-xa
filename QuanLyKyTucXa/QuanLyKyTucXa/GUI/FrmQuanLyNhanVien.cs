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
    public partial class FrmQuanLyNhanVien : Form
    {
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        BLL_NhanVien bll = new BLL_NhanVien();
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanvien.DataSource = bll.SelectNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int soluong = int.Parse(txtHesoluong.Text);
                if (soluong < 0) throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Hệ số lương phải là số lớn hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtManv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtTennv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbGioitinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giới tính!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn địa chỉ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtSodienthoai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn số điện thoại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtHesoluong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập hệ số lương!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bll.InsertNhanVien(txtManv.Text, txtTennv.Text, cbGioitinh.Text, dtpNgaysinh.Value, txtDiachi.Text, txtSodienthoai.Text, float.Parse(txtHesoluong.Text));
            btnCapnhat_Click(sender, e);
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtManv.Text = dgvNhanvien.Rows[vitri].Cells[0].Value.ToString();
                txtTennv.Text = dgvNhanvien.Rows[vitri].Cells[1].Value.ToString();
                cbGioitinh.Text = dgvNhanvien.Rows[vitri].Cells[2].Value.ToString();
                dtpNgaysinh.Text = dgvNhanvien.Rows[vitri].Cells[3].Value.ToString();
                txtDiachi.Text = dgvNhanvien.Rows[vitri].Cells[4].Value.ToString();
                txtSodienthoai.Text = dgvNhanvien.Rows[vitri].Cells[5].Value.ToString();
                txtHesoluong.Text = dgvNhanvien.Rows[vitri].Cells[6].Value.ToString();
            }
        }

        private void ClearBox()
        {
            txtManv.Clear();
            txtTennv.Clear();
            cbGioitinh.Text = "Nam";
            dtpNgaysinh.Value = DateTime.Now;
            txtDiachi.Clear();
            txtSodienthoai.Clear();
            txtHesoluong.Clear();
            txtTimkiem.Clear();
            rbTktheoma.Checked = false;
            rbTktheoten.Checked = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtManv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtTennv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbGioitinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giới tính!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn địa chỉ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtSodienthoai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn số điện thoại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtHesoluong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập hệ số lương!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bll.UpdateNhanVien(txtManv.Text, txtTennv.Text, cbGioitinh.Text, dtpNgaysinh.Value, txtDiachi.Text, txtSodienthoai.Text, float.Parse(txtHesoluong.Text));
            btnCapnhat_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtManv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                bll.DeleteNhanVien(txtManv.Text);
                btnCapnhat_Click(sender, e);
            }
            else if (dlr == DialogResult.No)
                return;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập trường tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbTktheoma.Checked)
            {
                dgvNhanvien.DataSource = bll.SearchNhanVien(txtTimkiem.Text, "manv");
            }
            else if (rbTktheoten.Checked)
            {
                dgvNhanvien.DataSource = bll.SearchNhanVien(txtTimkiem.Text, "tennv");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 trường để tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien_Load(sender, e);
            ClearBox();
        }
    }
}
