using restaurant_management.DAO;
using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_management.View
{
    public partial class frmMonAn : Form
    {
        public frmMonAn()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            flpMonAn.Controls.Clear();
            List<DanhMucMon> list = DanhMucMonDAO.Instance.GetListDanhMucMon();
            foreach (DanhMucMon item in list)
            {
                GroupBox grb = new GroupBox() { Width = DanhMucMonDAO.GroupBoxWidth, Padding = new Padding(10) };
                grb.Font = new Font(grb.Font.FontFamily, 14);
                grb.Text = "Món " + item.TenDanhMucMon;
                grb.ForeColor = Color.FromArgb(172, 126, 241);
                flpMonAn.Controls.Add(grb);
                LoadGroupMonAn(grb, item.MaDanhMucMon);
            }
        }

        void LoadGroupMonAn(GroupBox grb, int maDanhMucMon)
        {
            List<MonAn> list = MonAnDAO.Instance.GetListMonAnByMaDanhMucMon(maDanhMucMon);
            for (int i = 0; i < list.Count(); i++)
            {
                Button btn = new Button() { Width = MonAnDAO.Width, Height = MonAnDAO.Height };
                btn.Font = new Font(btn.Font.FontFamily, 8);
                btn.Text = list[i].TenMonAn;
                btn.Tag = list[i];
                btn.Click += btn_Click;
                grb.Controls.Add(btn);
                btn.Location = new Point(20 + 120 * (i % 4), (i / 4) * 50 + 30);
            }
            grb.Height += (grb.Controls.Count / 4) * 50;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MonAn monAn = (sender as Button).Tag as MonAn;
            MessageBox.Show(monAn.TenMonAn);
        }

        private void frmMonAn_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
