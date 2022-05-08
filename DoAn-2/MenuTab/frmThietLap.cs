using restaurant_management.DAO;
using restaurant_management.DTO;
using restaurant_management.View;
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
        private Form currentchildform;
        public frmThietLap()
        {
            InitializeComponent();
        }
        void ResetAllTextBox()
        {
            //txtUserName.ResetText();
            //txtDisplayName.ResetText();
            txtMaDanhMucMon.ResetText();
            txtTenDanhMucMon.ResetText();
        }

        void SetBtnEdit_On()
        {
            //btnSave.Enabled = true;
            //btnCancel.Enabled = true;
            //grPanel.Enabled = true;
            //btnReset.Enabled = true;
            //btnAdd.Enabled = false;
            //btnEdit.Enabled = false;
            //btnDelete.Enabled = false;
            //dtgvAccount.Enabled = false;
            btnSave1.Enabled = true;
            btnCancel1.Enabled = true;
            grPanel1.Enabled = true;
            btnAdd1.Enabled = false;
            btnEdit1.Enabled = false;
            btnDelete1.Enabled = false;
            dtgvDanhMucMon.Enabled = false;
        }

        void SetBtnEdit_Off()
        {
            //btnSave.Enabled = false;
            //btnCancel.Enabled = false;
            //grPanel.Enabled = false;
            //btnReset.Enabled = false;
            //btnAdd.Enabled = true;
            //btnEdit.Enabled = true;
            //btnDelete.Enabled = true;
            //dtgvAccount.Enabled = true;
            btnSave1.Enabled = false;
            btnCancel1.Enabled = false;
            grPanel1.Enabled = false;
            btnAdd1.Enabled = true;
            btnEdit1.Enabled = true;
            btnDelete1.Enabled = true;
            dtgvDanhMucMon.Enabled = true;
            //Add = false;
        }

        void LoadList()
        {
            //listAccount.DataSource = AccountDAO.Instance.GetAccountList();
            //listDanhMucMon.DataSource = DanhMucMonDAO.Instance.GetDataTableDanhMucMon();
        }

        void LoadData()
        {
            ResetAllTextBox();
            SetBtnEdit_Off();
            LoadList();
            //dtgvAccount.DataSource = listAccount;
            //dtgvAccount.ReadOnly = true;
            //dtgvDanhMucMon.DataSource = listDanhMucMon;
            //dtgvDanhMucMon.ReadOnly = true;
            //txtUserName.Text = dtgvAccount == null ? "" : dtgvAccount.Rows[0].Cells[0].Value.ToString();
        }
        private void motrangcon(Form trangcon)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();

            }
            currentchildform = trangcon;
            trangcon.TopLevel = false;
            trangcon.FormBorderStyle = FormBorderStyle.None;
            trangcon.Dock = DockStyle.Fill;
            paneltrangcon.Controls.Add(trangcon);
            paneltrangcon.Tag = trangcon;
            trangcon.BringToFront();
            trangcon.Show();
        }


        int TypeAccountSelected()
        {
            //if (radioOngChu.Checked)
            //    return 1;
            //if (radioQuanTriVien.Checked)
            //    return 2;
            //if (radioQuanKho.Checked)
            //    return 3;
            //if (radioThuNgan.Checked)
            //    return 4;
            return 5;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add = true;
            ResetAllTextBox();
            SetBtnEdit_On();
            //btnReset.Enabled = false;
            //txtUserName.Enabled = txtDisplayName.Enabled = true;
            //txtUserName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //txtUserName.Enabled = false;
            //Add = false;
            //dtgvAccount_CellClick(null, null);
            //SetBtnEdit_On();
            //txtDisplayName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (Add)
            //{
            //    if(userNameCheck)
            //    {
            //        bool count = AccountDAO.Instance.CreateNewAccount(txtUserName.Text, txtDisplayName.Text, TypeAccountSelected());
            //        LoadData();
            //        if (count)
            //            MessageBox.Show("Thêm tài khoản thành công!");
            //    }    
            //}
            //else
            //{
            //    bool count = AccountDAO.Instance.UpdateAccountRole(txtUserName.Text, txtDisplayName.Text, TypeAccountSelected());
            //    LoadData();
            //    if (count)
            //        MessageBox.Show("Cập nhật dữ liệu thành công!");
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetBtnEdit_Off();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn chắc chắn muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    bool count = AccountDAO.Instance.DeleteAccountByUserName(txtUserName.Text);
            //    LoadData();
            //    if (count)
            //        MessageBox.Show("Xoá tài khoản thành công!");
            //}
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            //userNameCheck = false;
            //if (Add)
            //{
            //    if (string.IsNullOrEmpty(txtUserName.Text))
            //    {
            //        errorProviderUserName.SetError(txtUserName, "Tên đăng nhập không được để trống!");
            //    }
            //    else if (AccountDAO.Instance.GetAccountByUserName(txtUserName.Text)!=null)
            //    {
            //        errorProviderUserName.SetError(txtUserName, "Tên đăng nhập không hợp lệ!");
            //    }
            //    else if(!Regex.IsMatch(txtUserName.Text, "^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+)*$"))
            //    {
            //        errorProviderUserName.SetError(txtUserName, "Tên đăng nhập không hợp lệ!");
            //    }
            //    else
            //    {
            //        errorProviderUserName.Clear();
            //        userNameCheck = true;
            //    }
            //}
        }

        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int r = dtgvAccount.CurrentCell.RowIndex;
            //txtUserName.Text = dtgvAccount.Rows[r].Cells[0].Value.ToString();
            //txtDisplayName.Text = dtgvAccount.Rows[r].Cells[1].Value.ToString();
            //switch (dtgvAccount.Rows[r].Cells[2].Value.ToString())
            //{
            //    case "Ông chủ": radioOngChu.Checked = true; break;
            //    case "Quản trị viên": radioQuanTriVien.Checked = true; break;
            //    case "Quản kho": radioQuanKho.Checked = true; break;
            //    case "Thu ngân": radioThuNgan.Checked = true; break;
            //    case "Phục vụ": radioPhucVu.Checked = true; break;
            //}
            //btnEdit.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //bool count = AccountDAO.Instance.ResetPassWord(txtUserName.Text);
            //SetBtnEdit_Off();
            //LoadData();
            //if (count)
            //    MessageBox.Show("Reset mật khẩu thành công!");
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            //Add = true;
            ResetAllTextBox();
            SetBtnEdit_On();
            txtTenDanhMucMon.Focus();
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            //Add = false;
            dtgvDanhMucMon_CellClick(null, null);
            SetBtnEdit_On();
            txtTenDanhMucMon.Focus();
        }

        private void dtgvDanhMucMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {

        }

        private void dtgvAccount_SortStringChanged(object sender, EventArgs e)
        {

        }

        private void dtgvAccount_FilterStringChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: motrangcon(new frmCaiDatTaiKhoan()); break;
                case 1: motrangcon(new frmCaiDatDanhMucMon()); break;
                case 2: motrangcon(new frmCaiDatMonAn()); break;
            }
        }

        private void frmThietLap_Load(object sender, EventArgs e)
        {
            motrangcon(new frmCaiDatTaiKhoan());
        }
    }
}
