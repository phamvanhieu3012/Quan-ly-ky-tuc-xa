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
    class BLL_NguoiDung
    {
        DAL dal = new DAL();
        public DataTable SelectNguoiDung()
        {
            string sql = "select * from NguoiDung";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable SelectMaNguoiDung(string tendangnhap, string mk)
        {
            string sql = "select manguoidung from NguoiDung where tendangnhap='" + tendangnhap + "' and matkhau='" + mk + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable SelectQuyenNguoiDung(string tendangnhap, string mk)
        {
            string sql = "select quyen from NguoiDung where tendangnhap='" + tendangnhap + "' and matkhau='" + mk + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable SelectMatKhauCu(string id)
        {
            string sql = "Select matkhau from NguoiDung where manguoidung = '" + id + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void InsertNguoiDung(String manv, String tendangnhap, String matkhau, String quyen)
        {
            try
            {
                string sql1 = "select * from NguoiDung where tendangnhap = '" + tendangnhap + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() != "") throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Tên đăng nhập không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                String sql = "Insert Into NguoiDung (manv,tendangnhap,matkhau,quyen) values('" + manv + "','" + tendangnhap + "','" + matkhau + "','" + quyen + "')";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã thêm người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {

                if (ex.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("Mã người dùng không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateMatKhau(string id, string mkmoi)
        {
            try
            {
                string sql = "Update NguoiDung set matkhau = '" + mkmoi + "' where manguoidung = '" + id + "' "; ;
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateNguoiDung(String manguoidung, String manv, String tendangnhap, String matkhau, String quyen)
        {
            try
            {
                string sql1 = "select manguoidung from NguoiDung where manguoidung = '" + manguoidung + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Update NguoiDung set manv=N'" + manv + "' ,tendangnhap = '" + tendangnhap + "', matkhau = '" + matkhau + "', quyen = '" + quyen + "' where manguoidung = '" + manguoidung + "' "; ;
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã người dùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteNguoiDung(String mand)
        {
            try
            {
                string sql1 = "Select manguoidung from NguoiDung where manguoidung = '" + mand + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Delete NguoiDung Where manguoidung='" + mand + "'";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã người dùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable SearchNguoiDung(String chuoi, String truong)
        {
            string sql = "SELECT * from NguoiDung WHERE " + truong + " LIKE N'%" + chuoi + "%'";
            DataTable dt = dal.GetTable(sql);
            return dt;
        }
    }
}
