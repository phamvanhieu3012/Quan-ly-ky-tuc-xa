using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKyTucXa.BLL
{
    class BLL_ThongKe
    {
        DAL dal = new DAL();
        public DataTable luongDienTieuThuThang(int nam, int thang)
        {
            String sql = "select sum(sodientieuthu) from TienDien where YEAR(ngaylap) = '" + nam + "' and MONTH(ngaylap) = '" + thang + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}
