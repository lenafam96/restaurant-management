using restaurant_management.DAO;
using restaurant_management.DTO;
using restaurant_management.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_management.MenuTab
{
    public partial class frmThietLap : Form
    {
        private Form currentchildform;
        public frmThietLap()
        {
            InitializeComponent();
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
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: motrangcon(new frmCaiDatTaiKhoan()); break;
                case 1: motrangcon(new frmCaiDatDanhMucMon()); break;
                case 2: motrangcon(new frmCaiDatMonAn()); break;
                case 3: motrangcon(new frmCaiDatNhaCungCap()); break;
                case 4: motrangcon(new frmHoaDon()); break;
            }
        }

        private void frmThietLap_Load(object sender, EventArgs e)
        {
            motrangcon(new frmCaiDatTaiKhoan());
        }
    }
}
