using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKyTucXa
{
    class DAL
    {
        public SqlConnection GetConnection()
        {
            String connString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyKyTucXa;Integrated Security=True";
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                return conn;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable GetTable(String sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        public void ExecNonQuery(String sql)
        {
            SqlConnection conn = GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            /*
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        public Boolean login(string sql)
        {
            SqlConnection conn = GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
                return true;
            else
                return false;
        }
    }
}
