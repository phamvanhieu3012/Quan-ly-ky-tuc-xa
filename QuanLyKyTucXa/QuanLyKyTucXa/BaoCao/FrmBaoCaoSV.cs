using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa
{
    public partial class FrmBaoCaoSV : Form
    {
        public FrmBaoCaoSV()
        {
            InitializeComponent();
        }
        BLL.BLL_SinhVien bll = new BLL.BLL_SinhVien();
        private void FrmBaoCaoSV_Load(object sender, EventArgs e)
        {
            dgvSinhvien.DataSource = bll.SelectSinhVien();
        }

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
            worksheet.Cells[1, 1] = "MÃ SINH VIÊN";
            worksheet.Cells[1, 2] = "TÊN SINH VIÊN";
            worksheet.Cells[1, 3] = "GIỚI TÍNH";
            worksheet.Cells[1, 4] = "NGÀY SINH";
            worksheet.Cells[1, 5] = "QUÊ QUÁN";
            worksheet.Cells[1, 6] = "KHÓA";
            worksheet.Cells[1, 7] = "LỚP";
            worksheet.Cells[1, 8] = "MÃ PHÒNG";
            worksheet.Cells[1, 9] = "LOẠI ƯU TIÊN";
            int a = dgvSinhvien.Rows.Count;
            int i;
            for (i = 0; i < a - 1; i++)
            {
                worksheet.Cells[i + 2, 1] = dgvSinhvien.Rows[i].Cells[0].Value.ToString();
                worksheet.Cells[i + 2, 2] = dgvSinhvien.Rows[i].Cells[1].Value.ToString();
                worksheet.Cells[i + 2, 3] = dgvSinhvien.Rows[i].Cells[2].Value.ToString();
                worksheet.Cells[i + 2, 4] = dgvSinhvien.Rows[i].Cells[3].Value.ToString();
                worksheet.Cells[i + 2, 5] = dgvSinhvien.Rows[i].Cells[4].Value.ToString();
                worksheet.Cells[i + 2, 6] = dgvSinhvien.Rows[i].Cells[5].Value.ToString();
                worksheet.Cells[i + 2, 7] = dgvSinhvien.Rows[i].Cells[6].Value.ToString();
                worksheet.Cells[i + 2, 8] = dgvSinhvien.Rows[i].Cells[7].Value.ToString();
                worksheet.Cells[i + 2, 9] = dgvSinhvien.Rows[i].Cells[8].Value.ToString();
            }
            worksheet.Range["A1"].ColumnWidth = 20;
            worksheet.Range["B1"].ColumnWidth = 20;
            worksheet.Range["C1"].ColumnWidth = 15;
            worksheet.Range["D1"].ColumnWidth = 20;
            worksheet.Range["E1"].ColumnWidth = 20;
            worksheet.Range["F1"].ColumnWidth = 15;
            worksheet.Range["G1"].ColumnWidth = 20;
            worksheet.Range["H1"].ColumnWidth = 15;
            worksheet.Range["I1"].ColumnWidth = 20;
            worksheet.Range["D1"].EntireColumn.NumberFormat = "MM/DD/YYYY";
            worksheet.Range["A1", "I1"].Font.Bold = true;
            worksheet.Range["A1", "I100"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "I1"].HorizontalAlignment = 3;
            worksheet.Range["A1", "I1"].Font.ColorIndex = 3;
            worksheet.Range["A1", "I" + (1 + i)].Borders.LineStyle = 1;
            //worksheet.Range["A1", "I1"].Font.Size = 14;
            //worksheet.Range["A1", "I100"].Font.Size = 14;
            //worksheet.Range["A1", "I1"].Font.Bold = true;
            //BorderAround(worksheet.Range["A1", "I" + a]);

            //worksheet.Range["A1", "I10"].Font.Bold = true;
            //worksheet.Range["A" + (dem + 9), "I" + (dem + 9)].HorizontalAlignment = 3;
            // kẻ bảng
        }
    }
}
