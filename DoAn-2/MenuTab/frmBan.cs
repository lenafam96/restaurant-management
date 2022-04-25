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
    public partial class frmBan : Form
    {
        public frmBan()
        {
            InitializeComponent();
            LoadBan();
        }

        void LoadBan()
        {
            flpBan.Controls.Clear();
            List<Ban> listBan = BanDAO.Instance.GetListBan();
            foreach (Ban item in listBan)
            {
                Button btnBan = new Button() { Width = BanDAO.BanWidth, Height = BanDAO.BanHeight };
                btnBan.Font = new Font(btnBan.Font.FontFamily, 14);
                btnBan.Text = "Bàn " + item.MaBan;
                btnBan.Click += btnBan_Click;
                btnBan.Tag = item;
                if (item.TrangThai == 1)
                {
                    btnBan.Enabled = false;
                    btnBan.BackColor = ColorTranslator.FromHtml("#d90429");
                }
                else
                    btnBan.BackColor = ColorTranslator.FromHtml("#99D98C");
                flpBan.Controls.Add(btnBan);
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            Ban ban = (sender as Button).Tag as Ban;
            MessageBox.Show(ban.TrangThai.ToString());
        }
    }
}
