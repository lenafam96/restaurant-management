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

namespace restaurant_management.MenuTab
{
    public partial class frmNhanVien : Form
    {
        BindingSource list = new BindingSource();
        bool Add = false;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        void ResetAllTextBox()
        {
            txtMaNhanVien.ResetText();
            txtTenNhanVien.ResetText();
            txtChucVu.ResetText();
            txtSDT.ResetText();
            txtCCCD.ResetText();
            txtTimKiem.ResetText();
            nbuLuong.Value = 0;
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
            dtgvNhanVien.Enabled = false;
        }

        void SetBtnEdit_Off()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            grPanel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            dtgvNhanVien.Enabled = true;
            Add = false;
        }

        void LoadListNhanVien()
        {
            list.DataSource = NhanVienDAO.Instance.GetDataTableNhanVien();
            btnEdit.Enabled = list.Count > 0 ? true : false;
            btnDelete.Enabled = list.Count > 0 ? true : false;
        }

        void SearchNhanVien()
        {
            list.DataSource = NhanVienDAO.Instance.SearchNhanVien(txtTimKiem.Text.Trim());
            btnEdit.Enabled = list.Count > 0 ? true : false;
            btnDelete.Enabled = list.Count > 0 ? true : false;
        }

        void LoadData()
        {
            dtgvNhanVien.DataSource = list;
            ResetAllTextBox();
            SetBtnEdit_Off();
            LoadListNhanVien();
            txtTimKiem.Text = "Tên nhân viên hoặc số điện thoại";
            txtTimKiem.ForeColor = Color.DarkGray;
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            dtgvNhanVien.Columns[7].DefaultCellStyle.Format = "c0";
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            dtpkNgaySinh.MaxDate = DateTime.Now.AddYears(-18).AddDays(-1);
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvNhanVien.CurrentCell.RowIndex;
            txtMaNhanVien.Text = dtgvNhanVien.Rows[r].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dtgvNhanVien.Rows[r].Cells[1].Value.ToString();
            dtpkNgaySinh.Value = DateTime.Parse(dtgvNhanVien.Rows[r].Cells[2].Value.ToString());
            if (dtgvNhanVien.Rows[r].Cells[3].Value.ToString() == "Nam")
                radNam.Checked = true;
            else
                radNu.Checked = true;
            txtChucVu.Text = dtgvNhanVien.Rows[r].Cells[4].Value.ToString();
            txtSDT.Text = dtgvNhanVien.Rows[r].Cells[5].Value.ToString();
            txtCCCD.Text = dtgvNhanVien.Rows[r].Cells[6].Value.ToString();
            nbuLuong.Value = int.Parse(dtgvNhanVien.Rows[r].Cells[7].Value.ToString());
            btnEdit.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add = true;
            ResetAllTextBox();
            SetBtnEdit_On();
            txtTenNhanVien.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Add = false;
            dtgvNhanVien_CellClick(null, null);
            SetBtnEdit_On();
            txtTenNhanVien.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtTenNhanVien.Text.Trim().Equals(""))
            {
                if (Add)
                {
                    if (NhanVienDAO.Instance.InsertNhanVien(txtTenNhanVien.Text, dtpkNgaySinh.Value, radNam.Checked ? "Nam" : "Nữ", txtChucVu.Text, txtSDT.Text.Replace("-", string.Empty), txtCCCD.Text, int.Parse(nbuLuong.Value.ToString())))
                        MessageBox.Show("Thêm dữ liệu thành công!");
                    LoadData();
                }
                else
                {
                    if (NhanVienDAO.Instance.UpdateNhanVien(int.Parse(txtMaNhanVien.Text), txtTenNhanVien.Text, dtpkNgaySinh.Value, radNam.Checked ? "Nam" : "Nữ", txtChucVu.Text, txtSDT.Text.Replace("-", string.Empty), txtCCCD.Text, int.Parse(nbuLuong.Value.ToString())))
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
            if(!string.IsNullOrEmpty(txtMaNhanVien.Text))
                if (MessageBox.Show("Bạn chắc chắn muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (NhanVienDAO.Instance.DeleteNhanVien(int.Parse(txtMaNhanVien.Text)))
                        MessageBox.Show("Xoá thành công!");
                    SetBtnEdit_Off();
                    LoadData();
                }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Equals("Tên nhân viên hoặc số điện thoại") || string.IsNullOrEmpty(txtTimKiem.Text))
                LoadListNhanVien();
            else
                SearchNhanVien();
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Equals("Tên nhân viên hoặc số điện thoại"))
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Equals(""))
            {
                txtTimKiem.Text = "Tên nhân viên hoặc số điện thoại";
                txtTimKiem.ForeColor = Color.DarkGray;
            }
        }

        private void dtgvNhanVien_SortStringChanged(object sender, EventArgs e)
        {
            list.Sort = dtgvNhanVien.SortString;
        }

        private void dtgvNhanVien_FilterStringChanged(object sender, EventArgs e)
        {
            list.Filter = dtgvNhanVien.FilterString;
        }
    }
}
