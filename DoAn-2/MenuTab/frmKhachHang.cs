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

namespace restaurant_management.MenuTab
{
    public partial class frmKhachHang : Form
    {
        BindingSource list = new BindingSource();
        bool Add = false;

        public frmKhachHang()
        {
            InitializeComponent();
        }

        void ResetAllTextBox()
        {
            txtMaKhachHang.ResetText();
            txtTenKhachHang.ResetText();
            txtSDT.ResetText();
            txtDiemTichLuy.ResetText();
            txtTimKiem.ResetText();
            dtpkNgaySinh.ResetText();
            radNam.Checked = radNu.Checked = false;
        }

        void SetBtnEdit_On()
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            grPanel.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dtgvKhachHang.Enabled = false;
        }

        void SetBtnEdit_Off()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            grPanel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            dtgvKhachHang.Enabled = true;
            Add = false;
        }

        void LoadListKhachHang()
        {
            list.DataSource = KhachHangDAO.Instance.GetListKhachHang();
            btnEdit.Enabled = list.Count > 0 ? true : false;
            btnDelete.Enabled = list.Count > 0 ? true : false;
        }

        void SearchKhachHang()
        {
            list.DataSource = KhachHangDAO.Instance.SearchKhachHang(txtTimKiem.Text.Trim());
            btnEdit.Enabled = list.Count > 0 ? true : false;
            btnDelete.Enabled = list.Count > 0 ? true : false;
        }

        void LoadData()
        {
            dtgvKhachHang.DataSource = list;
            ResetAllTextBox();
            SetBtnEdit_Off();
            LoadListKhachHang();
            txtTimKiem.Text = "Tên khách hàng hoặc số điện thoại";
            txtTimKiem.ForeColor = Color.DarkGray;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            dtpkNgaySinh.MaxDate = DateTime.Now;
        }

        private void dtgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvKhachHang.CurrentCell.RowIndex;
            txtMaKhachHang.Text = dtgvKhachHang.Rows[r].Cells[0].Value.ToString();
            txtTenKhachHang.Text = dtgvKhachHang.Rows[r].Cells[1].Value.ToString();
            dtpkNgaySinh.Value = DateTime.Parse(dtgvKhachHang.Rows[r].Cells[2].Value.ToString());
            if (dtgvKhachHang.Rows[r].Cells[3].Value.ToString() == "Nam")
                radNam.Checked = true;
            else 
                radNu.Checked = true;
            txtSDT.Text = dtgvKhachHang.Rows[r].Cells[4].Value.ToString();
            txtDiemTichLuy.Text = dtgvKhachHang.Rows[r].Cells[5].Value.ToString();
            btnEdit.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add = true;
            ResetAllTextBox();
            SetBtnEdit_On();
            txtTenKhachHang.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Add = false;
            dtgvKhachHang_CellClick(null, null);
            SetBtnEdit_On();
            txtTenKhachHang.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtTenKhachHang.Text.Trim().Equals(""))
            {
                if (Add)
                {
                    if (KhachHangDAO.Instance.InsertKhachHang(txtTenKhachHang.Text,dtpkNgaySinh.Value,radNam.Checked?"Nam":"Nữ", txtSDT.Text.Replace("-", string.Empty)))
                        MessageBox.Show("Thêm dữ liệu thành công!");
                    LoadData();
                }
                else
                {
                    if (KhachHangDAO.Instance.UpdateKhachHang(int.Parse(txtMaKhachHang.Text), txtTenKhachHang.Text, dtpkNgaySinh.Value, radNam.Checked ? "Nam" : "Nữ", txtSDT.Text.Replace("-", string.Empty)))
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
                if (KhachHangDAO.Instance.DeleteKhachHang(int.Parse(txtMaKhachHang.Text)))
                    MessageBox.Show("Xoá thành công!");
                SetBtnEdit_Off();
                LoadData();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Equals("Tên khách hàng hoặc số điện thoại") || string.IsNullOrEmpty(txtTimKiem.Text))
                LoadListKhachHang();
            else
                SearchKhachHang();
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Equals("Tên khách hàng hoặc số điện thoại"))
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }    
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Equals(""))
            {
                txtTimKiem.Text = "Tên khách hàng hoặc số điện thoại";
                txtTimKiem.ForeColor = Color.DarkGray;
            }
        }

        private void dtgvKhachHang_SortStringChanged(object sender, EventArgs e)
        {
            list.Sort = dtgvKhachHang.SortString;
        }

        private void dtgvKhachHang_FilterStringChanged(object sender, EventArgs e)
        {
            list.Filter = dtgvKhachHang.FilterString;
        }
    }
}
