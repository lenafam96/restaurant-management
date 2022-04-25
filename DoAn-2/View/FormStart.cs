using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_management.View
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }
        private void OpenMainForm()
        {
            Thread.Sleep(1500);
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    new Form1().Show();
                    this.Visible = false;
                });
            }
            else
            {
                new Form1().Show();
                this.Visible = false;
            }
        }

        private void TestConnectDb()
        {

            restaurant_management.DAO.TestConnection test = new restaurant_management.DAO.TestConnection();


            if (!test.Test())
            {
                this.Visible = false;
                new frmKetNoiDB().Show();

            }
            else
            {
                label3.Text = "...Kết Nối Thành Công. Đang Mở Ứng Dụng";

                Thread th = new Thread(new ThreadStart(OpenMainForm));
                th.IsBackground = true;
                th.Start();

            }
        }

        private void TheadFunction()
        {
            Thread.Sleep(2000);
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    label3.Text = "...Đang Kiểm Tra Kết Nối Đến CSDL";
                });
            }
            else
            {
                label3.Text = "...Đang Kiểm Tra Kết Nối Đến CSDL";
            }
            Thread.Sleep(1500);
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    TestConnectDb();
                });
            }
            else
            {
                TestConnectDb();
            }
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            label3.Text = "...Đang Mở Ứng Dụng";
            Thread th = new Thread(new ThreadStart(TheadFunction));
            th.IsBackground = true;
            th.Start();
        }

        private void lbexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
