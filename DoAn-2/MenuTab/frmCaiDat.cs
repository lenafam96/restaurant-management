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
    public partial class frmCaiDat : Form
    {
        NhanVien nhanVien;
        public frmCaiDat()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            nhanVien = NhanVienDAO.Instance.GetNhanVienByID(MainControl.LoginAccount.MaNhanVien);
            txtMaNhanVien.Text = nhanVien.MaNhanVien.ToString();
            txtUserName.Text = MainControl.LoginAccount.UserName;
            txtTenNhanVien.Text = nhanVien.HoTen;
            dtpkNgaySinh.Value = nhanVien.NgaySinh;
            if (nhanVien.GioiTinh.Equals("Nam"))
                radNam.Checked = true;
            else
                radNu.Checked = true;
            txtSDT.Text = nhanVien.Sdt;
            txtCCCD.Text = nhanVien.Cccd;
            txtMatKhauCu.ResetText();
            txtMatKhauMoi.ResetText();
            txtXacNhanMatKhau.ResetText();
        }
        private void frmCaiDat_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatKhauCu.Text))
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            else if (AccountDAO.Instance.Login(txtUserName.Text, txtMatKhauCu.Text))
            {
                if (string.IsNullOrEmpty(txtMatKhauMoi.Text))
                {
                    NhanVienDAO.Instance.UpdateNhanVien(nhanVien.MaNhanVien, txtTenNhanVien.Text, dtpkNgaySinh.Value, radNam.Checked ? "Nam" : "Nữ", nhanVien.ChucVu, txtSDT.Text.Replace("-", string.Empty), txtCCCD.Text, nhanVien.Luong);
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                }
                else if(txtMatKhauMoi.Text.Equals(txtXacNhanMatKhau.Text))
                {
                    NhanVienDAO.Instance.UpdateNhanVien(nhanVien.MaNhanVien, txtTenNhanVien.Text, dtpkNgaySinh.Value, radNam.Checked ? "Nam" : "Nữ", nhanVien.ChucVu, txtSDT.Text.Replace("-", string.Empty), txtCCCD.Text, nhanVien.Luong);
                    AccountDAO.Instance.UpdateAccountInfo(MainControl.LoginAccount.UserName,nhanVien.MaNhanVien,txtMatKhauMoi.Text,MainControl.LoginAccount.Role);
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                }    
                else
                {
                    MessageBox.Show("Xác nhận mật khẩu mới không chính xác!");
                    txtMatKhauMoi.ResetText();
                    txtXacNhanMatKhau.ResetText();
                    txtMatKhauMoi.Focus();
                }    
            }
            else
            {
                MessageBox.Show("Mật khẩu không chính xác!");
                txtMatKhauCu.ResetText();
                txtMatKhauCu.Focus();
            }    
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if(txtSDT.Text.Equals("   -   -"))
                txtSDT.Text = nhanVien.Sdt;
        }

        private void txtCCCD_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCCCD.Text))
                txtCCCD.Text = nhanVien.Cccd;
        }

        private void txtTenNhanVien_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenNhanVien.Text))
                txtTenNhanVien.Text = nhanVien.HoTen;
        }
    }
}
