using restaurant_management.DAO;
using restaurant_management.DTO;
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

namespace restaurant_management.View
{
    public partial class frmHoaDon : Form
    {
        BindingSource list = new BindingSource();
        bool Add = false;

        public frmHoaDon()
        {
            InitializeComponent();
        }

        void ResetAllTextBox()
        {
            txtMaHoaDon.ResetText();
            cmbNhanVien.ResetText();
            cmbKhachHang.ResetText();
            cmbBan.ResetText();
            txtDiemCong.ResetText();
            txtDiemTru.ResetText();
            txtTongTien.ResetText();
            cmbVoucher.ResetText();
            radDaThanhToan.Checked = radDaThanhToan.Checked = false;
        }

        void SetBtnEdit_On()
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            grPanel.Enabled = true;
            //btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dtgvHoaDon.Enabled = false;
        }

        void SetBtnEdit_Off()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            grPanel.Enabled = false;
            //btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            dtgvHoaDon.Enabled = true;
            Add = false;
        }

        void LoadListHoaDon()
        {
            int page = 1;
            int pageRow = (int)nUDPageRows.Value;
            lbTotalPage.Text = "/" + LastPage().ToString();
            if (int.TryParse(txbPage.Text, out page))
                list.DataSource = HoaDonDAO.Instance.GetDataTableHoaDon(dtpStart.Value, dtpStop.Value, page, pageRow);
            btnEdit.Enabled = list.Count > 0 ? true : false;
            btnDelete.Enabled = list.Count > 0 ? true : false;
        }
        void LoadComboBox()
        {
            cmbNhanVien.DataSource = NhanVienDAO.Instance.GetListNhanVien();
            cmbNhanVien.ValueMember = "maNhanVien";
            cmbNhanVien.DisplayMember = "hoTen";
            cmbKhachHang.DataSource = KhachHangDAO.Instance.GetListKhachHangCmb();
            cmbKhachHang.ValueMember = "maKhachHang";
            cmbKhachHang.DisplayMember = "hoTen";
            cmbBan.DataSource = BanDAO.Instance.GetListBan();
            cmbBan.ValueMember = "maBan";
            cmbBan.DisplayMember = "maBan";
            cmbVoucher.DataSource = VoucherDAO.Instance.GetListVoucherCmb();
            cmbVoucher.ValueMember = "maVoucher";
            cmbVoucher.DisplayMember = "moTa";
        }
        private int LastPage()
        {
            int sumRecord = HoaDonDAO.Instance.GetSoLuongHoaDon(dtpStart.Value, dtpStop.Value);
            int pageRows = (int)nUDPageRows.Value;
            int lastPage = sumRecord / pageRows;
            if (sumRecord % pageRows != 0)
                lastPage++;
            return lastPage;
        }
        void ShowHoaDon(int maHoaDon)
        {
            lsvHoaDon.Items.Clear();
            List<ChiTietHoatDon> list = ChiTietHoaDonDAO.Instance.GetListMonAnByMaHoaDon(maHoaDon);
            foreach (ChiTietHoatDon item in list)
            {
                if (item.SoLuong == 0)
                    continue;
                ListViewItem lsvItem = new ListViewItem(item.TenMonAn.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.Gia.ToString("c0"));
                lsvHoaDon.Items.Add(lsvItem);
            }
        }
        void LoadData()
        {
            dtgvHoaDon.DataSource = list;
            ResetAllTextBox();
            SetBtnEdit_Off();
            LoadListHoaDon();
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            dtgvHoaDon.Columns[9].DefaultCellStyle.Format = "c0";
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "dd/MM/yyyy";
            dtpStop.Format = DateTimePickerFormat.Custom;
            dtpStop.CustomFormat = "dd/MM/yyyy";
            dtpkNgayTao.Format = DateTimePickerFormat.Custom;
            dtpkNgayTao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpkNgayThanhToan.Format = DateTimePickerFormat.Custom;
            dtpkNgayThanhToan.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpStart.Value = new DateTime(today.Year, today.AddMonths(0).Month, 1);
            dtpStop.Value = dtpStart.Value.AddMonths(1).AddDays(-1);
            txbPage.Text = "1";
            lsvHoaDon.Items.Clear();
            LoadComboBox();
            LoadData();
        }

        private void dtgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvHoaDon.CurrentCell.RowIndex;
            txtMaHoaDon.Text = dtgvHoaDon.Rows[r].Cells[0].Value.ToString();
            cmbNhanVien.Text = dtgvHoaDon.Rows[r].Cells[1].Value.ToString();
            cmbKhachHang.Text = string.IsNullOrEmpty(dtgvHoaDon.Rows[r].Cells[2].Value.ToString())?"(Không có)": dtgvHoaDon.Rows[r].Cells[2].Value.ToString();
            cmbBan.SelectedValue = int.Parse(dtgvHoaDon.Rows[r].Cells[3].Value.ToString());
            txtDiemCong.Text = dtgvHoaDon.Rows[r].Cells[4].Value.ToString();
            txtDiemTru.Text = dtgvHoaDon.Rows[r].Cells[5].Value.ToString();
            dtpkNgayTao.Value = DateTime.Parse(dtgvHoaDon.Rows[r].Cells[6].Value.ToString());
            dtpkNgayThanhToan.Value = DateTime.Parse(dtgvHoaDon.Rows[r].Cells[7].Value.ToString());
            cmbVoucher.Text = string.IsNullOrEmpty(dtgvHoaDon.Rows[r].Cells[8].Value.ToString()) ? "(Không có)" : dtgvHoaDon.Rows[r].Cells[8].Value.ToString();
            txtTongTien.Text = int.Parse(dtgvHoaDon.Rows[r].Cells[9].Value.ToString()).ToString("c0");
            if (dtgvHoaDon.Rows[r].Cells[10].Value.ToString().Equals("Đã thanh toán"))
                radDaThanhToan.Checked = true;
            else
                radChuaThanhToan.Checked = true;
            btnEdit.Enabled = true;
            ShowHoaDon(int.Parse(dtgvHoaDon.Rows[r].Cells[0].Value.ToString()));
        }

        private void dtgvHoaDon_FilterStringChanged(object sender, EventArgs e)
        {
            list.Filter = dtgvHoaDon.FilterString;
        }

        private void dtgvHoaDon_SortStringChanged(object sender, EventArgs e)
        {
            list.Sort = dtgvHoaDon.SortString;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add = true;
            ResetAllTextBox();
            SetBtnEdit_On();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Add = false;
            dtgvHoaDon_CellClick(null, null);
            SetBtnEdit_On();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (HoaDonDAO.Instance.UpdateHoaDon(int.Parse(txtMaHoaDon.Text), int.Parse(cmbNhanVien.SelectedValue.ToString()), dtpkNgayTao.Value, dtpkNgayThanhToan.Value))
                MessageBox.Show("Sửa dữ liệu thành công!");
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetBtnEdit_Off();
            ResetAllTextBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaHoaDon.Text))
                if (MessageBox.Show("Bạn chắc chắn muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (HoaDonDAO.Instance.DeleteHoaDon(int.Parse(txtMaHoaDon.Text)))
                        MessageBox.Show("Xoá thành công!");
                    SetBtnEdit_Off();
                    LoadData();
                }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            txbPage.Text = "1";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int page = int.Parse(txbPage.Text);
            if (page > 1)
                txbPage.Text = (--page).ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int page = int.Parse(txbPage.Text);
            if (page < LastPage())
                txbPage.Text = (++page).ToString();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            txbPage.Text = LastPage().ToString();
        }

        private void nUDPageRows_ValueChanged(object sender, EventArgs e)
        {
            LoadListHoaDon();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            LoadListHoaDon();
        }

        private void dtpStop_ValueChanged(object sender, EventArgs e)
        {
            LoadListHoaDon();
        }

        private void txbPage_TextChanged(object sender, EventArgs e)
        {
            LoadListHoaDon();
        }

        private void cmbBan_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = "Bàn " + ((Ban)e.ListItem).MaBan;
        }
    }
}
