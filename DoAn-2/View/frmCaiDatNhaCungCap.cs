using restaurant_management.DAO;
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
    public partial class frmCaiDatNhaCungCap : Form
    {
        BindingSource list = new BindingSource();
        bool Add = false;
        public frmCaiDatNhaCungCap()
        {
            InitializeComponent();
        }
        void ResetAllTextBox()
        {
            txtMaNhaCungCap.ResetText();
            txtTenNhaCungCap.ResetText();
            txtDiaChi.ResetText();
            txtSDT.ResetText();
            txtEmail.ResetText();
            txtTimKiem.ResetText();
        }

        void SetBtnEdit_On()
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            grPanel.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dtgvNhaCungCap.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        void SetBtnEdit_Off()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            grPanel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            dtgvNhaCungCap.Enabled = true;
            txtTimKiem.Enabled = true;
            Add = false;
        }

        void LoadListNhaCungCap()
        {
            list.DataSource = NhaCungCapDAO.Instance.GetDataTableNhaCungCap();
            btnEdit.Enabled = list.Count > 0 ? true : false;
            btnDelete.Enabled = list.Count > 0 ? true : false;
        }

        void SearchNhaCungCap()
        {
            list.DataSource = NhaCungCapDAO.Instance.SearchNhaCungCap(txtTimKiem.Text.Trim());
            btnEdit.Enabled = list.Count > 0 ? true : false;
            btnDelete.Enabled = list.Count > 0 ? true : false;
        }

        void LoadData()
        {
            dtgvNhaCungCap.DataSource = list;
            ResetAllTextBox();
            SetBtnEdit_Off();
            LoadListNhaCungCap();
            txtTimKiem.Text = "Tên nhà cung cấp hoặc số điện thoại";
            txtTimKiem.ForeColor = Color.DarkGray;
        }

        private void frmCaiDatNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvNhaCungCap.CurrentCell.RowIndex;
            txtMaNhaCungCap.Text = dtgvNhaCungCap.Rows[r].Cells[0].Value.ToString();
            txtTenNhaCungCap.Text = dtgvNhaCungCap.Rows[r].Cells[1].Value.ToString();
            txtDiaChi.Text = dtgvNhaCungCap.Rows[r].Cells[2].Value.ToString();
            txtSDT.Text = dtgvNhaCungCap.Rows[r].Cells[3].Value.ToString();
            txtEmail.Text = dtgvNhaCungCap.Rows[r].Cells[4].Value.ToString();
            btnEdit.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add = true;
            ResetAllTextBox();
            SetBtnEdit_On();
            txtTenNhaCungCap.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Add = false;
            dtgvNhaCungCap_CellClick(null, null);
            SetBtnEdit_On();
            txtTenNhaCungCap.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtTenNhaCungCap.Text.Trim().Equals(""))
            {
                if (Add)
                {
                    if (NhaCungCapDAO.Instance.InsertNhaCungCap(txtTenNhaCungCap.Text, txtDiaChi.Text, txtSDT.Text.Replace("-", string.Empty), txtEmail.Text))
                        MessageBox.Show("Thêm dữ liệu thành công!");
                    LoadData();
                }
                else
                {
                    if (NhaCungCapDAO.Instance.UpdateNhaCungCap(int.Parse(txtMaNhaCungCap.Text), txtTenNhaCungCap.Text, txtDiaChi.Text, txtSDT.Text.Replace("-", string.Empty), txtEmail.Text))
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
                if (NhaCungCapDAO.Instance.DeleteNhaCungCap(int.Parse(txtMaNhaCungCap.Text)))
                    MessageBox.Show("Xoá thành công!");
                SetBtnEdit_Off();
                LoadData();
            }
        }

        private void dtgvNhaCungCap_FilterStringChanged(object sender, EventArgs e)
        {
            list.Filter = dtgvNhaCungCap.FilterString;
        }

        private void dtgvNhaCungCap_SortStringChanged(object sender, EventArgs e)
        {
            list.Sort = dtgvNhaCungCap.SortString;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Equals("Tên nhà cung cấp hoặc số điện thoại") || string.IsNullOrEmpty(txtTimKiem.Text))
                LoadListNhaCungCap();
            else
                SearchNhaCungCap();
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Equals("Tên nhà cung cấp hoặc số điện thoại"))
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Equals(""))
            {
                txtTimKiem.Text = "Tên nhà cung cấp hoặc số điện thoại";
                txtTimKiem.ForeColor = Color.DarkGray;
            }
        }
    }
}
