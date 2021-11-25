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
    public partial class FrmQuanLyPhong : Form
    {
        public FrmQuanLyPhong()
        {
            InitializeComponent();
        }
        BLL.BLL_Phong bll = new BLL.BLL_Phong();
        BLL.BLL_Day bllDay = new BLL.BLL_Day();
        private void FrmQuanLyPhong_Load(object sender, EventArgs e)
        {
            cbDay.DataSource = bllDay.SelectMaDay();
            cbDay.ValueMember = "maday";
            dgvPhong.DataSource = bll.SelectPhong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int soluong = int.Parse(txtSosvtoida.Text);
                if (soluong < 0) throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng sinh viên phải là số lớn hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMaphong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtTenphong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên phòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtSosvtoida.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số sinh viên tối đa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbLoaiphong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn loại phòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbXeploai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn xếp loại phòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbDay.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dãy của phòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bll.InsertPhong(txtMaphong.Text, txtTenphong.Text, txtSosvtoida.Text, cbLoaiphong.Text, cbXeploai.Text, cbDay.Text);
            btnCapnhat_Click(sender, e);
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMaphong.Text = dgvPhong.Rows[vitri].Cells[0].Value.ToString();
                txtTenphong.Text = dgvPhong.Rows[vitri].Cells[1].Value.ToString();
                txtSosvhientai.Text = dgvPhong.Rows[vitri].Cells[2].Value.ToString();
                txtSosvtoida.Text = dgvPhong.Rows[vitri].Cells[3].Value.ToString();
                txtTinhtrang.Text = dgvPhong.Rows[vitri].Cells[4].Value.ToString();
                cbLoaiphong.Text = dgvPhong.Rows[vitri].Cells[5].Value.ToString();
                cbXeploai.Text = dgvPhong.Rows[vitri].Cells[6].Value.ToString();
                cbDay.Text = dgvPhong.Rows[vitri].Cells[7].Value.ToString();
            }
        }

        private void ClearBox()
        {
            txtMaphong.Clear();
            txtTenphong.Clear();
            txtSosvhientai.Clear();
            txtSosvtoida.Clear();
            txtTinhtrang.Clear();
            cbLoaiphong.Text = "";
            cbXeploai.Text = "";
            cbDay.Text = "";
            txtTimkiem.Clear();
            rbTktheoma.Checked = false;
            rbTktheoten.Checked = false;
            rbTkTheoMaday.Checked = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaphong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtTenphong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên phòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtSosvtoida.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số sinh viên tối đa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbLoaiphong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn loại phòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbXeploai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn xếp loại phòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbDay.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dãy của phòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int soluong = int.Parse(txtSosvtoida.Text);
                if (soluong < 0) throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng sinh viên phải là số lớn hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int soluong = int.Parse(txtSosvhientai.Text);
                int soluong2 = int.Parse(txtSosvtoida.Text);
                if (soluong > soluong2) throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng sinh viên hiện tại phải nhỏ hơn số lượng tối đa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bll.UpdatePhong(txtMaphong.Text, txtTenphong.Text, int.Parse(txtSosvhientai.Text), int.Parse(txtSosvtoida.Text), cbLoaiphong.Text, cbXeploai.Text, cbDay.Text);
            btnCapnhat_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaphong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                bll.DeletePhong(txtMaphong.Text);
                btnCapnhat_Click(sender, e);
            }
            else if (dlr == DialogResult.No)
                return;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            FrmQuanLyPhong_Load(sender, e);
            checkBox1.Checked = false;
            ClearBox();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập trường tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbTktheoma.Checked)
            {
                dgvPhong.DataSource = bll.SearchPhong(txtTimkiem.Text, "maphong");
            }
            else if (rbTktheoten.Checked)
            {
                dgvPhong.DataSource = bll.SearchPhong(txtTimkiem.Text, "tenphong");
            }
            else if (rbTkTheoMaday.Checked)
            {
                dgvPhong.DataSource = bll.SearchPhong(txtTimkiem.Text, "day");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 trường để tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                dgvPhong.DataSource = bll.SelectPhongTrong();
            else
                dgvPhong.DataSource = bll.SelectPhong();
        }

        private void dgvPhong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            string map = dgvPhong.Rows[vitri].Cells[0].Value.ToString();
            FrmQuanLyThietBi frm = new FrmQuanLyThietBi();
            frm.maphongnhan = map;
            frm.Show();
        }
    }
}
