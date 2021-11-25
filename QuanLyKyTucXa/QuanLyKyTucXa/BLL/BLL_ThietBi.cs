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
    class BLL_ThietBi
    {
        DAL dal = new DAL();
        public DataTable SelectThietBi(String maphong)
        {
            string sql = "Select * from ThietBi where maphong = '" + maphong + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void InsertThietBi(String maphong, String tenthietbi, String soluong, String tinhtrang)
        {
            try
            {
                String sql = "Insert Into ThietBi values('" + maphong + "',N'" + tenthietbi + "','" + int.Parse(soluong) + "',N'" + tinhtrang + "')";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã thêm 1 thiết bị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateThietBi(String maphong, String tenthietbi, String soluong, String tinhtrang)
        {
            try
            {
                string sql1 = "select maphong from ThietBi where maphong = '" + maphong + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Update ThietBi set tenthietbi=N'" + tenthietbi + "' ,soluong = '" + int.Parse(soluong) + "', tinhtrang = N'" + tinhtrang + "' where maphong = '" + maphong + "' "; ;
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteThietBi(String map, String tentb)
        {
            try
            {
                string sql1 = "Select maphong from ThietBi where maphong = '" + map + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Delete ThietBi Where maphong='" + map + "' AND tenthietbi = '" + tentb + "'";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã phòng hoặc tên thiết bị", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
