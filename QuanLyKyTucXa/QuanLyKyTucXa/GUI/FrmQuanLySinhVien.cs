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
    public partial class FrmQuanLySinhVien : Form
    {
        public FrmQuanLySinhVien()
        {
            InitializeComponent();
        }
        BLL.BLL_SinhVien bll = new BLL.BLL_SinhVien();

        private void FormQuanLySinhVien_Load(object sender, EventArgs e)
        {
            cbMaphong.DataSource = bll.SelectMaPhong();
            cbMaphong.ValueMember = "maphong";
            dgvSinhvien.DataSource = bll.SelectSinhVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMasv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            bll.InsertSinhVien(txtMasv.Text, txtTensv.Text, cbGioitinh.Text, dtpNgaysinh.Value, txtQuequan.Text, cbKhoa.Text, txtLop.Text, cbMaphong.Text, cbLoaiuutien.Text);
            btnCapnhat_Click(sender, e);
        }

        private void dgvSinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMasv.Text = dgvSinhvien.Rows[vitri].Cells[0].Value.ToString();
                txtTensv.Text = dgvSinhvien.Rows[vitri].Cells[1].Value.ToString();
                cbGioitinh.Text = dgvSinhvien.Rows[vitri].Cells[2].Value.ToString();
                dtpNgaysinh.Text = dgvSinhvien.Rows[vitri].Cells[3].Value.ToString();
                txtQuequan.Text = dgvSinhvien.Rows[vitri].Cells[4].Value.ToString();
                cbKhoa.Text = dgvSinhvien.Rows[vitri].Cells[5].Value.ToString();
                txtLop.Text = dgvSinhvien.Rows[vitri].Cells[6].Value.ToString();
                cbMaphong.Text = dgvSinhvien.Rows[vitri].Cells[7].Value.ToString();
                cbLoaiuutien.Text = dgvSinhvien.Rows[vitri].Cells[8].Value.ToString();
            }
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
            txtTimkiem.Clear();
            rbTktheoma.Checked = false;
            rbTktheoten.Checked = false;
            rbTkTheoMaphong.Checked = false;
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
            string maphongcu = bll.SelectMaPhongCu(txtMasv.Text).Rows[0][0].ToString();
            bll.UpdateSosvPhong(maphongcu, -1);
            bll.UpdateSinhVien(txtMasv.Text, txtTensv.Text, cbGioitinh.Text, dtpNgaysinh.Value, txtQuequan.Text, cbKhoa.Text, txtLop.Text, cbMaphong.Text, cbLoaiuutien.Text);
            bll.UpdateSosvPhong(cbMaphong.Text, 1);
            btnCapnhat_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMasv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                bll.DeleteSinhVien(txtMasv.Text);
                btnCapnhat_Click(sender, e);
            }
            else if (dlr == DialogResult.No)
                return;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            FormQuanLySinhVien_Load(sender, e);
            ClearBox();
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
                dgvSinhvien.DataSource = bll.SearchSinhVien(txtTimkiem.Text, "masv");
            }
            else if (rbTktheoten.Checked)
            {
                dgvSinhvien.DataSource = bll.SearchSinhVien(txtTimkiem.Text, "tensv");
            }
            else if (rbTkTheoMaphong.Checked)
            {
                dgvSinhvien.DataSource = bll.SearchSinhVien(txtTimkiem.Text, "maphong");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 trường để tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
