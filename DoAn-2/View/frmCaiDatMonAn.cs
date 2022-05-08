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
    public partial class frmCaiDatMonAn : Form
    {
        BindingSource list = new BindingSource();
        bool Add = false;
        bool checkTenMonAn;
        public frmCaiDatMonAn()
        {
            InitializeComponent();
        }
        void ResetAllTextBox()
        {
            txtMaMonAn.ResetText();
            txtTenMonAn.ResetText();
            nbuGia.Value = 0;
            cmbDanhMuc.ResetText();
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
            dtgvMonAn.Enabled = false;
        }

        void SetBtnEdit_Off()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            grPanel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            dtgvMonAn.Enabled = true;
            Add = false;
        }

        void LoadListMonAn()
        {
            list.DataSource = MonAnDAO.Instance.GetDataTableMonAn();
            btnEdit.Enabled = list.Count > 0 ? true : false;
            btnDelete.Enabled = list.Count > 0 ? true : false;
        }

        void LoadChiTietMonAn(int maMonAn)
        {
            lsvChiTietMonAn.Items.Clear();
            List<ChiTietMonAn> listChiTietMonAn = ChiTietMonAnDAO.Instance.GetListThucPhamByMaMonAn(maMonAn);
            foreach (ChiTietMonAn item in listChiTietMonAn)
            {
                if (item.SoLuong == 0)
                    continue;
                ListViewItem lsvItem = new ListViewItem((lsvChiTietMonAn.Items.Count + 1).ToString());
                lsvItem.SubItems.Add(item.TenThucPham.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.DonViTinh.ToString());
                lsvItem.Tag = item;
                lsvChiTietMonAn.Items.Add(lsvItem);
            }
        }

        void LoadData()
        {
            dtgvMonAn.DataSource = list;
            ResetAllTextBox();
            SetBtnEdit_Off();
            LoadListMonAn();
            cmbDanhMuc.DataSource = DanhMucMonDAO.Instance.GetListDanhMucMon();
            cmbDanhMuc.ValueMember = "maDanhMucMon";
            cmbDanhMuc.DisplayMember = "tenDanhMucMon";
            cmbThucPham.DataSource = ThucPhamDAO.Instance.GetListThucPham();
            cmbThucPham.ValueMember = "maThucPham";
            cmbThucPham.DisplayMember = "tenThucPham";
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            dtgvMonAn.Columns[2].DefaultCellStyle.Format = "c0";
        }
        private void frmCaiDatMonAn_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvMonAn.CurrentCell.RowIndex;
            txtMaMonAn.Text = dtgvMonAn.Rows[r].Cells[0].Value.ToString();
            txtTenMonAn.Text = dtgvMonAn.Rows[r].Cells[1].Value.ToString();
            nbuGia.Value = int.Parse(dtgvMonAn.Rows[r].Cells[2].Value.ToString());
            cmbDanhMuc.Text = dtgvMonAn.Rows[r].Cells[3].Value.ToString();
            btnEdit.Enabled = true;
            LoadChiTietMonAn(int.Parse(dtgvMonAn.Rows[r].Cells[0].Value.ToString()));
        }

        private void txtTenMonAn_Leave(object sender, EventArgs e)
        {
            checkTenMonAn = false;
            if (string.IsNullOrEmpty(txtTenMonAn.Text))
            {
                errorProviderTenMonAn.SetError(txtTenMonAn, "Tên thực phẩm không được để trống!");
            }
            else if (DanhMucMonDAO.Instance.CheckTenDanhMucMonExist(txtTenMonAn.Text))
            {
                errorProviderTenMonAn.SetError(txtTenMonAn, "Tên thực phẩm đã tồn tại!");
            }
            else
            {
                errorProviderTenMonAn.Clear();
                checkTenMonAn = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add = true;
            ResetAllTextBox();
            SetBtnEdit_On();
            txtTenMonAn.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Add = false;
            dtgvMonAn_CellClick(null, null);
            SetBtnEdit_On();
            txtTenMonAn.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkTenMonAn)
            {
                if (Add)
                {
                    if (MonAnDAO.Instance.InsertMonAn(txtTenMonAn.Text, int.Parse(nbuGia.Value.ToString()), int.Parse(cmbDanhMuc.SelectedValue.ToString())))
                        MessageBox.Show("Thêm dữ liệu thành công!");
                    LoadData();
                }
                else
                {
                    if (MonAnDAO.Instance.UpdateMonAn(int.Parse(txtMaMonAn.Text), txtTenMonAn.Text, int.Parse(nbuGia.Value.ToString()), int.Parse(cmbDanhMuc.SelectedValue.ToString())))
                        MessageBox.Show("Sửa dữ liệu thành công!");
                    LoadData();
                }
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
                if (MonAnDAO.Instance.DeleteMonAn(int.Parse(txtMaMonAn.Text)))
                    MessageBox.Show("Xoá thành công!");
                SetBtnEdit_Off();
                LoadData();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaMonAn.Text))
            {
                if (ChiTietMonAnDAO.Instance.CheckThucPhamTrongMonAn(int.Parse(txtMaMonAn.Text), int.Parse(cmbThucPham.SelectedValue.ToString())))
                    ChiTietMonAnDAO.Instance.CapNhatThucPhamVaoMonAn(int.Parse(txtMaMonAn.Text), int.Parse(cmbThucPham.SelectedValue.ToString()), (int)nbuSoLuong.Value);
                else
                    ChiTietMonAnDAO.Instance.ThemThucPhamVaoMonAn(int.Parse(txtMaMonAn.Text), int.Parse(cmbThucPham.SelectedValue.ToString()), (int)nbuSoLuong.Value);
            }
            LoadChiTietMonAn(int.Parse(txtMaMonAn.Text));
        }

        private void dtgvMonAn_FilterStringChanged(object sender, EventArgs e)
        {
            list.Filter = dtgvMonAn.FilterString;
        }

        private void dtgvMonAn_SortStringChanged(object sender, EventArgs e)
        {
            list.Sort = dtgvMonAn.SortString;
        }

        private void lsvChiTietMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvChiTietMonAn.SelectedIndices.Count == 1)
            {
                ChiTietMonAn tmp = lsvChiTietMonAn.Items[lsvChiTietMonAn.SelectedIndices[0]].Tag as ChiTietMonAn;
                cmbThucPham.Text = tmp.TenThucPham;
                nbuSoLuong.Value = tmp.SoLuong;
            }
        }

        private void cmbThucPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
