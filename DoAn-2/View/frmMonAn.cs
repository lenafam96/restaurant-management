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
        private MonAn selected;
        private HoaDon hoaDon;

        public HoaDon HoaDon { get => hoaDon; set => hoaDon = value; }

        public frmMonAn(HoaDon hoaDon)
        {
            InitializeComponent();
            this.HoaDon = hoaDon;
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
                btn.BackColor = Color.FromArgb(172, 126, 241);
                btn.ForeColor = Color.White;
                btn.Click += btn_Click;
                grb.Controls.Add(btn);
                btn.Location = new Point(20 + 120 * (i % 4), (i / 4) * 50 + 30);
            }
            grb.Height += (grb.Controls.Count / 4) * 50;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.selected = (sender as Button).Tag as MonAn;
            nbuSoLuong.Value = 0;
        }

        private void frmMonAn_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (nbuSoLuong.Value != 0 && this.selected != null)
            {
                if (ChiTietHoaDonDAO.Instance.CheckMonAnTrongHoaDon(this.HoaDon.MaHoaDon, this.selected.MaMonAn))
                    ChiTietHoaDonDAO.Instance.CapNhatMonAnVaoHoaDon(this.HoaDon.MaHoaDon, this.selected.MaMonAn, (int)nbuSoLuong.Value);
                else
                    ChiTietHoaDonDAO.Instance.ThemMonAnVaoHoaDon(this.HoaDon.MaHoaDon, this.selected.MaMonAn, (int)nbuSoLuong.Value);
            }
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
