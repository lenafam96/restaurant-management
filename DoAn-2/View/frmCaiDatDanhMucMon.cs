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

namespace restaurant_management.View
{
    public partial class frmCaiDatDanhMucMon : Form
    {
        BindingSource list = new BindingSource();
        bool Add = false;
        bool checkTenDanhMucMon;
        public frmCaiDatDanhMucMon()
        {
            InitializeComponent();
        }
        void ResetAllTextBox()
        {
            txtMaDanhMucMon.ResetText();
            txtTenDanhMucMon.ResetText();
        }

        void SetBtnEdit_On()
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            grPanel.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dtgvDanhMucMon.Enabled = false;
        }

        void SetBtnEdit_Off()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            grPanel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            dtgvDanhMucMon.Enabled = true;
            Add = false;
        }

        void LoadListDanhMuc()
        {
            list.DataSource = DanhMucMonDAO.Instance.GetDataTableDanhMucMon();
            btnEdit.Enabled = list.Count > 0 ? true : false;
            btnDelete.Enabled = list.Count > 0 ? true : false;
        }

        void LoadData()
        {
            dtgvDanhMucMon.DataSource = list;
            ResetAllTextBox();
            SetBtnEdit_Off();
            LoadListDanhMuc();
        }

        private void frmCaiDatDanhMucMon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvDanhMucMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvDanhMucMon.CurrentCell.RowIndex;
            txtMaDanhMucMon.Text = dtgvDanhMucMon.Rows[r].Cells[0].Value.ToString();
            txtTenDanhMucMon.Text = dtgvDanhMucMon.Rows[r].Cells[1].Value.ToString();
            btnEdit.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add = true;
            ResetAllTextBox();
            SetBtnEdit_On();
            txtTenDanhMucMon.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Add = false;
            dtgvDanhMucMon_CellClick(null, null);
            SetBtnEdit_On();
            txtTenDanhMucMon.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkTenDanhMucMon)
            {
                if (Add)
                {
                    if (DanhMucMonDAO.Instance.InsertDanhMucMon(txtTenDanhMucMon.Text))
                        MessageBox.Show("Thêm dữ liệu thành công!");
                    LoadData();
                }
                else
                {
                    if (DanhMucMonDAO.Instance.UpdateDanhMucMon(int.Parse(txtMaDanhMucMon.Text), txtTenDanhMucMon.Text))
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
            if (!string.IsNullOrEmpty(txtMaDanhMucMon.Text))
                if (MessageBox.Show("Bạn chắc chắn muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DanhMucMonDAO.Instance.DeleteDanhMucMon(int.Parse(txtMaDanhMucMon.Text)))
                        MessageBox.Show("Xoá thành công!");
                    SetBtnEdit_Off();
                    LoadData();
                }
        }

        private void txtTenDanhMucMon_Leave(object sender, EventArgs e)
        {
            checkTenDanhMucMon = false;
            if (string.IsNullOrEmpty(txtTenDanhMucMon.Text))
            {
                errorProviderTenDanhMucMon.SetError(txtTenDanhMucMon, "Tên thực phẩm không được để trống!");
            }
            else if (DanhMucMonDAO.Instance.CheckTenDanhMucMonExist(txtTenDanhMucMon.Text))
            {
                errorProviderTenDanhMucMon.SetError(txtTenDanhMucMon, "Tên thực phẩm đã tồn tại!");
            }
            else
            {
                errorProviderTenDanhMucMon.Clear();
                checkTenDanhMucMon = true;
            }
        }

        private void dtgvDanhMucMon_FilterStringChanged(object sender, EventArgs e)
        {
            list.Filter = dtgvDanhMucMon.FilterString;
        }

        private void dtgvDanhMucMon_SortStringChanged(object sender, EventArgs e)
        {
            list.Sort = dtgvDanhMucMon.SortString;
        }
    }
}
