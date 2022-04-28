using restaurant_management.DAO;
using restaurant_management.DTO;
using restaurant_management.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_management.MenuTab
{
    public partial class frmBan : Form
    {
        private Ban banSelected = null;
        private HoaDon hoaDonSelected = null;
        private int tongTien;
        private int voucher;
        private int suDungDiem;
        private int diemTichLuy;
        private int thanhToan;

        public HoaDon HoaDonSelected { get => hoaDonSelected; set => hoaDonSelected = value; }
        public Ban BanSelected { get => banSelected; set => banSelected = value; }

        public frmBan()
        {
            InitializeComponent();
        }

        void XoaLabel()
        {
            lbTenBan.Text = "";
            lbTongTien.Text = "";
            lbVoucher.Text = "";
            lbSuDungDiem.Text = "";
            lbThanhTien.Text = "";
            txtDiemTichLuy.ResetText();
        }
        void HienThiThanhTien()
        {
            lbTenBan.Text = "Bàn " + this.banSelected.MaBan.ToString();
            lbTongTien.Text = this.tongTien.ToString("c0");
            lbVoucher.Text = 0.ToString("c0");
            lbSuDungDiem.Text = 0.ToString("c0");
            lbThanhTien.Text = this.tongTien.ToString("c0");
        }
        void DongBtn()
        {
            lsvHoaDon.Items.Clear();
            btnTaoHoaDon.Enabled = true;
            btnThemMon.Enabled = false;
            btnThanhToan.Enabled = false;
            lsvHoaDon.Enabled = false;
            grpanel.Enabled = false;
        }

        void MoBtn()
        {
            lsvHoaDon.Items.Clear();
            btnTaoHoaDon.Enabled = false;
            btnThemMon.Enabled = true;
            btnThanhToan.Enabled = true;
            lsvHoaDon.Enabled = true;
            grpanel.Enabled = true;
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
            XoaLabel();
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            nbuSuDungDiem.Enabled = false;
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
            this.tongTien = 0;
            foreach (ChiTietHoatDon item in list)
            {
                if (item.SoLuong == 0)
                    continue;
                ListViewItem lsvItem = new ListViewItem((lsvHoaDon.Items.Count ).ToString());
                lsvItem.SubItems.Add(item.TenMonAn.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.Gia.ToString("c0"));
                lsvItem.SubItems.Add(item.ThanhTien.ToString("c0"));
                this.tongTien += item.ThanhTien;
                lsvHoaDon.Items.Add(lsvItem);
            }
        }

        bool CheckMaKH()
        {
            int maKhachHang = 0;
            int.TryParse(txtMaKhachHang.Text.Trim(), out maKhachHang);
            KhachHang khachHang = KhachHangDAO.Instance.GetKhachHangByID(maKhachHang);
            return khachHang == null;
        }

        bool CheckMaVoucher()
        {
            int maVoucher = 0;
            int.TryParse(txtMaVoucher.Text.Trim(),out maVoucher);
            Voucher voucher = VoucherDAO.Instance.GetVoucherByID(maVoucher);
            return voucher == null;
        }

        void TinhDiemTichLuy()
        {
            if (this.thanhToan >= 10000000)
                this.diemTichLuy = this.thanhToan * 15 / 100000;
            else if (this.thanhToan >= 5000000)
                this.diemTichLuy = this.thanhToan * 10 / 100000;
            else if (this.thanhToan >= 1000000)
                this.diemTichLuy = this.thanhToan * 7 / 100000;
            else if (this.thanhToan >= 100000)
                this.diemTichLuy = this.thanhToan * 3 / 100000;
            else
                this.diemTichLuy = 1;
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
            HienThiThanhTien();
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

        private void txtMaKhachHang_Leave(object sender, EventArgs e)
        {
            nbuSuDungDiem.Enabled = false;
            if (string.IsNullOrEmpty(txtMaKhachHang.Text))
            {
                errorProviderKhachHang.Clear();
                txtDiemTichLuy.ResetText();
            }
            else if (CheckMaKH())
            {
                errorProviderKhachHang.SetError(txtMaKhachHang, "Mã khách hàng không tồn tại!");
                this.suDungDiem = 0;
                this.thanhToan = this.tongTien - this.voucher - this.suDungDiem;
                lbSuDungDiem.Text = this.suDungDiem.ToString("c0");
                lbThanhTien.Text = this.thanhToan.ToString("c0");
                txtDiemTichLuy.ResetText();
            }    
            else
            {
                errorProviderKhachHang.Clear();
                KhachHang khachHang = KhachHangDAO.Instance.GetKhachHangByID(int.Parse(txtMaKhachHang.Text));
                nbuSuDungDiem.Enabled = true;
                nbuSuDungDiem.Maximum = khachHang.DiemTichLuy;
                this.suDungDiem = (int)nbuSuDungDiem.Value * 1000;
                this.thanhToan = this.tongTien - this.voucher - this.suDungDiem;
                lbSuDungDiem.Text = this.suDungDiem == 0 ? this.suDungDiem.ToString("c0") : "- " + this.suDungDiem.ToString("c0");
                lbThanhTien.Text = this.thanhToan.ToString("c0");
                TinhDiemTichLuy();
                txtDiemTichLuy.Text = this.diemTichLuy.ToString();
            }    
        }

        private void txtMaVoucher_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaVoucher.Text))
            {
                errorProviderVoucher.Clear();
            }
            else if (CheckMaVoucher())
            {
                errorProviderVoucher.SetError(txtMaVoucher, "Mã voucher không hợp lệ!");
                this.voucher = 0;
                this.thanhToan = this.tongTien - this.voucher - this.suDungDiem;
                lbVoucher.Text = this.voucher.ToString("c0");
                lbThanhTien.Text = this.thanhToan.ToString("c0");
            }
            else
            {
                errorProviderVoucher.Clear();
                Voucher voucher = VoucherDAO.Instance.GetVoucherByID(int.Parse(txtMaVoucher.Text));
                if (voucher.Loai.Equals("Tiền mặt"))
                    this.voucher = voucher.GiaTri;
                else
                    this.voucher = this.tongTien * voucher.GiaTri / 100;
                this.thanhToan = this.tongTien - this.voucher - this.suDungDiem;
                lbVoucher.Text = this.voucher == 0 ? this.voucher.ToString("c0") : "- " + this.voucher.ToString("c0");
                lbThanhTien.Text = this.thanhToan.ToString("c0");
            }    
        }

        private void nbuSuDungDiem_ValueChanged(object sender, EventArgs e)
        {
            KhachHang khachHang = KhachHangDAO.Instance.GetKhachHangByID(int.Parse(txtMaKhachHang.Text));
            nbuSuDungDiem.Maximum = khachHang.DiemTichLuy;
            this.suDungDiem = (int)nbuSuDungDiem.Value * 1000;
            this.thanhToan = this.tongTien - this.voucher - this.suDungDiem;
            lbSuDungDiem.Text = this.suDungDiem == 0 ? this.suDungDiem.ToString("c0") : "- " + this.suDungDiem.ToString("c0");
            lbThanhTien.Text = this.thanhToan.ToString("c0");
        }

        private void lbThanhTien_TextChanged(object sender, EventArgs e)
        {
            if (!CheckMaKH())
            {
                TinhDiemTichLuy();
                txtDiemTichLuy.Text = this.diemTichLuy.ToString();
            }
        }
    }
}
