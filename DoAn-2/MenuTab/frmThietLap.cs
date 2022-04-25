using restaurant_management.DAO;
using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_management.MenuTab
{
    public partial class frmThietLap : Form
    {
        bool Add = false;
        bool userNameCheck;
        public frmThietLap()
        {
            InitializeComponent();
        }
        void ResetAllTextBox()
        {
            txtUserName.ResetText();
            txtDisplayName.ResetText();
        }

        void SetBtnEdit_On()
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            grPanel.Enabled = true;
            btnReset.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnExit.Enabled = false;
            dtgvAccount.Enabled = false;
        }

        void SetBtnEdit_Off()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            grPanel.Enabled = false;
            btnReset.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnExit.Enabled = true;
            dtgvAccount.Enabled = true;
            Add = false;
        }

        void LoadData()
        {
            ResetAllTextBox();
            SetBtnEdit_Off();
            List<Account> list = AccountDAO.Instance.GetAccountList();
            dtgvAccount.DataSource = list;
            dtgvAccount.ReadOnly = true;
            dtgvAccount.Columns[0].HeaderText = "Tên đăng nhập";
            dtgvAccount.Columns[1].HeaderText = "Tên hiển thị";
            dtgvAccount.Columns[2].Visible = false;
            dtgvAccount.Columns[3].HeaderText = "Loại tài khoản";
            dtgvAccount.RowHeadersVisible = false;
            txtUserName.Text = dtgvAccount == null ? "" : dtgvAccount.Rows[0].Cells[0].Value.ToString();
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        int TypeAccountSelected()
        {
            if (radioOngChu.Checked)
                return 1;
            if (radioQuanTriVien.Checked)
                return 2;
            if (radioQuanKho.Checked)
                return 3;
            if (radioThuNgan.Checked)
                return 4;
            return 5;
        }

        private void dtgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvAccount.CurrentCell.RowIndex;
            txtUserName.Text = dtgvAccount.Rows[r].Cells[0].Value.ToString();
            txtDisplayName.Text = dtgvAccount.Rows[r].Cells[1].Value.ToString();
            switch (dtgvAccount.Rows[r].Cells[3].Value.ToString())
            {
                case "Ông chủ": radioOngChu.Checked = true; break;
                case "Quản trị viên": radioQuanTriVien.Checked = true; break;
                case "Quản kho": radioQuanKho.Checked = true; break;
                case "Thu ngân": radioThuNgan.Checked = true; break;
                case "Phục vụ": radioPhucVu.Checked = true; break;
            }
            btnEdit.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add = true;
            ResetAllTextBox();
            SetBtnEdit_On();
            btnReset.Enabled = false;
            txtUserName.Enabled = txtDisplayName.Enabled = true;
            txtUserName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = false;
            Add = false;
            dtgvOrder_CellClick(null, null);
            SetBtnEdit_On();
            txtDisplayName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                if(userNameCheck)
                {
                    bool count = AccountDAO.Instance.CreateNewAccount(txtUserName.Text, txtDisplayName.Text, TypeAccountSelected());
                    LoadData();
                    if (count)
                        MessageBox.Show("Thêm tài khoản thành công!");
                }    
            }
            else
            {
                bool count = AccountDAO.Instance.UpdateAccountRole(txtUserName.Text, txtDisplayName.Text, TypeAccountSelected());
                LoadData();
                if (count)
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetBtnEdit_Off();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool count = AccountDAO.Instance.DeleteAccountByUserName(txtUserName.Text);
                LoadData();
                if (count)
                    MessageBox.Show("Xoá tài khoản thành công!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            userNameCheck = false;
            if (Add)
            {
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    errorProviderUserName.SetError(txtUserName, "Tên đăng nhập không được để trống!");
                }
                else if (AccountDAO.Instance.GetAccountByUserName(txtUserName.Text)!=null)
                {
                    errorProviderUserName.SetError(txtUserName, "Tên đăng nhập không hợp lệ!");
                }
                else if(!Regex.IsMatch(txtUserName.Text, "^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+)*$"))
                {
                    errorProviderUserName.SetError(txtUserName, "Tên đăng nhập không hợp lệ!");
                }
                else
                {
                    errorProviderUserName.Clear();
                    userNameCheck = true;
                }
            }
        }
    }
}
