
namespace restaurant_management.View
{
    partial class frmCaiDatTaiKhoan
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
            this.errorProviderUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioQuanTriVien = new System.Windows.Forms.RadioButton();
            this.radioOngChu = new System.Windows.Forms.RadioButton();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.radioPhucVu = new System.Windows.Forms.RadioButton();
            this.radioThuNgan = new System.Windows.Forms.RadioButton();
            this.radioQuanKho = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grPanel = new System.Windows.Forms.Panel();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvAccount = new ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserName)).BeginInit();
            this.grPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProviderUserName
            // 
            this.errorProviderUserName.ContainerControl = this;
            // 
            // radioQuanTriVien
            // 
            this.radioQuanTriVien.AutoSize = true;
            this.radioQuanTriVien.Location = new System.Drawing.Point(297, 48);
            this.radioQuanTriVien.Name = "radioQuanTriVien";
            this.radioQuanTriVien.Size = new System.Drawing.Size(85, 17);
            this.radioQuanTriVien.TabIndex = 4;
            this.radioQuanTriVien.TabStop = true;
            this.radioQuanTriVien.Text = "Quản trị viên";
            this.radioQuanTriVien.UseVisualStyleBackColor = true;
            // 
            // radioOngChu
            // 
            this.radioOngChu.AutoSize = true;
            this.radioOngChu.Location = new System.Drawing.Point(184, 48);
            this.radioOngChu.Name = "radioOngChu";
            this.radioOngChu.Size = new System.Drawing.Size(66, 17);
            this.radioOngChu.TabIndex = 3;
            this.radioOngChu.TabStop = true;
            this.radioOngChu.Text = "Ông chủ";
            this.radioOngChu.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(100, 10);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(218, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(452, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(72, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại tài khoản:";
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReset.Location = new System.Drawing.Point(165, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 26);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset mật khẩu";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.Location = new System.Drawing.Point(434, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 26);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel.Location = new System.Drawing.Point(353, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 26);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Location = new System.Drawing.Point(272, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 26);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEdit.Location = new System.Drawing.Point(84, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 26);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // radioPhucVu
            // 
            this.radioPhucVu.AutoSize = true;
            this.radioPhucVu.Location = new System.Drawing.Point(666, 48);
            this.radioPhucVu.Name = "radioPhucVu";
            this.radioPhucVu.Size = new System.Drawing.Size(65, 17);
            this.radioPhucVu.TabIndex = 7;
            this.radioPhucVu.TabStop = true;
            this.radioPhucVu.Text = "Phục vụ";
            this.radioPhucVu.UseVisualStyleBackColor = true;
            // 
            // radioThuNgan
            // 
            this.radioThuNgan.AutoSize = true;
            this.radioThuNgan.Location = new System.Drawing.Point(548, 48);
            this.radioThuNgan.Name = "radioThuNgan";
            this.radioThuNgan.Size = new System.Drawing.Size(71, 17);
            this.radioThuNgan.TabIndex = 6;
            this.radioThuNgan.TabStop = true;
            this.radioThuNgan.Text = "Thu ngân";
            this.radioThuNgan.UseVisualStyleBackColor = true;
            // 
            // radioQuanKho
            // 
            this.radioQuanKho.AutoSize = true;
            this.radioQuanKho.Location = new System.Drawing.Point(429, 48);
            this.radioQuanKho.Name = "radioQuanKho";
            this.radioQuanKho.Size = new System.Drawing.Size(72, 17);
            this.radioQuanKho.TabIndex = 5;
            this.radioQuanKho.TabStop = true;
            this.radioQuanKho.Text = "Quản kho";
            this.radioQuanKho.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Location = new System.Drawing.Point(3, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 26);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grPanel
            // 
            this.grPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grPanel.Controls.Add(this.cmbNhanVien);
            this.grPanel.Controls.Add(this.radioPhucVu);
            this.grPanel.Controls.Add(this.radioThuNgan);
            this.grPanel.Controls.Add(this.radioQuanKho);
            this.grPanel.Controls.Add(this.radioQuanTriVien);
            this.grPanel.Controls.Add(this.radioOngChu);
            this.grPanel.Controls.Add(this.txtUserName);
            this.grPanel.Controls.Add(this.label6);
            this.grPanel.Controls.Add(this.label3);
            this.grPanel.Controls.Add(this.label2);
            this.grPanel.Location = new System.Drawing.Point(12, 78);
            this.grPanel.Name = "grPanel";
            this.grPanel.Size = new System.Drawing.Size(910, 78);
            this.grPanel.TabIndex = 22;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(548, 10);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(355, 21);
            this.cmbNhanVien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(301, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 47);
            this.label1.TabIndex = 21;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(227, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 39);
            this.panel2.TabIndex = 23;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "nameRole";
            this.Column3.HeaderText = "Loại tài khoản";
            this.Column3.MinimumWidth = 22;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "hoTen";
            this.Column2.HeaderText = "Họ tên nhân viên";
            this.Column2.MinimumWidth = 22;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "userName";
            this.Column1.HeaderText = "Tên đăng nhập";
            this.Column1.MinimumWidth = 22;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AllowUserToAddRows = false;
            this.dtgvAccount.AllowUserToDeleteRows = false;
            this.dtgvAccount.AutoGenerateContextFilters = true;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgvAccount.DateWithTime = false;
            this.dtgvAccount.Location = new System.Drawing.Point(12, 207);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.ReadOnly = true;
            this.dtgvAccount.RowHeadersVisible = false;
            this.dtgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAccount.Size = new System.Drawing.Size(910, 317);
            this.dtgvAccount.TabIndex = 24;
            this.dtgvAccount.TimeFilter = false;
            this.dtgvAccount.SortStringChanged += new System.EventHandler(this.dtgvAccount_SortStringChanged);
            this.dtgvAccount.FilterStringChanged += new System.EventHandler(this.dtgvAccount_FilterStringChanged);
            this.dtgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAccount_CellClick);
            // 
            // frmCaiDatTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 534);
            this.Controls.Add(this.grPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgvAccount);
            this.Name = "frmCaiDatTaiKhoan";
            this.Text = "CaiDatTaiKhoan";
            this.Load += new System.EventHandler(this.frmCaiDatTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserName)).EndInit();
            this.grPanel.ResumeLayout(false);
            this.grPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProviderUserName;
        private System.Windows.Forms.Panel grPanel;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.RadioButton radioPhucVu;
        private System.Windows.Forms.RadioButton radioThuNgan;
        private System.Windows.Forms.RadioButton radioQuanKho;
        private System.Windows.Forms.RadioButton radioQuanTriVien;
        private System.Windows.Forms.RadioButton radioOngChu;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private ADGV.AdvancedDataGridView dtgvAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}