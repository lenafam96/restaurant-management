using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;
using restaurant_management.MenuTab;
using restaurant_management.DTO;
using restaurant_management.DAO;

namespace restaurant_management
{
    public partial class MainControl : Form
    {
        private static Account loginAccount;
        private IconButton currentbtn;
        private Panel lefborderbtn;
        private Form currentchildform;

        public static Account LoginAccount
        {
            get => loginAccount;
            set => loginAccount = value;
        }

        public MainControl(Account account)
        {
            InitializeComponent();
            LoginAccount = account;
            lefborderbtn = new Panel();
            lefborderbtn.Size = new Size(7, 50);
            PanelMenu.Controls.Add(lefborderbtn);
            timer1.Start();//dong ho
            ChangeAccount();

        }

        void ChangeAccount()
        {
            LabelUser.Text = LoginAccount.DisplayName;
            Role role = RoleDAO.Instance.GetRoleByID(loginAccount.Role);
            btnBan.Enabled = role.QuyenBan;
            btnNhanVien.Enabled = role.QuyenNhanVien;
            btnKhachHang.Enabled = role.QuyenKhachHang;
            btnVoucher.Enabled = role.QuyenVoucher;
            btnThongKe.Enabled = role.QuyenThongKe;
            iconButtonKho.Enabled = role.QuyenKho;
            btnSetting.Enabled = role.QuyenThietLap;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253,138,114);
            public static Color color4 = Color.FromArgb(95,77,221);
            public static Color color5 = Color.FromArgb(249,88,155);
            public static Color color6 = Color.FromArgb(24,161,251);
            public static Color color7 = Color.FromArgb(145,151,154);
            public static Color color8 = Color.FromArgb(153, 217, 140);
            public static Color color9 = Color.FromArgb(252, 163, 17);

        }

        private void activebtn(object senderbtn, Color color)
        {
            if(senderbtn != null)
            {
                disablebtn();
                //button
                currentbtn = (IconButton)senderbtn;
                currentbtn.BackColor = Color.FromArgb(37,36,81);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border btn
                lefborderbtn.BackColor = color;
                if (currentbtn.Text.Equals("Tồn Kho") || currentbtn.Text.Equals("Nhập Kho"))
                    lefborderbtn.Location = new Point(0, currentbtn.Location.Y + 350);
                else
                {
                    lefborderbtn.Location = new Point(0, currentbtn.Location.Y);
                    PanelDropDownSP.Height = 50;
                }    
                lefborderbtn.Visible = true;
                lefborderbtn.BringToFront();

                //icon small
                iconmenusmall.IconChar = currentbtn.IconChar;
                iconmenusmall.IconColor = color;

            }
        }

        private void disablebtn()
        {
            if(currentbtn != null)
            {
                //button

                currentbtn.BackColor = Color.FromArgb(34, 36, 49);
                currentbtn.ForeColor = Color.Gainsboro;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.Gainsboro;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void motrangcon(Form trangcon)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();

            }
            currentchildform = trangcon;
            trangcon.TopLevel = false;
            trangcon.FormBorderStyle = FormBorderStyle.None;
            trangcon.Dock = DockStyle.Fill;
            paneltrangcon.Controls.Add(trangcon);
            paneltrangcon.Tag = trangcon;
            trangcon.BringToFront();
            trangcon.Show();
            labelcon.Text = trangcon.Text;
        }
        private void btnhome_Click(object sender, EventArgs e)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
                Reset();
            }

        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            activebtn(sender, RGBColors.color1);
            motrangcon(new frmBan());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            activebtn(sender, RGBColors.color2);
            motrangcon(new frmNhanVien());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            activebtn(sender, RGBColors.color3);
            motrangcon(new frmKhachHang());
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            activebtn(sender, RGBColors.color4);
            motrangcon(new frmVoucher());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            activebtn(sender, RGBColors.color5);
            motrangcon(new frmThongKe());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            activebtn(sender, RGBColors.color6);
            motrangcon(new frmPhanQuyen());
        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            activebtn(sender, RGBColors.color7);
            Application.Restart();
        }



        private void Reset()
        {
            disablebtn();
            lefborderbtn.Visible = false;
            iconmenusmall.IconChar = IconChar.Home;
            iconmenusmall.IconColor = Color.Gainsboro;
            labelcon.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam );

        private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            if(currentchildform!=null)
            {
                currentchildform.Close();
                Reset();
            }    
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconZoom_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void MainControl_Load(object sender, EventArgs e)
        {
            PanelDropDownSP.Height = 50;
            
        }

        private void paneltrangcon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonSP_Click(object sender, EventArgs e)
        {
            //activebtn(sender, RGBColors.color3);
            if (PanelDropDownSP.Height == 50)
            {
                iconButtonTonKho.BackColor = iconButtonNhapKho.BackColor = Color.Indigo;
            }
            PanelDropDownSP.Height = 200;

        }

        private void iconButtonTonKho_Click(object sender, EventArgs e)
        {
            activebtn(sender, RGBColors.color8);
            motrangcon(new frmTonKho());
            iconButtonNhapKho.BackColor = Color.Indigo;
        }

        private void iconButtonNhapKho_Click(object sender, EventArgs e)
        {
            activebtn(sender, RGBColors.color9);
            motrangcon(new frmNhapKho());
            iconButtonTonKho.BackColor = Color.Indigo;
        }


        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
