using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_management
{
    [Serializable]
    public partial class frmKetNoiDB : Form
    {
        private static string connectionString;

        public static string ConnectionString { get => connectionString; set => connectionString = value; }

        public frmKetNoiDB()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKetNoiDB_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "Kết nối đến CSDL thất bại. \n Vui lòng thiết lập lại thông số kết nối đến CSDL.";
            cboAuthen.SelectedIndex = 0;
        }

        private void frmKetNoiDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void EnableControl(bool b)
        {

            txtUsername.Enabled = b;
            txtPassword.Enabled = b;
            label3.Enabled = b;
            label4.Enabled = b;

        }

        private void cboAuthen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAuthen.SelectedIndex == 0)
            {
                EnableControl(false);
            }
            else
            {
                EnableControl(true);
            }
        }

        private void btnLayDS_Click(object sender, EventArgs e)
        {
            ConnectionString = null;

            if (cboAuthen.SelectedIndex == 0)
            {
                ConnectionString = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=master;Integrated Security=True";
            }
            else
            {
                ConnectionString = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=master;User ID=" + txtUsername.Text.Trim() + ";password=" + txtPassword.Text.Trim();
            }


            SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM sys.databases WHERE name not in('master','model','msdb','tempdb')", con);

                DataTable table = new DataTable();
                da.Fill(table);

                da.Dispose();

                con.Close();

                cboListDB.DataSource = table;
                cboListDB.DisplayMember = "name";
                cboListDB.ValueMember = "name";

                label5.Enabled = true;
                cboListDB.Enabled = true;

                btnLayDS.Enabled = false;
                btnKetNoi.Enabled = true;

                label1.Enabled = false;
                txtServerName.Enabled = false;

                cboAuthen.Enabled = false;

                EnableControl(false);

            }
            catch (Exception ex)
            {
                btnKetNoi.Enabled = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            if (cboListDB.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn 1 cơ sở dữ liệu.");
                return;
            }

            ConnectionString = null;
            
            if (cboAuthen.SelectedIndex == 0)
            {
                ConnectionString = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=" + cboListDB.SelectedValue.ToString() + ";Integrated Security=True";
            }
            else
            {
                ConnectionString = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=" + cboListDB.SelectedValue.ToString() + ";User ID=" + txtUsername.Text.Trim() + ";password=" + txtPassword.Text.Trim();
            }

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            try
            {


                SqlCommand cmd = new SqlCommand("TESTCONNECTION", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader ren = cmd.ExecuteReader();

                bool flag = false;

                while (ren.Read())
                {
                    if (ren[0].ToString().Equals("True"))
                    {
                        flag = true;
                    }
                    break;
                }
                con.Close();

                if (flag)
                {
                    System.IO.File.WriteAllText("connectionString.txt", ConnectionString);

                    this.Hide();
                    new Form1().Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đúng CSDL. Mặc định là quanlynhahang");
                }
            }
            catch
            {
                con.Close();
                MessageBox.Show("Vui lòng chọn đúng CSDL. Mặc định là quanlynhahang");
                return;
            }
        }
    }
}
