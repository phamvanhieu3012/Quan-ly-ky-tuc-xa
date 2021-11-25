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
    class BLL_TienDien
    {
        DAL dal = new DAL();

        public DataTable SelectTienDien()
        {
            string sql = "Select * from TienDien";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public DataTable SelectSoDien(string mahoadon)
        {
            string sql = "Select sodientieuthu from TienDien where mahoadon = '" + mahoadon + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public DataTable SelectChiSoCu(String map)
        {
            string sql = "Select chisocu from Phong where maphong = '" + map + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public void UpdateChiSoCuTang(string map, int sodientieuthu)
        {
            try
            {
                string sql1 = "select maphong from Phong where maphong = '" + map + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Update Phong set chisocu = chisocu + '" + sodientieuthu + "' where maphong = '" + map + "' "; ;
                dal.ExecNonQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateChiSoCuGiam(string map, int sodientieuthu)
        {
            try
            {
                string sql1 = "select maphong from Phong where maphong = '" + map + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Update Phong set chisocu = chisocu - '" + sodientieuthu + "' where maphong = '" + map + "' "; ;
                dal.ExecNonQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateTrangThai(string mahd, string trangthai)
        {
            try
            {
                string sql1 = "select mahoadon from TienDien where mahoadon = '" + mahd + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Update TienDien set trangthai = N'" + trangthai + "' where mahoadon = '" + mahd + "' "; ;
                dal.ExecNonQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã hóa đơn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertTienDien(String maphong, DateTime ngaylap, int sodien, float tongtien, String trangthai)
        {
            try
            {
                String sql = "Insert Into TienDien (maphong,ngaylap,sodientieuthu,tongtien,trangthai) values('" + maphong + "','" + ngaylap.ToString("yyyy-MM-dd") + "','" + sodien + "','" + tongtien + "',N'" + trangthai + "')";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã thêm 1 hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateTienDien(String mahoadon, String maphong, DateTime ngaylap, int sodien, float tongtien, String trangthai)
        {
            try
            {
                string sql1 = "select mahoadon from TienDien where mahoadon = '" + mahoadon + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Update TienDien set maphong='" + maphong + "' , ngaylap = '" + ngaylap.ToString("yyyy-MM-dd") + "',sodientieuthu = '" + sodien + "', tongtien = '" + tongtien + "', trangthai = N'" + trangthai + "' where mahoadon = '" + mahoadon + "' "; ;
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã hóa đơn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteTienDien(String mahoadon)
        {
            try
            {
                string sql1 = "Select mahoadon from TienDien where mahoadon = '" + mahoadon + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Delete TienDien Where mahoadon='" + mahoadon + "'";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã hóa đơn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable SearchTienDien(String chuoi, String truong)
        {
            string sql = "SELECT * from TienDien WHERE " + truong + " LIKE N'%" + chuoi + "%'";
            DataTable dt = dal.GetTable(sql);
            return dt;
        }
    }
}
