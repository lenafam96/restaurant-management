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
    public partial class frmTonKho : Form
    {
        BindingSource list = new BindingSource();
        bool Add = false;
        bool checkTenThucPham;
        bool checkDonViTinh;
        public frmTonKho()
        {
            InitializeComponent();
        }
        void ResetAllTextBox()
        {
            txtMaThucPham.ResetText();
            txtTenThucPham.ResetText();
            txtDonViTinh.ResetText();
            txtTonKho.ResetText();
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
            dtgvThucPham.Enabled = false;
        }

        void SetBtnEdit_Off()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            grPanel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            dtgvThucPham.Enabled = true;
            Add = false;
        }

        void LoadListThucPham()
        {
            list.DataSource = ThucPhamDAO.Instance.GetDataTableThucPham();
            btnEdit.Enabled = list.Count > 0 ? true : false;
            btnDelete.Enabled = list.Count > 0 ? true : false;
        }

        void SearchThucPham()
        {
            list.DataSource = ThucPhamDAO.Instance.SearchThucPham(txtTimKiem.Text.Trim());
            btnEdit.Enabled = list.Count > 0 ? true : false;
            btnDelete.Enabled = list.Count > 0 ? true : false;
        }

        void LoadData()
        {
            dtgvThucPham.DataSource = list;
            ResetAllTextBox();
            SetBtnEdit_Off();
            LoadListThucPham();
            SetCollectionUnit();
            txtTimKiem.Text = "Tên thực phẩm";
            txtTimKiem.ForeColor = Color.DarkGray;
            dtgvThucPham.Columns[3].DefaultCellStyle.Format = "n0";
        }

        void SetCollectionUnit()
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            txtDonViTinh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtDonViTinh.AutoCompleteSource = AutoCompleteSource.CustomSource;
            List<string> listDonViTinh = ThucPhamDAO.Instance.GetListDonViTinh();
            foreach (string item in listDonViTinh)
                auto.Add(item);
            txtDonViTinh.AutoCompleteCustomSource = auto;
        }

        private void frmTonKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dtgvThucPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvThucPham.CurrentCell.RowIndex;
            txtMaThucPham.Text = dtgvThucPham.Rows[r].Cells[0].Value.ToString();
            txtTenThucPham.Text = dtgvThucPham.Rows[r].Cells[1].Value.ToString();
            txtDonViTinh.Text = dtgvThucPham.Rows[r].Cells[2].Value.ToString();
            txtTonKho.Text = dtgvThucPham.Rows[r].Cells[3].Value.ToString();
            btnEdit.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add = true;
            ResetAllTextBox();
            SetBtnEdit_On();
            txtTenThucPham.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Add = false;
            dtgvThucPham_CellClick(null, null);
            SetBtnEdit_On();
            txtTenThucPham.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkTenThucPham && checkDonViTinh)
            {
                if (Add)
                {
                    if (ThucPhamDAO.Instance.InsertThucPham(txtTenThucPham.Text, txtDonViTinh.Text))
                        MessageBox.Show("Thêm dữ liệu thành công!");
                    LoadData();
                }
                else
                {
                    if (ThucPhamDAO.Instance.UpdateThucPham(int.Parse(txtMaThucPham.Text), txtTenThucPham.Text, txtDonViTinh.Text))
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
                if (ThucPhamDAO.Instance.DeleteThucPham(int.Parse(txtMaThucPham.Text)))
                    MessageBox.Show("Xoá thành công!");
                SetBtnEdit_Off();
                LoadData();
            }
        }

        private void txtTenThucPham_Leave(object sender, EventArgs e)
        {
            if (Add)
            {
                checkTenThucPham = false;
                if (string.IsNullOrEmpty(txtTenThucPham.Text))
                {
                    errorProviderTenThucPham.SetError(txtTenThucPham, "Tên thực phẩm không được để trống!");
                }
                else if (ThucPhamDAO.Instance.CheckTenThucPhamExist(txtTenThucPham.Text))
                {
                    errorProviderTenThucPham.SetError(txtTenThucPham, "Tên thực phẩm đã tồn tại!");
                }
                else
                {
                    errorProviderTenThucPham.Clear();
                    checkTenThucPham = true;
                }
            }
            else
            {
                checkTenThucPham = false;
                if (string.IsNullOrEmpty(txtTenThucPham.Text))
                {
                    errorProviderTenThucPham.SetError(txtTenThucPham, "Tên thực phẩm không được để trống!");
                }
                else
                {
                    errorProviderTenThucPham.Clear();
                    checkTenThucPham = true;
                }
            }
        }

        private void txtDonViTinh_Leave(object sender, EventArgs e)
        {
            checkDonViTinh = false;
            if (string.IsNullOrEmpty(txtDonViTinh.Text))
            {
                errorProviderDonViTinh.SetError(txtDonViTinh, "Đơn vị tính không được để trống!");
            }
            else
            {
                errorProviderDonViTinh.Clear();
                checkDonViTinh = true;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Equals("Tên thực phẩm") || string.IsNullOrEmpty(txtTimKiem.Text))
                LoadListThucPham();
            else
                SearchThucPham();
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Equals("Tên thực phẩm"))
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Equals(""))
            {
                txtTimKiem.Text = "Tên thực phẩm";
                txtTimKiem.ForeColor = Color.DarkGray;
            }
        }

        private void dtgvThucPham_FilterStringChanged(object sender, EventArgs e)
        {
            list.Filter = dtgvThucPham.FilterString;
        }

        private void dtgvThucPham_SortStringChanged(object sender, EventArgs e)
        {
            list.Sort = dtgvThucPham.SortString;
        }
    }
}
