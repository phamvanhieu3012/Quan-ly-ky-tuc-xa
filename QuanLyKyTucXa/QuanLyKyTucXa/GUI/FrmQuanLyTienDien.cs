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
    public partial class FrmQuanLyTienDien : Form
    {
        public FrmQuanLyTienDien()
        {
            InitializeComponent();
        }
        //Methods
        private float tinhTienDien(int sodien)
        {
            float tongTien = 0;
            float chiSo = 3000;

            tongTien += chiSo * sodien;

            return tongTien;
        }

        BLL.BLL_TienDien bll = new BLL.BLL_TienDien();
        BLL.BLL_Phong bllPhong = new BLL.BLL_Phong();

        private void FrmQuanLyTienDien_Load(object sender, EventArgs e)
        {
            cbMaphong.DataSource = bllPhong.SelectMaPhong();
            cbMaphong.DisplayMember = "Chọn";
            cbMaphong.ValueMember = "maphong";
            dgvTiendien.DataSource = bll.SelectTienDien();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            FrmQuanLyTienDien_Load(sender, e);
            ClearBox();
            cbMaphong.Enabled = true;
            dtpNgaylap.Enabled = true;
            txtChisomoi.Enabled = true;
            cbTrangthai.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int soluong = int.Parse(txtChisomoi.Text);
                if (soluong < 0) throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Chỉ số điện phải là số lớn hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbMaphong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã phòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbTrangthai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn trạng thái!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int chiSoCu = int.Parse(bll.SelectChiSoCu(cbMaphong.Text).Rows[0][0].ToString());
            if (int.Parse(txtChisomoi.Text) < chiSoCu)
            {
                MessageBox.Show("Chỉ số mới phải lớn hơn chỉ số cũ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int sodien = int.Parse(txtChisomoi.Text) - chiSoCu;
            bll.UpdateChiSoCuTang(cbMaphong.Text, int.Parse(txtChisomoi.Text));
            bll.InsertTienDien(cbMaphong.Text, dtpNgaylap.Value, sodien, tinhTienDien(sodien), cbTrangthai.Text);
            btnCapnhat_Click(sender, e); ;
        }

        private void dgvTiendien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMahoadon.Text = dgvTiendien.Rows[vitri].Cells[0].Value.ToString();
                cbMaphong.Text = dgvTiendien.Rows[vitri].Cells[1].Value.ToString();
                dtpNgaylap.Text = dgvTiendien.Rows[vitri].Cells[2].Value.ToString();
                //txtChisomoi.Text = dgvTiendien.Rows[vitri].Cells[4].Value.ToString();
                cbTrangthai.Text = dgvTiendien.Rows[vitri].Cells[5].Value.ToString();
                if (cbTrangthai.Text == "Chưa thanh toán")
                    btnThanhtoan.Enabled = true;
                else
                    btnThanhtoan.Enabled = false;
                //if (cbTrangthai.Text == "Đã thanh toán")
                //btnThanhtoan.Enabled = false;
            }
        }

        private void ClearBox()
        {
            txtMahoadon.Clear();
            cbMaphong.Text = "";
            dtpNgaylap.Value = DateTime.Now;
            txtChisomoi.Clear();
            cbTrangthai.Text = "";
            rbTktheoma.Checked = false;
            rbTktheott.Checked = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMahoadon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbMaphong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã phòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbTrangthai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn trạng thái!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int sodien = int.Parse(bll.SelectSoDien(txtMahoadon.Text).Rows[0][0].ToString());
            if (txtChisomoi.Text.Trim() != "")
            {
                bll.UpdateChiSoCuGiam(cbMaphong.Text, sodien);
                int chiSoCu = int.Parse(bll.SelectChiSoCu(cbMaphong.Text).Rows[0][0].ToString());
                if (int.Parse(txtChisomoi.Text) < chiSoCu)
                {
                    MessageBox.Show("Chỉ số mới phải lớn hơn chỉ số cũ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int sodientieuthu = int.Parse(txtChisomoi.Text) - chiSoCu;
                bll.UpdateChiSoCuTang(cbMaphong.Text, sodientieuthu);
                //int sodiencu = int.Parse(bll.SelectChiSoCu(cbMaphong.Text).ToString());
                //if(sodien > sodiencu)
                //{
                //bll.UpdateChiSoCuTang(cbMaphong.Text,)
                //}
                bll.UpdateTienDien(txtMahoadon.Text, cbMaphong.Text, dtpNgaylap.Value, sodientieuthu, tinhTienDien(sodientieuthu), cbTrangthai.Text);
            }
            else
            {
                bll.UpdateTienDien(txtMahoadon.Text, cbMaphong.Text, dtpNgaylap.Value, sodien, tinhTienDien(sodien), cbTrangthai.Text);
            }

            btnCapnhat_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMahoadon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int sodien = int.Parse(bll.SelectSoDien(txtMahoadon.Text).Rows[0][0].ToString());
                bll.UpdateChiSoCuGiam(cbMaphong.Text, sodien);
                bll.DeleteTienDien(txtMahoadon.Text);
                btnCapnhat_Click(sender, e);
            }
            else if (dlr == DialogResult.No)
                return;
        }

        private void rbTktheoma_CheckedChanged(object sender, EventArgs e)
        {
            cbMaphong.Enabled = true;
            dtpNgaylap.Enabled = false;
            txtChisomoi.Enabled = false;
            cbTrangthai.Enabled = false;
        }

        private void rbTktheott_CheckedChanged(object sender, EventArgs e)
        {
            cbMaphong.Enabled = false;
            dtpNgaylap.Enabled = false;
            txtChisomoi.Enabled = false;
            cbTrangthai.Enabled = true;
        }

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            bll.UpdateTrangThai(txtMahoadon.Text, "Hoàn thành");
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (rbTktheoma.Checked)
            {
                if (cbMaphong.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvTiendien.DataSource = bll.SearchTienDien(cbMaphong.Text, "maphong");
            }
            else if (rbTktheott.Checked)
            {
                if (cbTrangthai.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn trạng thái tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvTiendien.DataSource = bll.SearchTienDien(cbTrangthai.Text, "trangthai");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 trường để tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            bll.UpdateTrangThai(txtMahoadon.Text, "Đã thanh toán");
            FrmQuanLyTienDien_Load(sender, e);
        }
    }
}
