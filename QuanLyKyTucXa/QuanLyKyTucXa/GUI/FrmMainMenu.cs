using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa
{
    public partial class FrmMainMenu : Form
    {
        //Fields
        private Button currentButton;
        public string idNguoiDung = "";
        public string quyenNguoiDung = "";
        //Constructors
        public FrmMainMenu()
        {
            InitializeComponent();
            customizeDesign();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.DoubleBuffered = true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Method

        private void ActivateButton(object btnSender, int r, int g, int b)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(r, g, b);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelSidebar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = SystemColors.ButtonFace;
                    previousBtn.ForeColor = SystemColors.ControlText;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm, Size size, Point point)
        {
            if (activeForm != null)
                activeForm.Close();
            //panelControl.Visible = false;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
            lblTitle.Size = size;
            lblTitle.Location = point;
            btnClose.Visible = true;
        }
        private void customizeDesign()
        {
            panelTaikhoanSubmenu.Visible = false;
            panelDanhmucSubmenu.Visible = false;
            panelPhongSubmenu.Visible = false;
            panelBaocaoSubmenu.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panelTaikhoanSubmenu.Visible == true)
            {
                panelTaikhoanSubmenu.Visible = false;
            }
            if (panelDanhmucSubmenu.Visible == true)
            {
                panelDanhmucSubmenu.Visible = false;
            }
            if (panelPhongSubmenu.Visible == true)
            {
                panelPhongSubmenu.Visible = false;
            }
            if (panelBaocaoSubmenu.Visible == true)
            {
                panelBaocaoSubmenu.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 89, 120, 187);
            showSubMenu(panelTaikhoanSubmenu);
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
        }

        private void btnDanhmuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 0, 150, 136);
            showSubMenu(panelDanhmucSubmenu);
            if (quyenNguoiDung == "User")
                btnNguoidung.Enabled = false;
        }

        private void btnSinhvien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 255, 152, 0);
            openChildForm(new FrmQuanLySinhVien(), new Size(180, 26), new Point(325, 15));
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 3, 150, 243);
            showSubMenu(panelBaocaoSubmenu);
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 199, 220, 91);
            showSubMenu(panelPhongSubmenu);
        }

        private void btnQuanlytiendien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 239, 147, 126);
            openChildForm(new FrmQuanLyTienDien(), new Size(180, 26), new Point(290, 15));
        }

        private void btnDanhsachphong_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyPhong(), new Size(156, 26), new Point(325, 15));
            hideSubmenu();
        }

        private void btnDanhsachday_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyDay(), new Size(129, 26), new Point(308, 15));
            hideSubmenu();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyNhanVien(), new Size(192, 26), new Point(325, 15));
            hideSubmenu();
        }

        private void btnNguoidung_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyNguoiDung(), new Size(205, 26), new Point(325, 15));
            hideSubmenu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnKyluat_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyKyLuat(), new Size(156, 26), new Point(325, 15));
            hideSubmenu();
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau frmDoiMk = new FrmDoiMatKhau();
            frmDoiMk.id = this.idNguoiDung;
            frmDoiMk.Show();
        }

        private void btnXuatexcel_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmBaoCao(), new Size(122, 26), new Point(325, 15));
            hideSubmenu();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmThongKeTienDien(), new Size(352, 26), new Point(200, 15));
            hideSubmenu();
        }

        private void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            btnClose.Visible = false;
            lblTitle.Text = "HOME";
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
        }

        private void btnDanhSachDangKy_Click(object sender, EventArgs e)
        {
            openChildForm(new DanhSachDangKy(), new Size(205, 26), new Point(325, 15));
            hideSubmenu();
        }
    }
}
