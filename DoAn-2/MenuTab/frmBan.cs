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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_management.MenuTab
{
    public partial class frmBan : Form
    {
        private Ban banSelected = null;
        private HoaDon hoaDonSelected = null;

        public HoaDon HoaDonSelected { get => hoaDonSelected; set => hoaDonSelected = value; }
        public Ban BanSelected { get => banSelected; set => banSelected = value; }

        public frmBan()
        {
            InitializeComponent();
        }

        void DongBtn()
        {
            lsvHoaDon.Items.Clear();
            btnTaoHoaDon.Enabled = true;
            btnThemMon.Enabled = false;
            btnThanhToan.Enabled = false;
            lsvHoaDon.Enabled = false;
        }

        void MoBtn()
        {
            lsvHoaDon.Items.Clear();
            btnTaoHoaDon.Enabled = false;
            btnThemMon.Enabled = true;
            btnThanhToan.Enabled = true;
            lsvHoaDon.Enabled = true;
        }
        void LoadBan()
        {
            flpBan.Controls.Clear();
            List<Ban> listBan = BanDAO.Instance.GetListBan();
            foreach (Ban item in listBan)
            {
                Button btnBan = new Button() { Width = BanDAO.BanWidth, Height = BanDAO.BanHeight };
                btnBan.Font = new Font(btnBan.Font.FontFamily, 14);
                btnBan.Text = "Bàn " + item.MaBan;
                btnBan.Click += btnBan_Click;
                btnBan.Tag = item;
                if (item.TrangThai == 1)
                    btnBan.BackColor = ColorTranslator.FromHtml("#d90429");
                else
                    btnBan.BackColor = ColorTranslator.FromHtml("#99D98C");
                flpBan.Controls.Add(btnBan);
            }
        }

        void ShowHoaDon(int maBan)
        {
            lsvHoaDon.Items.Clear();
            List<ChiTietHoatDon> list = ChiTietHoaDonDAO.Instance.GetListMonAnByMaBan(maBan);
            {
                ListViewItem lsvItem = new ListViewItem("(1)");
                lsvItem.SubItems.Add("(2)");
                lsvItem.SubItems.Add("(3)");
                lsvItem.SubItems.Add("(4)");
                lsvItem.SubItems.Add("(5) = (3) x (4)");
                lsvHoaDon.Items.Add(lsvItem);
            }
            foreach (ChiTietHoatDon item in list)
            {
                if (item.SoLuong == 0)
                    continue;
                ListViewItem lsvItem = new ListViewItem((lsvHoaDon.Items.Count ).ToString());
                lsvItem.SubItems.Add(item.TenMonAn.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.Gia.ToString());
                lsvItem.SubItems.Add(item.ThanhTien.ToString());
                lsvHoaDon.Items.Add(lsvItem);
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            Ban ban = (sender as Button).Tag as Ban;
            if (ban.TrangThai == 0)
                DongBtn();
            else
            {
                MoBtn();
                ShowHoaDon(ban.MaBan);
            }
            this.BanSelected = ban;
            this.HoaDonSelected = HoaDonDAO.Instance.GetHoaDonByMaBan(ban.MaBan);
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            DongBtn();
            btnTaoHoaDon.Enabled = false;
            ListViewItem lsvItem = new ListViewItem("(1)");
            lsvItem.SubItems.Add("(2)");
            lsvItem.SubItems.Add("(3)");
            lsvItem.SubItems.Add("(4)");
            lsvItem.SubItems.Add("(5) = (3) x (4)");
            lsvHoaDon.Items.Add(lsvItem);
            LoadBan();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            frmMonAn f = new frmMonAn(HoaDonSelected);
            f.ShowDialog();
            ShowHoaDon(this.banSelected.MaBan);

        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonDAO.Instance.TaoHoaDon(MainControl.LoginAccount.MaNhanVien, this.BanSelected.MaBan);
            this.HoaDonSelected = HoaDonDAO.Instance.GetHoaDonByMaBan(this.BanSelected.MaBan);
            MoBtn();
            LoadBan();
            ShowHoaDon(this.BanSelected.MaBan);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DongBtn();
            LoadBan();
        }
    }
}
