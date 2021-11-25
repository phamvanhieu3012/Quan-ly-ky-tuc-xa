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
    public partial class FrmBaoCaoTienDien : Form
    {
        public FrmBaoCaoTienDien()
        {
            InitializeComponent();
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
            worksheet.Cells[1, 1] = "MÃ HÓA ĐƠN";
            worksheet.Cells[1, 2] = "MÃ PHÒNG";
            worksheet.Cells[1, 3] = "NGÀY LẬP";
            worksheet.Cells[1, 4] = "CHỈ SỐ CŨ";
            worksheet.Cells[1, 5] = "CHỈ SỐ MỚI";
            worksheet.Cells[1, 6] = "LƯỢNG ĐIỆN TIÊU THỤ";
            worksheet.Cells[1, 7] = "TỔNG TIỀN";
            worksheet.Cells[1, 8] = "TRẠNG THÁI";
            int a = dgvTiendien.Rows.Count;
            int i;
            for (i = 0; i < a - 1; i++)
            {
                worksheet.Cells[i + 10, 1] = dgvTiendien.Rows[i].Cells[0].Value.ToString();
                worksheet.Cells[i + 10, 2] = dgvTiendien.Rows[i].Cells[1].Value.ToString();
                worksheet.Cells[i + 10, 3] = dgvTiendien.Rows[i].Cells[2].Value.ToString();
                worksheet.Cells[i + 10, 4] = dgvTiendien.Rows[i].Cells[3].Value.ToString();
                worksheet.Cells[i + 10, 5] = dgvTiendien.Rows[i].Cells[4].Value.ToString();
                worksheet.Cells[i + 10, 6] = dgvTiendien.Rows[i].Cells[5].Value.ToString();
                worksheet.Cells[i + 10, 7] = dgvTiendien.Rows[i].Cells[6].Value.ToString();
                worksheet.Cells[i + 10, 8] = dgvTiendien.Rows[i].Cells[7].Value.ToString();
            }
            worksheet.Range["A1"].ColumnWidth = 20;
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
            //worksheet.Range["A1", "H100"].Font.Size = 14;
            //worksheet.Range["A1", "H1"].HorizontalAlignment = 3;
            //worksheet.Range["A" + (dem + 9), "I" + (dem + 9)].HorizontalAlignment = 3;
        }
    }
}
