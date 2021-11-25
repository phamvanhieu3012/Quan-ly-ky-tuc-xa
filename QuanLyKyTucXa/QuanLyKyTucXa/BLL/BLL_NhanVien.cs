using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKyTucXa
{
    class BLL_NhanVien
    {
        DAL dal = new DAL();
        public DataTable SelectNhanVien()
        {
            string sql = "select * from NhanVien";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable SelectMaNhanVien()
        {
            string sql = "select manv from NhanVien";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable SelectTenNhanVien()
        {
            string sql = "select tennv from NhanVien";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void InsertNhanVien(String manv, String tennv, String gioitinh, DateTime ns, string dc, string sdt, float hesoluong)
        {
            try
            {
                String sql = "insert into NhanVien values('" + manv + "',N'" + tennv + "',N'" + gioitinh + "','" + ns.ToString("yyyy-MM-dd") + "',N'" + dc + "','" + sdt + "','" + hesoluong + "')";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {

                if (ex.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("Mã nhân viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateNhanVien(String manv, String tennv, String gioitinh, DateTime ns, string dc, string sdt, float hesoluong)
        {
            try
            {
                string sql1 = "select manv from NhanVien where manv = '" + manv + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception("Không tồn tại mã nhân viên");
                string sql = "Update NhanVien set tennv=N'" + tennv + "' ,gioitinh = N'" + gioitinh + "', ngaysinh = '" + ns.ToString("yyyy-MM-dd") + "', diachi = N'" + dc + "', sodienthoai ='" + sdt + "', hesoluong ='" + hesoluong + "' where manv = '" + manv + "' "; ;
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("Mã nhân viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteNhanVien(String manv)
        {
            try
            {
                string sql1 = "Select manv from NhanVien where manv = '" + manv + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "Delete NhanVien Where manv='" + manv + "'";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã nhân viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable SearchNhanVien(String chuoi, String truong)
        {
            string sql = "SELECT * from NhanVien WHERE " + truong + " LIKE N'%" + chuoi + "%'";
            DataTable dt = dal.GetTable(sql);
            return dt;
        }
    }
}
