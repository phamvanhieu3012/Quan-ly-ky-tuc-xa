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
    class BLL_KyLuat
    {
        DAL dal = new DAL();

        public DataTable SelectKyLuat()
        {
            string sql = "Select * from KyLuat";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public void InsertKyLuat(String masv, String kyluat, DateTime ngaykl, float tienphat)
        {
            try
            {
                String sql = "Insert Into KyLuat (masv,kyluat,ngaykyluat,tienphat) values('" + masv + "',N'" + kyluat + "','" + ngaykl.ToString("yyyy-MM-dd") + "','" + tienphat + "')";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã thêm 1 kỷ luật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateKyLuat(String makyluat, String masv, String kyluat, DateTime ngaykl, float tienphat)
        {
            try
            {
                string sql1 = "select makyluat from KyLuat where makyluat = '" + makyluat + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Update KyLuat set masv='" + masv + "' , kyluat = '" + kyluat + "', ngaykyluat = '" + ngaykl.ToString("yyyy-MM-dd") + "', tienphat = '" + tienphat + "' where makyluat = '" + makyluat + "' "; ;
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã kỷ luật", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteKyLuat(String makl)
        {
            try
            {
                string sql1 = "Select makyluat from KyLuat where makyluat = '" + makl + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Delete KyLuat Where makyluat='" + makl + "'";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã kỷ luật", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable SearchKyLuat(String chuoi, String truong)
        {
            string sql = "SELECT * from KyLuat WHERE " + truong + " LIKE N'%" + chuoi + "%'";
            DataTable dt = dal.GetTable(sql);
            return dt;
        }
    }
}
