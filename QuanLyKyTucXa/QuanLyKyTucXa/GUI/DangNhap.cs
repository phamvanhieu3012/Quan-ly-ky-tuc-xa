using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public bool IsLoggedIn { get; set; }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            BLL.BLL_NguoiDung bll = new BLL.BLL_NguoiDung();
            string sql = "select * from NguoiDung where tendangnhap='" + txtTaikhoan.Text + "' and matkhau='" + txtMatkhau.Text + "'";
            if (dal.login(sql) == true)
            {
                string id = bll.SelectMaNguoiDung(txtTaikhoan.Text, txtMatkhau.Text).Rows[0][0].ToString();
                string quyen = bll.SelectQuyenNguoiDung(txtTaikhoan.Text, txtMatkhau.Text).Rows[0][0].ToString();
                FrmMainMenu frmMainMenu = new FrmMainMenu();
                frmMainMenu.idNguoiDung = id;
                frmMainMenu.quyenNguoiDung = quyen;
                frmMainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //You may decide to prompt to user
            //else just kill
            Process.GetCurrentProcess().Kill();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            DangKyO dangKyO = new DangKyO();
            dangKyO.Show();
        }
    }
}
