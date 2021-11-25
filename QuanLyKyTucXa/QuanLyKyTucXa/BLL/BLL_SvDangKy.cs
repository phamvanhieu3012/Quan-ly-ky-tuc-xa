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
    class BLL_SvDangKy
    {
        DAL dal = new DAL();
        public DataTable SelectSinhVien()
        {
            string sql = "select * from SinhVienDangKy";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public bool KiemTraPhongDay(string map)
        {
            string sql1 = "Select tinhtrang from Phong where maphong = '" + map + "' ";
            DataTable dt = dal.GetTable(sql1);
            //if (dt.Rows[0][0].ToString() == "") throw new Exception();
            //{
            //   MessageBox.Show("Không tồn tại mã phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            if (dt.Rows[0][0].ToString() == "Đủ")
                return true;
            return false;
        }

        public DataTable SelectMaSinhVien()
        {
            string sql = "select masvdky from SinhVienDangKy";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public DataTable SelectSoSv(string map)
        {
            string sql = "Select sosv,sosvtoida from Phong Where maphong = '" + map + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public void UpdateTt(string map, string tt)
        {
            try
            {
                string sql = "Update Phong set tinhtrang = N'" + tt + "' where maphong = '" + map + "' ";
                dal.ExecNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void UpdateSosvPhong(string map, int sl)
        {
            try
            {
                string sql = "Update Phong set sosv = sosv+'" + sl + "' where maphong = '" + map + "' ";
                dal.ExecNonQuery(sql);
                int sosv = int.Parse(SelectSoSv(map).Rows[0][0].ToString());
                int sosvtoida = int.Parse(SelectSoSv(map).Rows[0][1].ToString());
                if (sosv == sosvtoida)
                    UpdateTt(map, "Đủ");
                if (sosv < sosvtoida)
                    UpdateTt(map, "Thiếu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void InsertSinhVien(String masv, String tensv, String gioitinh, DateTime ns, String qq, String khoa, String lop, String maphong, String loaiuutien)
        {
            try
            {
                String sql = "insert into SinhVien values('" + masv + "',N'" + tensv + "',N'" + gioitinh + "','" + ns.ToString("yyyy-MM-dd") + "'," +
                    "N'" + qq + "','" + khoa + "',N'" + lop + "','" + maphong + "',N'" + loaiuutien + "')";
                dal.ExecNonQuery(sql);
                UpdateSosvPhong(maphong, 1);
                DeleteSinhVienDangKy2(masv);
                MessageBox.Show("Đã thêm sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {

                if (ex.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("Mã sinh viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertSinhVienDangKy(String masvdky, String tensv, String gioitinh, DateTime ns, String qq, String khoa, String lop, String maphong, String loaiuutien)
        {
            try
            {
                String sql = "Insert into SinhVienDangKy values('" + masvdky + "',N'" + tensv + "',N'" + gioitinh + "','" + ns.ToString("yyyy-MM-dd") + "'," +
                    "N'" + qq + "','" + khoa + "',N'" + lop + "','" + maphong + "',N'" + loaiuutien + "')";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {

                if (ex.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("Mã sinh viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateSinhVienDangKy(String masvdky, String tensv, String gioitinh, DateTime ns, String qq, String khoa, String lop, String maphong, String loaiuutien)
        {
            try
            {
                string sql1 = "select masvdky from SinhVienDangKy where masvdky = '" + masvdky + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception("Không tồn tại mã sinh viên");
                string sql = "Update SinhVienDangKy set tensv=N'" + tensv + "' ,gioitinh = N'" + gioitinh + "', ngaysinh = '" + ns.ToString("yyyy-MM-dd") + "', " +
                    "quequan = N'" + qq + "', khoa ='" + khoa + "', lop =N'" + lop + "', maphong ='" + maphong + "', loaiuutien =N'" + loaiuutien + "' where masvdky = '" + masvdky + "' "; ;
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("Mã sinh viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteSinhVienDangKy(String masvdky)
        {
            try
            {
                string sql1 = "Select masvdky from SinhVienDangKy where masvdky = '" + masvdky + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Delete SinhVienDangKy Where masvdky='" + masvdky + "'";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã sinh viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteSinhVienDangKy2(String masvdky)
        {
            try
            {
                string sql1 = "Select masvdky from SinhVienDangKy where masvdky = '" + masvdky + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Delete SinhVienDangKy Where masvdky='" + masvdky + "'";
                dal.ExecNonQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã sinh viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
