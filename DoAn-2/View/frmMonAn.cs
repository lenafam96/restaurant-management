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

        int SoLuongToiDa()
        {
            int min = int.MaxValue;
            List<ChiTietMonAn> listChiTietMonAn = ChiTietMonAnDAO.Instance.GetListThucPhamByMaMonAn(this.selected.MaMonAn);
            foreach (ChiTietMonAn item in listChiTietMonAn)
            {
                ThucPham tmp = ThucPhamDAO.Instance.GetThucPhamByMaThucPham(item.MaThucPham);
                if (tmp != null && item.SoLuong > 0 && min > (tmp.TonKho / item.SoLuong))
                    min = tmp.TonKho / item.SoLuong;
            }
            return min;
        }

        int SoLuongToiDa(int maMonAn)
        {
            int min = int.MaxValue;
            List<ChiTietMonAn> listChiTietMonAn = ChiTietMonAnDAO.Instance.GetListThucPhamByMaMonAn(maMonAn);
            foreach (ChiTietMonAn item in listChiTietMonAn)
            {
                ThucPham tmp = ThucPhamDAO.Instance.GetThucPhamByMaThucPham(item.MaThucPham);
                if (tmp != null && item.SoLuong>0 && min > (tmp.TonKho / item.SoLuong))
                    min = tmp.TonKho / item.SoLuong;
            }
            return min;
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
                if (SoLuongToiDa(list[i].MaMonAn) == 0)
                    btn.Text += "\nHết";
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
            nbuSoLuong.Maximum = SoLuongToiDa();
        }

        private void frmMonAn_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (nbuSoLuong.Value != 0 && this.selected != null)
            {
                int soLuongThem = (int)nbuSoLuong.Value;
                List<ChiTietMonAn> listChiTietMonAn = ChiTietMonAnDAO.Instance.GetListThucPhamByMaMonAn(this.selected.MaMonAn);
                if (ChiTietHoaDonDAO.Instance.CheckMonAnTrongHoaDon(this.HoaDon.MaHoaDon, this.selected.MaMonAn)!=null)
                {
                    ChiTietHoatDon tmp = ChiTietHoaDonDAO.Instance.CheckMonAnTrongHoaDon(this.HoaDon.MaHoaDon, this.selected.MaMonAn);
                    ChiTietHoaDonDAO.Instance.CapNhatMonAnVaoHoaDon(this.HoaDon.MaHoaDon, this.selected.MaMonAn, soLuongThem);
                    if (tmp.SoLuong + soLuongThem < 0)
                        soLuongThem = tmp.SoLuong * -1;
                    foreach (ChiTietMonAn item in listChiTietMonAn)
                    {
                        ThucPhamDAO.Instance.UpdateSoLuongThucPham(item.MaThucPham, soLuongThem * item.SoLuong);
                    }
                }    
                else if( soLuongThem > 0 )
                {
                    ChiTietHoaDonDAO.Instance.ThemMonAnVaoHoaDon(this.HoaDon.MaHoaDon, this.selected.MaMonAn, soLuongThem);
                    foreach (ChiTietMonAn item in listChiTietMonAn)
                    {
                        ThucPhamDAO.Instance.UpdateSoLuongThucPham(item.MaThucPham, soLuongThem * item.SoLuong);
                    }
                }    
            }
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
