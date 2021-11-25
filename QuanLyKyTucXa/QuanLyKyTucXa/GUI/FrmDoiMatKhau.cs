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
    public partial class FrmDoiMatKhau : Form
    {
        public string id = "";
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }
        BLL.BLL_NguoiDung bll = new BLL.BLL_NguoiDung();

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (txtMatkhaucu.Text != bll.SelectMatKhauCu(id).Rows[0][0].ToString())
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMatkhaumoi.Text != txtNhaplai.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bll.UpdateMatKhau(id, txtMatkhaumoi.Text);
            this.Close();
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
