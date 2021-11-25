using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa.BaoCao
{
    public partial class FrmBaoCaoNhanVien : Form
    {
        public FrmBaoCaoNhanVien()
        {
            InitializeComponent();
        }
        BLL_NhanVien bll = new BLL_NhanVien();

        private void xuấtExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // khởi tạo excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // khởi tạo workbook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // khởi tạo worksheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // đổ dữ liệu
            worksheet.Cells[1, 1] = "MÃ NHÂN VIÊN";
            worksheet.Cells[1, 2] = "TÊN NHÂN VIÊN";
            worksheet.Cells[1, 3] = "GIỚI TÍNH";
            worksheet.Cells[1, 4] = "NGÀY SINH";
            worksheet.Cells[1, 5] = "ĐỊA CHỈ";
            worksheet.Cells[1, 6] = "SỐ ĐIỆN THOẠI";
            worksheet.Cells[1, 7] = "HỆ SỐ LƯƠNG";
            int a = dgvNhanvien.Rows.Count;
            int i;
            for (i = 0; i < a - 1; i++)
            {
                worksheet.Cells[i + 2, 1] = dgvNhanvien.Rows[i].Cells[0].Value.ToString();
                worksheet.Cells[i + 2, 2] = dgvNhanvien.Rows[i].Cells[1].Value.ToString();
                worksheet.Cells[i + 2, 3] = dgvNhanvien.Rows[i].Cells[2].Value.ToString();
                worksheet.Cells[i + 2, 4] = dgvNhanvien.Rows[i].Cells[3].Value.ToString();
                worksheet.Cells[i + 2, 5] = dgvNhanvien.Rows[i].Cells[4].Value.ToString();
                worksheet.Cells[i + 2, 6] = dgvNhanvien.Rows[i].Cells[5].Value.ToString();
                worksheet.Cells[i + 2, 7] = dgvNhanvien.Rows[i].Cells[6].Value.ToString();
            }
            worksheet.Range["A1"].ColumnWidth = 18;
            worksheet.Range["B1"].ColumnWidth = 20;
            worksheet.Range["C1"].ColumnWidth = 20;
            worksheet.Range["D1"].ColumnWidth = 20;
            worksheet.Range["E1"].ColumnWidth = 20;
            worksheet.Range["F1"].ColumnWidth = 20;
            worksheet.Range["G1"].ColumnWidth = 20;
            worksheet.Range["A1", "G1"].Font.Bold = true;
            worksheet.Range["A1", "G100"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "G1"].HorizontalAlignment = 3;
            worksheet.Range["A1", "G1"].Font.ColorIndex = 3;
            worksheet.Range["A1", "G" + (1 + i)].Borders.LineStyle = 1;
            //worksheet.Range["A1", "G100"].Font.Size = 14;
        }

        private void FrmBaoCaoNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanvien.DataSource = bll.SelectNhanVien();
        }
    }
}
