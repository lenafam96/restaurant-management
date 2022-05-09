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

namespace restaurant_management.MenuTab
{
    public partial class frmNhapKho : Form
    {
        BindingSource list = new BindingSource();
        bool Add = false;
        public frmNhapKho()
        {
            InitializeComponent();
        }
        void ResetAllTextBox()
        {
            txtMaPhieuNhap.ResetText();
            cmbNhaCungCap.ResetText();
            nbuGia.Value = 0;
            nbuSoLuong.Value = 0;
            txtTongTien.ResetText();
            cmbThucPham.ResetText();
        }

        void SetBtnEdit_On()
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            grPanel.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dtgvPhieuNhap.Enabled = false;
        }

        void SetBtnEdit_Off()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            grPanel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            dtgvPhieuNhap.Enabled = true;
            Add = false;
        }

        void LoadListPhieuNhap()
        {
            list.DataSource = PhieuNhapDAO.Instance.GetDataTablePhieuNhap();
            btnEdit.Enabled = list.Count > 0 ? true : false;
            btnDelete.Enabled = list.Count > 0 ? true : false;
        }

        void LoadChiTietPhieuNhap(int maPhieuNhap)
        {
            int tongTien = 0;
            lsvChiTietPhieuNhap.Items.Clear();
            List<ChiTietPhieuNhap> listChiTietPhieuNhap = ChiTietPhieuNhapDAO.Instance.GetListThucPhamByMaPhieuNhap(maPhieuNhap);
            foreach (ChiTietPhieuNhap item in listChiTietPhieuNhap)
            {
                if (item.SoLuong == 0)
                    continue;
                ListViewItem lsvItem = new ListViewItem((lsvChiTietPhieuNhap.Items.Count + 1).ToString());
                lsvItem.SubItems.Add(item.TenThucPham.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.DonViTinh.ToString());
                lsvItem.SubItems.Add(item.Gia.ToString());
                lsvItem.Tag = item;
                tongTien += item.Gia * item.SoLuong;
                lsvChiTietPhieuNhap.Items.Add(lsvItem);
            }
            PhieuNhapDAO.Instance.UpdateTongTienPhieuNhap(maPhieuNhap, tongTien);
            txtTongTien.Text = tongTien.ToString();
            dtgvPhieuNhap.Rows[dtgvPhieuNhap.CurrentCell.RowIndex].Cells[3].Value = tongTien;
        }

        void LoadData()
        {
            dtgvPhieuNhap.DataSource = list;
            ResetAllTextBox();
            SetBtnEdit_Off();
            LoadListPhieuNhap();
            cmbNhaCungCap.DataSource = NhaCungCapDAO.Instance.GetListNhaCungCap();
            cmbNhaCungCap.ValueMember = "maNhaCungCap";
            cmbNhaCungCap.DisplayMember = "tenNhaCungCap";
            cmbThucPham.DataSource = ThucPhamDAO.Instance.GetListThucPham();
            cmbThucPham.ValueMember = "maThucPham";
            cmbThucPham.DisplayMember = "tenThucPham";
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            dtgvPhieuNhap.Columns[3].DefaultCellStyle.Format = "c0";
        }
        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvPhieuNhap.CurrentCell.RowIndex;
            txtMaPhieuNhap.Text = dtgvPhieuNhap.Rows[r].Cells[0].Value.ToString();
            cmbNhaCungCap.Text = dtgvPhieuNhap.Rows[r].Cells[1].Value.ToString();
            dtpkNgayNhap.Value = DateTime.Parse(dtgvPhieuNhap.Rows[r].Cells[2].Value.ToString());
            txtTongTien.Text = dtgvPhieuNhap.Rows[r].Cells[3].Value.ToString();
            btnEdit.Enabled = true;
            LoadChiTietPhieuNhap(int.Parse(dtgvPhieuNhap.Rows[r].Cells[0].Value.ToString()));
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
            dtgvPhieuNhap_CellClick(null, null);
            SetBtnEdit_On();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                if (PhieuNhapDAO.Instance.InsertPhieuNhap(int.Parse(cmbNhaCungCap.SelectedValue.ToString()), dtpkNgayNhap.Value))
                    MessageBox.Show("Thêm dữ liệu thành công!");
                LoadData();
            }
            else
            {
                if (PhieuNhapDAO.Instance.UpdatePhieuNhap(int.Parse(txtMaPhieuNhap.Text), int.Parse(cmbNhaCungCap.SelectedValue.ToString()), dtpkNgayNhap.Value))
                    MessageBox.Show("Sửa dữ liệu thành công!");
                LoadData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetBtnEdit_Off();
            ResetAllTextBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (PhieuNhapDAO.Instance.DeletePhieuNhap(int.Parse(txtMaPhieuNhap.Text)))
                    MessageBox.Show("Xoá thành công!");
                SetBtnEdit_Off();
                LoadData();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaPhieuNhap.Text))
            {
                int maPhieuNhap = int.Parse(txtMaPhieuNhap.Text);
                int maThucPham = int.Parse(cmbThucPham.SelectedValue.ToString());
                if (ChiTietPhieuNhapDAO.Instance.CheckThucPhamTrongPhieuNhap(maPhieuNhap, maThucPham) !=null)
                {
                    ChiTietPhieuNhap chiTietPhieuNhap = ChiTietPhieuNhapDAO.Instance.CheckThucPhamTrongPhieuNhap(maPhieuNhap, maThucPham);
                    ChiTietPhieuNhapDAO.Instance.CapNhatThucPhamVaoPhieuNhap(maPhieuNhap, maThucPham, (int)nbuSoLuong.Value, (int)nbuGia.Value);
                    ThucPhamDAO.Instance.UpdateSoLuongThucPham(maThucPham, chiTietPhieuNhap.SoLuong - (int)nbuSoLuong.Value);
                }    
                else
                {
                    ChiTietPhieuNhapDAO.Instance.ThemThucPhamVaoPhieuNhap(maPhieuNhap, maThucPham, (int)nbuSoLuong.Value, (int)nbuGia.Value);
                    ThucPhamDAO.Instance.UpdateSoLuongThucPham(maThucPham, (int)nbuSoLuong.Value * -1);
                }    
                
            LoadChiTietPhieuNhap(int.Parse(txtMaPhieuNhap.Text));
            }
        }

        private void dtgvPhieuNhap_FilterStringChanged(object sender, EventArgs e)
        {
            list.Filter = dtgvPhieuNhap.FilterString;
        }

        private void dtgvPhieuNhap_SortStringChanged(object sender, EventArgs e)
        {
            list.Sort = dtgvPhieuNhap.SortString;
        }

        private void lsvChiTietPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvChiTietPhieuNhap.SelectedIndices.Count == 1)
            {
                ChiTietPhieuNhap tmp = lsvChiTietPhieuNhap.Items[lsvChiTietPhieuNhap.SelectedIndices[0]].Tag as ChiTietPhieuNhap;
                cmbThucPham.Text = tmp.TenThucPham;
                nbuSoLuong.Value = tmp.SoLuong;
                nbuGia.Value = tmp.Gia;
            }
        }
    }
}
