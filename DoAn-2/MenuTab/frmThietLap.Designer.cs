
namespace restaurant_management.MenuTab
{
    partial class frmThietLap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTaiKhoan = new System.Windows.Forms.TabPage();
            this.tpMonAn = new System.Windows.Forms.TabPage();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProviderUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneltrangcon = new System.Windows.Forms.Panel();
            this.tpDanhMucMon = new System.Windows.Forms.TabPage();
            this.tpNhaCungCap = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserName)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTaiKhoan);
            this.tabControl1.Controls.Add(this.tpDanhMucMon);
            this.tabControl1.Controls.Add(this.tpMonAn);
            this.tabControl1.Controls.Add(this.tpNhaCungCap);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 23);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpTaiKhoan
            // 
            this.tpTaiKhoan.Location = new System.Drawing.Point(4, 22);
            this.tpTaiKhoan.Name = "tpTaiKhoan";
            this.tpTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tpTaiKhoan.Size = new System.Drawing.Size(923, 104);
            this.tpTaiKhoan.TabIndex = 0;
            this.tpTaiKhoan.Text = "Tài khoản";
            this.tpTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // tpMonAn
            // 
            this.tpMonAn.Location = new System.Drawing.Point(4, 22);
            this.tpMonAn.Name = "tpMonAn";
            this.tpMonAn.Padding = new System.Windows.Forms.Padding(3);
            this.tpMonAn.Size = new System.Drawing.Size(923, 26);
            this.tpMonAn.TabIndex = 2;
            this.tpMonAn.Text = "Món ăn";
            this.tpMonAn.UseVisualStyleBackColor = true;
            // 
            // userName
            // 
            this.userName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userName.DataPropertyName = "userName";
            this.userName.HeaderText = "Tên đăng nhập";
            this.userName.MinimumWidth = 22;
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // errorProviderUserName
            // 
            this.errorProviderUserName.ContainerControl = this;
            // 
            // nameRole
            // 
            this.nameRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameRole.DataPropertyName = "nameRole";
            this.nameRole.HeaderText = "Loại tài khoản";
            this.nameRole.MinimumWidth = 22;
            this.nameRole.Name = "nameRole";
            this.nameRole.ReadOnly = true;
            this.nameRole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // paneltrangcon
            // 
            this.paneltrangcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.paneltrangcon.BackgroundImage = global::restaurant_management.Properties.Resources._12508948_1670998316473982_4851468845388207905_n;
            this.paneltrangcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paneltrangcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltrangcon.Location = new System.Drawing.Point(0, 0);
            this.paneltrangcon.Name = "paneltrangcon";
            this.paneltrangcon.Size = new System.Drawing.Size(931, 536);
            this.paneltrangcon.TabIndex = 4;
            // 
            // tpDanhMucMon
            // 
            this.tpDanhMucMon.Location = new System.Drawing.Point(4, 22);
            this.tpDanhMucMon.Name = "tpDanhMucMon";
            this.tpDanhMucMon.Padding = new System.Windows.Forms.Padding(3);
            this.tpDanhMucMon.Size = new System.Drawing.Size(923, 26);
            this.tpDanhMucMon.TabIndex = 1;
            this.tpDanhMucMon.Text = "Danh mục món";
            this.tpDanhMucMon.UseVisualStyleBackColor = true;
            // 
            // tpNhaCungCap
            // 
            this.tpNhaCungCap.Location = new System.Drawing.Point(4, 22);
            this.tpNhaCungCap.Name = "tpNhaCungCap";
            this.tpNhaCungCap.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhaCungCap.Size = new System.Drawing.Size(923, 0);
            this.tpNhaCungCap.TabIndex = 3;
            this.tpNhaCungCap.Text = "Nhà cung cấp";
            this.tpNhaCungCap.UseVisualStyleBackColor = true;
            // 
            // frmThietLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 536);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.paneltrangcon);
            this.Name = "frmThietLap";
            this.Text = "Thiết lập";
            this.Load += new System.EventHandler(this.frmThietLap_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTaiKhoan;
        private System.Windows.Forms.TabPage tpMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.ErrorProvider errorProviderUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameRole;
        private System.Windows.Forms.Panel paneltrangcon;
        private System.Windows.Forms.TabPage tpDanhMucMon;
        private System.Windows.Forms.TabPage tpNhaCungCap;
    }
}