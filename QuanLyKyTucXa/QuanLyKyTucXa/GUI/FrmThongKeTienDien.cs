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
    public partial class FrmThongKeTienDien : Form
    {
        public FrmThongKeTienDien()
        {
            InitializeComponent();
        }
        BLL.BLL_ThongKe BLL_ThongKe = new BLL.BLL_ThongKe();

        private void fillchart_thang(int nam)
        {
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Lượng điện tiêu thụ";
            chart1.Series["Lượng điện"].Points.Clear();
            DataTable dt = new DataTable();
            float luongdien = 0;
            int n = 12;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = 12;
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            for (int i = 1; i <= n; i++)
            {
                luongdien = 0;
                dt = BLL_ThongKe.luongDienTieuThuThang(nam, i);
                if (dt.Rows[0][0].ToString() != "") luongdien = float.Parse(dt.Rows[0][0].ToString());
                chart1.Series["Lượng điện"].Points.AddXY(i.ToString(), luongdien.ToString());
            }
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            fillchart_thang(2021);
        }

        private void FrmThongKeTienDien_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
        }
    }
}
