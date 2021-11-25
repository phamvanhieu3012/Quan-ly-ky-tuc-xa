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
    public delegate void SendMessage(String value);
    public partial class FrmQuanLyThietBi : Form
    {
        public string maphongnhan = "";
        public FrmQuanLyThietBi()
        {
            InitializeComponent();
        }
        BLL.BLL_ThietBi bll = new BLL.BLL_ThietBi();

        private void FrmQuanLyThietBi_Load(object sender, EventArgs e)
        {
            txtMaphong.Text = maphongnhan;
            dgvThietbi.DataSource = bll.SelectThietBi(txtMaphong.Text);
            this.ControlBox = false;
            this.Text = "";
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int soluong = int.Parse(numericUpDownSoluong.Value.ToString());
                if (soluong < 0) throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng phải là số lớn hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTentb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên thiết bị!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bll.InsertThietBi(txtMaphong.Text, txtTentb.Text, numericUpDownSoluong.Value.ToString(), txtTinhtrang.Text);
            btnCapnhat_Click(sender, e);
        }

        private void dgvThietbi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtTentb.Text = dgvThietbi.Rows[vitri].Cells[1].Value.ToString();
                numericUpDownSoluong.Value = Decimal.Parse(dgvThietbi.Rows[vitri].Cells[2].Value.ToString());
                txtTinhtrang.Text = dgvThietbi.Rows[vitri].Cells[3].Value.ToString();
            }
        }

        private void ClearBox()
        {
            txtTentb.Clear();
            numericUpDownSoluong.Value = 0;
            txtTinhtrang.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int soluong = int.Parse(numericUpDownSoluong.Value.ToString());
                if (soluong < 0) throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng phải là số lớn hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTentb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên thiết bị!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMaphong.Text == "" || txtTentb.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bll.UpdateThietBi(txtMaphong.Text, txtTentb.Text, numericUpDownSoluong.Value.ToString(), txtTinhtrang.Text);
            btnCapnhat_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaphong.Text == "" || txtTentb.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                bll.DeleteThietBi(txtMaphong.Text, txtTentb.Text);
                btnCapnhat_Click(sender, e);
            }
            else if (dlr == DialogResult.No)
                return;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            FrmQuanLyThietBi_Load(sender, e);
            ClearBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        //Kéo giao diện
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
