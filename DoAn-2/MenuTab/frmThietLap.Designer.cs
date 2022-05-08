
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
            this.tpDanhMucMon = new System.Windows.Forms.TabPage();
            this.dtgvDanhMucMon = new ADGV.AdvancedDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnEdit1 = new System.Windows.Forms.Button();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.grPanel1 = new System.Windows.Forms.Panel();
            this.txtTenDanhMucMon = new System.Windows.Forms.TextBox();
            this.txtMaDanhMucMon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProviderUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneltrangcon = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tpDanhMucMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhMucMon)).BeginInit();
            this.panel1.SuspendLayout();
            this.grPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserName)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTaiKhoan);
            this.tabControl1.Controls.Add(this.tpDanhMucMon);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 24);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpTaiKhoan
            // 
            this.tpTaiKhoan.Location = new System.Drawing.Point(4, 22);
            this.tpTaiKhoan.Name = "tpTaiKhoan";
            this.tpTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tpTaiKhoan.Size = new System.Drawing.Size(923, 0);
            this.tpTaiKhoan.TabIndex = 0;
            this.tpTaiKhoan.Text = "Tài khoản";
            this.tpTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // tpDanhMucMon
            // 
            this.tpDanhMucMon.Controls.Add(this.dtgvDanhMucMon);
            this.tpDanhMucMon.Controls.Add(this.label4);
            this.tpDanhMucMon.Controls.Add(this.panel1);
            this.tpDanhMucMon.Controls.Add(this.grPanel1);
            this.tpDanhMucMon.Location = new System.Drawing.Point(4, 22);
            this.tpDanhMucMon.Name = "tpDanhMucMon";
            this.tpDanhMucMon.Padding = new System.Windows.Forms.Padding(3);
            this.tpDanhMucMon.Size = new System.Drawing.Size(923, 0);
            this.tpDanhMucMon.TabIndex = 1;
            this.tpDanhMucMon.Text = "Danh mục món";
            this.tpDanhMucMon.UseVisualStyleBackColor = true;
            // 
            // dtgvDanhMucMon
            // 
            this.dtgvDanhMucMon.AllowUserToAddRows = false;
            this.dtgvDanhMucMon.AllowUserToDeleteRows = false;
            this.dtgvDanhMucMon.AutoGenerateContextFilters = true;
            this.dtgvDanhMucMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhMucMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dtgvDanhMucMon.DateWithTime = false;
            this.dtgvDanhMucMon.Location = new System.Drawing.Point(6, 154);
            this.dtgvDanhMucMon.Name = "dtgvDanhMucMon";
            this.dtgvDanhMucMon.ReadOnly = true;
            this.dtgvDanhMucMon.RowHeadersVisible = false;
            this.dtgvDanhMucMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhMucMon.Size = new System.Drawing.Size(910, 351);
            this.dtgvDanhMucMon.TabIndex = 20;
            this.dtgvDanhMucMon.TimeFilter = false;
            this.dtgvDanhMucMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhMucMon_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "maDanhMucMon";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã danh mục món";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tenDanhMucMon";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên danh mục món";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(284, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 47);
            this.label4.TabIndex = 17;
            this.label4.Text = "Quản lý danh mục món";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDelete1);
            this.panel1.Controls.Add(this.btnCancel1);
            this.panel1.Controls.Add(this.btnSave1);
            this.panel1.Controls.Add(this.btnEdit1);
            this.panel1.Controls.Add(this.btnAdd1);
            this.panel1.Location = new System.Drawing.Point(257, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 39);
            this.panel1.TabIndex = 19;
            // 
            // btnDelete1
            // 
            this.btnDelete1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete1.Location = new System.Drawing.Point(327, 3);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(78, 26);
            this.btnDelete1.TabIndex = 13;
            this.btnDelete1.Text = "Delete";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel1.Location = new System.Drawing.Point(246, 3);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(78, 26);
            this.btnCancel1.TabIndex = 12;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnSave1
            // 
            this.btnSave1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave1.Location = new System.Drawing.Point(165, 3);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(78, 26);
            this.btnSave1.TabIndex = 11;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // btnEdit1
            // 
            this.btnEdit1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEdit1.Location = new System.Drawing.Point(84, 3);
            this.btnEdit1.Name = "btnEdit1";
            this.btnEdit1.Size = new System.Drawing.Size(78, 26);
            this.btnEdit1.TabIndex = 9;
            this.btnEdit1.Text = "Edit";
            this.btnEdit1.UseVisualStyleBackColor = true;
            this.btnEdit1.Click += new System.EventHandler(this.btnEdit1_Click);
            // 
            // btnAdd1
            // 
            this.btnAdd1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd1.Location = new System.Drawing.Point(3, 3);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(78, 26);
            this.btnAdd1.TabIndex = 8;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // grPanel1
            // 
            this.grPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grPanel1.Controls.Add(this.txtTenDanhMucMon);
            this.grPanel1.Controls.Add(this.txtMaDanhMucMon);
            this.grPanel1.Controls.Add(this.label5);
            this.grPanel1.Controls.Add(this.label8);
            this.grPanel1.Location = new System.Drawing.Point(6, 59);
            this.grPanel1.Name = "grPanel1";
            this.grPanel1.Size = new System.Drawing.Size(910, 44);
            this.grPanel1.TabIndex = 18;
            // 
            // txtTenDanhMucMon
            // 
            this.txtTenDanhMucMon.Location = new System.Drawing.Point(533, 10);
            this.txtTenDanhMucMon.Name = "txtTenDanhMucMon";
            this.txtTenDanhMucMon.Size = new System.Drawing.Size(370, 20);
            this.txtTenDanhMucMon.TabIndex = 2;
            // 
            // txtMaDanhMucMon
            // 
            this.txtMaDanhMucMon.Location = new System.Drawing.Point(121, 8);
            this.txtMaDanhMucMon.Name = "txtMaDanhMucMon";
            this.txtMaDanhMucMon.ReadOnly = true;
            this.txtMaDanhMucMon.Size = new System.Drawing.Size(218, 20);
            this.txtMaDanhMucMon.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(413, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên danh mục món:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã danh mục món:";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(923, 0);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tpDanhMucMon.ResumeLayout(false);
            this.tpDanhMucMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhMucMon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grPanel1.ResumeLayout(false);
            this.grPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTaiKhoan;
        private System.Windows.Forms.TabPage tpDanhMucMon;
        private ADGV.AdvancedDataGridView dtgvDanhMucMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnEdit1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Panel grPanel1;
        private System.Windows.Forms.TextBox txtTenDanhMucMon;
        private System.Windows.Forms.TextBox txtMaDanhMucMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.ErrorProvider errorProviderUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameRole;
        private System.Windows.Forms.Panel paneltrangcon;
    }
}