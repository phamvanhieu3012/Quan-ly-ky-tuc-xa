using Microsoft.Office.Interop.Excel;
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
    public partial class FrmBaoCaoPhong : Form
    {
        public FrmBaoCaoPhong()
        {
            InitializeComponent();
        }
        BLL.BLL_Phong BLL_Phong = new BLL.BLL_Phong();

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
            worksheet.Cells[1, 1] = "MÃ PHÒNG";
            worksheet.Cells[1, 2] = "TÊN PHÒNG";
            worksheet.Cells[1, 3] = "SỐ SINH VIÊN HIỆN TẠI";
            worksheet.Cells[1, 4] = "SỐ SINH VIÊN TỐI ĐA";
            worksheet.Cells[1, 5] = "TÌNH TRẠNG";
            worksheet.Cells[1, 6] = "LOẠI PHÒNG";
            worksheet.Cells[1, 7] = "XẾP LOẠI";
            worksheet.Cells[1, 8] = "DÃY";
            int a = dgvPhong.Rows.Count;
            int i;
            for (i = 0; i < a - 1; i++)
            {
                worksheet.Cells[i + 2, 1] = dgvPhong.Rows[i].Cells[0].Value.ToString();
                worksheet.Cells[i + 2, 2] = dgvPhong.Rows[i].Cells[1].Value.ToString();
                worksheet.Cells[i + 2, 3] = dgvPhong.Rows[i].Cells[2].Value.ToString();
                worksheet.Cells[i + 2, 4] = dgvPhong.Rows[i].Cells[3].Value.ToString();
                worksheet.Cells[i + 2, 5] = dgvPhong.Rows[i].Cells[4].Value.ToString();
                worksheet.Cells[i + 2, 6] = dgvPhong.Rows[i].Cells[5].Value.ToString();
                worksheet.Cells[i + 2, 7] = dgvPhong.Rows[i].Cells[6].Value.ToString();
                worksheet.Cells[i + 2, 8] = dgvPhong.Rows[i].Cells[7].Value.ToString();
            }
            worksheet.Range["A1"].ColumnWidth = 18;
            worksheet.Range["B1"].ColumnWidth = 20;
            worksheet.Range["C1"].ColumnWidth = 20;
            worksheet.Range["D1"].ColumnWidth = 20;
            worksheet.Range["E1"].ColumnWidth = 20;
            worksheet.Range["F1"].ColumnWidth = 20;
            worksheet.Range["G1"].ColumnWidth = 20;
            worksheet.Range["H1"].ColumnWidth = 20;
            worksheet.Range["A1", "H1"].Font.Bold = true;
            worksheet.Range["A1", "H100"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "H1"].HorizontalAlignment = 3;
            worksheet.Range["A1", "H1"].Font.ColorIndex = 3;
            worksheet.Range["A1", "H" + (1 + i)].Borders.LineStyle = 1;
            //worksheet.Range["A1", "H100"].Font.Size = 13;
            //worksheet.Range["A1", "H8"].Font.Bold = true;
            //worksheet.Range["A" + (dem + 9), "I" + (dem + 9)].HorizontalAlignment = 3;
        }

        private void FrmBaoCaoPhong_Load(object sender, EventArgs e)
        {
            dgvPhong.DataSource = BLL_Phong.SelectPhong();
        }
    }
}
