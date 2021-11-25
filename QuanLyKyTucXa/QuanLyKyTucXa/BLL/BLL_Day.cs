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
    class BLL_Day
    {
        DAL dal = new DAL();
        public DataTable SelectDay()
        {
            string sql = "Select * from Day";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable SelectMaDay()
        {
            string sql = "Select maday from Day";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void InsertDay(String maday, String tenday, String quanly, String trangthai)
        {
            try
            {
                String sql = "Insert Into Day values('" + maday + "',N'" + tenday + "',N'" + quanly + "',N'" + trangthai + "')";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã thêm 1 dãy thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {

                if (ex.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("Mã dãy không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateDay(String maday, String tenday, String quanly, String trangthai)
        {
            try
            {
                string sql1 = "select maday from Day where maday = '" + maday + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Update Day set tenday='" + tenday + "' ,quanly = N'" + quanly + "', trangthai = N'" + trangthai + "' where maday = '" + maday + "' "; ;
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã dãy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteDay(String maday)
        {
            try
            {
                string sql1 = "Select maday from Day where maday = '" + maday + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Delete Day Where maday='" + maday + "'";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã dãy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable SearchKyLuat(String chuoi, String truong)
        {
            string sql = "SELECT * from Day WHERE " + truong + " LIKE N'%" + chuoi + "%'";
            DataTable dt = dal.GetTable(sql);
            return dt;
        }
    }
}
