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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        
        void fillChart()
        {
            chartDoanhThu.DataSource = HoaDonDAO.Instance.GetHoaDon30Day();
            chartDoanhThu.Series["DoanhThu"].XValueMember = "Day";
            chartDoanhThu.Series["DoanhThu"].YValueMembers = "Sum";
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            fillChart();
        }
    }
}
