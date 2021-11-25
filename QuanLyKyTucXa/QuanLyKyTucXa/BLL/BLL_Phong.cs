using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKyTucXa.BLL
{
    class BLL_Phong
    {
        DAL dal = new DAL();
        public DataTable SelectPhong()
        {
            string sql = "Select maphong,tenphong,sosv,sosvtoida,tinhtrang,loaiphong,xeploai,day from Phong";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public DataTable SelectMaPhong()
        {
            string sql = "select maphong from Phong";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public DataTable SelectSinhVienTrongPhong(string map)
        {
            string sql = "Select * from SinhVien where maphong = '" + map + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public DataTable SelectPhongTrong()
        {
            string tinhtrang = "Thiếu";
            string sql = "Select * from Phong where tinhtrang = N'" + tinhtrang + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public DataTable SelectSoSvHienTai(String map)
        {
            string sql = "Select COUNT(*) from SinhVien where maphong = '" + map + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public void InsertPhong(String map, String tenp, String sosvtd, String loaiphong, String xeploai, String maday)
        {
            try
            {
                int sosvhientai = 0;
                int sosvtoida = int.Parse(sosvtd);
                string tinhtrang = "Thiếu";
                String sql = "insert into Phong values('" + map + "',N'" + tenp + "','" + sosvhientai + "','" + sosvtd + "',N'" + tinhtrang + "',N'" + loaiphong + "',N'" + xeploai + "','" + maday + "', 0)";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã thêm phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {

                if (ex.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("Mã phòng không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdatePhong(String map, String tenp, int sosv, int sosvtd, String loaiphong, String xeploai, String maday)
        {
            try
            {
                string sql1 = "Select maphong from Phong where maphong = '" + map + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception("Không tồn tại mã phòng");
                string tt = "Đủ";
                if (sosv < sosvtd)
                    tt = "Thiếu";
                string sql = "Update Phong set tenphong=N'" + tenp + "' , sosvtoida = '" + sosvtd + "', tinhtrang = N'" + tt + "', loaiphong =N'" + loaiphong + "', xeploai =N'" + xeploai + "', day = '" + maday + "' where maphong = '" + map + "' "; ;
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("Mã phòng không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeletePhong(String map)
        {
            try
            {
                string sql1 = "Select maphong from Phong where maphong = '" + map + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Delete Phong Where maphong='" + map + "'";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable SearchPhong(String chuoi, String truong)
        {
            string sql = "SELECT * from Phong WHERE " + truong + " LIKE N'%" + chuoi + "%'";
            DataTable dt = dal.GetTable(sql);
            return dt;
        }
    }
}
