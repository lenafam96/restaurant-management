using restaurant_management.DAO;
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
    public partial class frmVoucher : Form
    {
        BindingSource list = new BindingSource();
        bool Add = false;
        public frmVoucher()
        {
            InitializeComponent();
        }
        void ResetAllTextBox()
        {
            txtMaVoucher.ResetText();
            txtMoTa.ResetText();
            dtpkNgayBD.ResetText();
            dtpkNgayKT.ResetText();
            radPhanTram.Checked = radTienMat.Checked = false;
        }

        void SetBtnEdit_On()
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            grPanel.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dtgvVoucher.Enabled = false;
        }

        void SetBtnEdit_Off()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            grPanel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            dtgvVoucher.Enabled = true;
            Add = false;
        }

        void LoadListKhachHang()
        {
            list.DataSource = VoucherDAO.Instance.GetListVoucher();
            btnEdit.Enabled = list.Count > 0 ? true : false;
            btnDelete.Enabled = list.Count > 0 ? true : false;
        }

        void LoadData()
        {
            dtgvVoucher.DataSource = list;
            ResetAllTextBox();
            SetBtnEdit_Off();
            LoadListKhachHang();
        }

        private void frmVoucher_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add = true;
            ResetAllTextBox();
            SetBtnEdit_On();
            nbuGiaTri.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Add = false;
            dtgvVoucher_CellClick(null, null);
            SetBtnEdit_On();
            nbuGiaTri.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                if (VoucherDAO.Instance.InsertVoucher(dtpkNgayBD.Value, dtpkNgayKT.Value, txtMoTa.Text, int.Parse(nbuGiaTri.Value.ToString()), radPhanTram.Checked ? 0 : 1))
                    MessageBox.Show("Thêm dữ liệu thành công!");
                LoadData();
            }
            else
            {
                if (VoucherDAO.Instance.UpdateVoucher(int.Parse(txtMaVoucher.Text), dtpkNgayBD.Value, dtpkNgayKT.Value, txtMoTa.Text, int.Parse(nbuGiaTri.Value.ToString()), radPhanTram.Checked ? 0 : 1))
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
                if (VoucherDAO.Instance.DeleteVoucher(int.Parse(txtMaVoucher.Text)))
                    MessageBox.Show("Xoá thành công!");
                SetBtnEdit_Off();
                LoadData();
            }
        }

        private void dtgvKhachHang_SortStringChanged(object sender, EventArgs e)
        {
            list.Sort = dtgvVoucher.SortString;
        }

        private void dtgvKhachHang_FilterStringChanged(object sender, EventArgs e)
        {
            list.Filter = dtgvVoucher.FilterString;
        }

        private void dtgvVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvVoucher.CurrentCell.RowIndex;
            txtMaVoucher.Text = dtgvVoucher.Rows[r].Cells[0].Value.ToString();
            dtpkNgayBD.Value = DateTime.Parse(dtgvVoucher.Rows[r].Cells[1].Value.ToString());
            dtpkNgayKT.Value = DateTime.Parse(dtgvVoucher.Rows[r].Cells[2].Value.ToString());
            txtMoTa.Text = dtgvVoucher.Rows[r].Cells[3].Value.ToString();
            if (dtgvVoucher.Rows[r].Cells[5].Value.ToString() == "Phần trăm")
                radPhanTram.Checked = true;
            else
                radTienMat.Checked = true;
            nbuGiaTri.Value = int.Parse(dtgvVoucher.Rows[r].Cells[4].Value.ToString());
            btnEdit.Enabled = true;
        }

        private void radPhanTram_CheckedChanged(object sender, EventArgs e)
        {
            nbuGiaTri.Maximum = radTienMat.Checked ? int.MaxValue : 100;
        }
    }
}
