using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;
using System.Runtime.InteropServices;

namespace QuanLyKyTucXa
{
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void btnSinhvien_Click(object sender, EventArgs e)
        {
            FrmBaoCaoSV frmBaoCaoSv = new FrmBaoCaoSV();
            frmBaoCaoSv.Show();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            FrmBaoCaoPhong frmBaoCaoPhong = new FrmBaoCaoPhong();
            frmBaoCaoPhong.Show();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            BaoCao.FrmBaoCaoNhanVien frm = new BaoCao.FrmBaoCaoNhanVien();
            frm.Show();
        }
    }
}
