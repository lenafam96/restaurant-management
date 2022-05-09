
namespace restaurant_management.MenuTab
{
    partial class frmTonKho
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenThucPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaThucPham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grPanel = new System.Windows.Forms.Panel();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvThucPham = new ADGV.AdvancedDataGridView();
            this.MaThucPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProviderTenThucPham = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDonViTinh = new System.Windows.Forms.ErrorProvider(this.components);
            this.grPanel.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThucPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTenThucPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDonViTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(508, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tồn kho:";
            // 
            // txtTenThucPham
            // 
            this.txtTenThucPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThucPham.Location = new System.Drawing.Point(576, 10);
            this.txtTenThucPham.Name = "txtTenThucPham";
            this.txtTenThucPham.Size = new System.Drawing.Size(315, 22);
            this.txtTenThucPham.TabIndex = 2;
            this.txtTenThucPham.Leave += new System.EventHandler(this.txtTenThucPham_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(465, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên thực phẩm:";
            // 
            // txtMaThucPham
            // 
            this.txtMaThucPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThucPham.Location = new System.Drawing.Point(115, 8);
            this.txtMaThucPham.Name = "txtMaThucPham";
            this.txtMaThucPham.ReadOnly = true;
            this.txtMaThucPham.Size = new System.Drawing.Size(302, 22);
            this.txtMaThucPham.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 47);
            this.label1.TabIndex = 25;
            this.label1.Text = "QUẢN LÝ TỒN KHO";
            // 
            // grPanel
            // 
            this.grPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grPanel.Controls.Add(this.label8);
            this.grPanel.Controls.Add(this.txtDonViTinh);
            this.grPanel.Controls.Add(this.label4);
            this.grPanel.Controls.Add(this.txtTenThucPham);
            this.grPanel.Controls.Add(this.label3);
            this.grPanel.Controls.Add(this.txtTonKho);
            this.grPanel.Controls.Add(this.txtMaThucPham);
            this.grPanel.Controls.Add(this.label2);
            this.grPanel.Location = new System.Drawing.Point(9, 65);
            this.grPanel.Name = "grPanel";
            this.grPanel.Size = new System.Drawing.Size(913, 69);
            this.grPanel.TabIndex = 26;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDonViTinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(115, 38);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(302, 22);
            this.txtDonViTinh.TabIndex = 3;
            this.txtDonViTinh.Leave += new System.EventHandler(this.txtDonViTinh_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(4, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn vị tính:";
            // 
            // txtTonKho
            // 
            this.txtTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTonKho.Location = new System.Drawing.Point(576, 38);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.ReadOnly = true;
            this.txtTonKho.Size = new System.Drawing.Size(315, 22);
            this.txtTonKho.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã thực phẩm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.Location = new System.Drawing.Point(6, 7);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(411, 22);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.Text = "Tên thực phẩm";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 30);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.Location = new System.Drawing.Point(339, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 30);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel.Location = new System.Drawing.Point(255, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 30);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Location = new System.Drawing.Point(171, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEdit.Location = new System.Drawing.Point(87, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 30);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnSearch
            // 
            this.pnSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnSearch.Controls.Add(this.txtTimKiem);
            this.pnSearch.Location = new System.Drawing.Point(9, 140);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(424, 40);
            this.pnSearch.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(498, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 40);
            this.panel1.TabIndex = 24;
            // 
            // dtgvThucPham
            // 
            this.dtgvThucPham.AllowUserToAddRows = false;
            this.dtgvThucPham.AllowUserToDeleteRows = false;
            this.dtgvThucPham.AutoGenerateContextFilters = true;
            this.dtgvThucPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThucPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThucPham,
            this.TenThucPham,
            this.DonViTinh,
            this.TonKho});
            this.dtgvThucPham.DateWithTime = false;
            this.dtgvThucPham.Location = new System.Drawing.Point(9, 186);
            this.dtgvThucPham.Name = "dtgvThucPham";
            this.dtgvThucPham.ReadOnly = true;
            this.dtgvThucPham.RowHeadersVisible = false;
            this.dtgvThucPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvThucPham.Size = new System.Drawing.Size(913, 341);
            this.dtgvThucPham.TabIndex = 23;
            this.dtgvThucPham.TimeFilter = false;
            this.dtgvThucPham.SortStringChanged += new System.EventHandler(this.dtgvThucPham_SortStringChanged);
            this.dtgvThucPham.FilterStringChanged += new System.EventHandler(this.dtgvThucPham_FilterStringChanged);
            this.dtgvThucPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThucPham_CellClick);
            // 
            // MaThucPham
            // 
            this.MaThucPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaThucPham.DataPropertyName = "MaThucPham";
            this.MaThucPham.HeaderText = "Mã thực phẩm";
            this.MaThucPham.MinimumWidth = 22;
            this.MaThucPham.Name = "MaThucPham";
            this.MaThucPham.ReadOnly = true;
            this.MaThucPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // TenThucPham
            // 
            this.TenThucPham.DataPropertyName = "TenThucPham";
            this.TenThucPham.HeaderText = "Tên thực phẩm";
            this.TenThucPham.MinimumWidth = 22;
            this.TenThucPham.Name = "TenThucPham";
            this.TenThucPham.ReadOnly = true;
            this.TenThucPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.TenThucPham.Width = 300;
            // 
            // DonViTinh
            // 
            this.DonViTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 22;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            this.DonViTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // TonKho
            // 
            this.TonKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TonKho.DataPropertyName = "TonKho";
            this.TonKho.HeaderText = "Số lượng tồn kho";
            this.TonKho.MinimumWidth = 22;
            this.TonKho.Name = "TonKho";
            this.TonKho.ReadOnly = true;
            this.TonKho.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // errorProviderTenThucPham
            // 
            this.errorProviderTenThucPham.ContainerControl = this;
            // 
            // errorProviderDonViTinh
            // 
            this.errorProviderDonViTinh.ContainerControl = this;
            // 
            // frmTonKho
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(931, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grPanel);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvThucPham);
            this.Name = "frmTonKho";
            this.Text = "Tồn kho";
            this.Load += new System.EventHandler(this.frmTonKho_Load);
            this.grPanel.ResumeLayout(false);
            this.grPanel.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThucPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTenThucPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDonViTinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenThucPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaThucPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel grPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.Panel panel1;
        private ADGV.AdvancedDataGridView dtgvThucPham;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThucPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonKho;
        private System.Windows.Forms.ErrorProvider errorProviderTenThucPham;
        private System.Windows.Forms.ErrorProvider errorProviderDonViTinh;
    }
}