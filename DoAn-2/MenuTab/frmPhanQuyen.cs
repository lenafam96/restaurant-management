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
    public partial class frmPhanQuyen : Form
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            cboLoaiTK.DataSource = RoleDAO.Instance.GetRoleList();
            cboLoaiTK.ValueMember = "idRole";
            cboLoaiTK.DisplayMember = "nameRole";
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cboLoaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            Role role = cboLoaiTK.SelectedItem as Role;
            ckbBan.Checked = role.QuyenBan;
            ckbNhanVien.Checked = role.QuyenNhanVien;
            ckbKhachHang.Checked = role.QuyenKhachHang;
            ckbVoucher.Checked = role.QuyenVoucher;
            ckbThongKe.Checked = role.QuyenThongKe;
            ckbKho.Checked = role.QuyenKho;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Role role = cboLoaiTK.SelectedItem as Role;
            if (RoleDAO.Instance.UpdateRole(role.IdRole, ckbBan.Checked, ckbNhanVien.Checked, ckbKhachHang.Checked, ckbVoucher.Checked, ckbThongKe.Checked, ckbKho.Checked))
                MessageBox.Show("Lưu thành công!");
        }
    }
}
