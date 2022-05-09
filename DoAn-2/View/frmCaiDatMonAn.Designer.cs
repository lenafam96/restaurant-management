
namespace restaurant_management.View
{
    partial class frmCaiDatMonAn
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
            this.dtgvMonAn = new ADGV.AdvancedDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDanhMucMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grPanel = new System.Windows.Forms.Panel();
            this.cmbDanhMuc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nbuGia = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.txtMaMonAn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProviderTenMonAn = new System.Windows.Forms.ErrorProvider(this.components);
            this.lsvChiTietMonAn = new System.Windows.Forms.ListView();
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenThucPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.donViTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpThucPham = new System.Windows.Forms.Panel();
            this.cmbThucPham = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.nbuSoLuong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonAn)).BeginInit();
            this.panel2.SuspendLayout();
            this.grPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbuGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTenMonAn)).BeginInit();
            this.gpThucPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbuSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvMonAn
            // 
            this.dtgvMonAn.AllowUserToAddRows = false;
            this.dtgvMonAn.AllowUserToDeleteRows = false;
            this.dtgvMonAn.AutoGenerateContextFilters = true;
            this.dtgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.gia,
            this.tenDanhMucMon});
            this.dtgvMonAn.DateWithTime = false;
            this.dtgvMonAn.Location = new System.Drawing.Point(13, 172);
            this.dtgvMonAn.Name = "dtgvMonAn";
            this.dtgvMonAn.ReadOnly = true;
            this.dtgvMonAn.RowHeadersVisible = false;
            this.dtgvMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMonAn.Size = new System.Drawing.Size(544, 352);
            this.dtgvMonAn.TabIndex = 32;
            this.dtgvMonAn.TimeFilter = false;
            this.dtgvMonAn.SortStringChanged += new System.EventHandler(this.dtgvMonAn_SortStringChanged);
            this.dtgvMonAn.FilterStringChanged += new System.EventHandler(this.dtgvMonAn_FilterStringChanged);
            this.dtgvMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMonAn_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "maMonAn";
            this.Column1.HeaderText = "Mã món ăn";
            this.Column1.MinimumWidth = 22;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Width = 85;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "tenMonAn";
            this.Column2.HeaderText = "Tên món ăn";
            this.Column2.MinimumWidth = 22;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 22;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            this.gia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tenDanhMucMon
            // 
            this.tenDanhMucMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenDanhMucMon.DataPropertyName = "tenDanhMucMon";
            this.tenDanhMucMon.HeaderText = "Danh mục";
            this.tenDanhMucMon.MinimumWidth = 22;
            this.tenDanhMucMon.Name = "tenDanhMucMon";
            this.tenDanhMucMon.ReadOnly = true;
            this.tenDanhMucMon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(317, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 47);
            this.label1.TabIndex = 29;
            this.label1.Text = "QUẢN LÝ MÓN ĂN";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(79, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 39);
            this.panel2.TabIndex = 31;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.Location = new System.Drawing.Point(323, 6);
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
            this.btnCancel.Location = new System.Drawing.Point(243, 6);
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
            this.btnSave.Location = new System.Drawing.Point(163, 6);
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
            this.btnEdit.Location = new System.Drawing.Point(83, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 26);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.grPanel.Controls.Add(this.cmbDanhMuc);
            this.grPanel.Controls.Add(this.label3);
            this.grPanel.Controls.Add(this.nbuGia);
            this.grPanel.Controls.Add(this.label8);
            this.grPanel.Controls.Add(this.txtTenMonAn);
            this.grPanel.Controls.Add(this.txtMaMonAn);
            this.grPanel.Controls.Add(this.label6);
            this.grPanel.Controls.Add(this.label2);
            this.grPanel.Location = new System.Drawing.Point(13, 78);
            this.grPanel.Name = "grPanel";
            this.grPanel.Size = new System.Drawing.Size(910, 43);
            this.grPanel.TabIndex = 30;
            // 
            // cmbDanhMuc
            // 
            this.cmbDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDanhMuc.FormattingEnabled = true;
            this.cmbDanhMuc.Location = new System.Drawing.Point(727, 9);
            this.cmbDanhMuc.Name = "cmbDanhMuc";
            this.cmbDanhMuc.Size = new System.Drawing.Size(176, 21);
            this.cmbDanhMuc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(655, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Danh mục:";
            // 
            // nbuGia
            // 
            this.nbuGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbuGia.Location = new System.Drawing.Point(521, 9);
            this.nbuGia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nbuGia.Name = "nbuGia";
            this.nbuGia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nbuGia.Size = new System.Drawing.Size(114, 22);
            this.nbuGia.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(483, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Giá:";
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Location = new System.Drawing.Point(244, 10);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(226, 20);
            this.txtTenMonAn.TabIndex = 2;
            this.txtTenMonAn.Leave += new System.EventHandler(this.txtTenMonAn_Leave);
            // 
            // txtMaMonAn
            // 
            this.txtMaMonAn.Location = new System.Drawing.Point(80, 10);
            this.txtMaMonAn.Name = "txtMaMonAn";
            this.txtMaMonAn.ReadOnly = true;
            this.txtMaMonAn.Size = new System.Drawing.Size(67, 20);
            this.txtMaMonAn.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(163, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên món ăn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã món ăn:";
            // 
            // errorProviderTenMonAn
            // 
            this.errorProviderTenMonAn.ContainerControl = this;
            // 
            // lsvChiTietMonAn
            // 
            this.lsvChiTietMonAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.tenThucPham,
            this.soLuong,
            this.donViTinh});
            this.lsvChiTietMonAn.FullRowSelect = true;
            this.lsvChiTietMonAn.GridLines = true;
            this.lsvChiTietMonAn.HideSelection = false;
            this.lsvChiTietMonAn.Location = new System.Drawing.Point(563, 172);
            this.lsvChiTietMonAn.Name = "lsvChiTietMonAn";
            this.lsvChiTietMonAn.Size = new System.Drawing.Size(361, 352);
            this.lsvChiTietMonAn.TabIndex = 33;
            this.lsvChiTietMonAn.UseCompatibleStateImageBehavior = false;
            this.lsvChiTietMonAn.View = System.Windows.Forms.View.Details;
            this.lsvChiTietMonAn.SelectedIndexChanged += new System.EventHandler(this.lsvChiTietMonAn_SelectedIndexChanged);
            // 
            // stt
            // 
            this.stt.Text = "STT";
            this.stt.Width = 40;
            // 
            // tenThucPham
            // 
            this.tenThucPham.Text = "Tên thực phẩm";
            this.tenThucPham.Width = 180;
            // 
            // soLuong
            // 
            this.soLuong.Text = "Số lượng";
            this.soLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // donViTinh
            // 
            this.donViTinh.Text = "Đơn vị";
            // 
            // gpThucPham
            // 
            this.gpThucPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gpThucPham.Controls.Add(this.cmbThucPham);
            this.gpThucPham.Controls.Add(this.btnThem);
            this.gpThucPham.Controls.Add(this.nbuSoLuong);
            this.gpThucPham.Location = new System.Drawing.Point(563, 127);
            this.gpThucPham.Name = "gpThucPham";
            this.gpThucPham.Size = new System.Drawing.Size(361, 39);
            this.gpThucPham.TabIndex = 31;
            // 
            // cmbThucPham
            // 
            this.cmbThucPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThucPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThucPham.FormattingEnabled = true;
            this.cmbThucPham.Location = new System.Drawing.Point(3, 8);
            this.cmbThucPham.Name = "cmbThucPham";
            this.cmbThucPham.Size = new System.Drawing.Size(176, 23);
            this.cmbThucPham.TabIndex = 34;
            this.cmbThucPham.SelectedIndexChanged += new System.EventHandler(this.cmbThucPham_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.Location = new System.Drawing.Point(275, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 26);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // nbuSoLuong
            // 
            this.nbuSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbuSoLuong.Location = new System.Drawing.Point(185, 7);
            this.nbuSoLuong.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nbuSoLuong.Name = "nbuSoLuong";
            this.nbuSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nbuSoLuong.Size = new System.Drawing.Size(84, 24);
            this.nbuSoLuong.TabIndex = 35;
            // 
            // frmCaiDatMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 534);
            this.Controls.Add(this.lsvChiTietMonAn);
            this.Controls.Add(this.dtgvMonAn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpThucPham);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grPanel);
            this.Name = "frmCaiDatMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmCaiDatMonAn";
            this.Load += new System.EventHandler(this.frmCaiDatMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonAn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grPanel.ResumeLayout(false);
            this.grPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbuGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTenMonAn)).EndInit();
            this.gpThucPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbuSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ADGV.AdvancedDataGridView dtgvMonAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel grPanel;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.TextBox txtMaMonAn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProviderTenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDanhMucMon;
        private System.Windows.Forms.NumericUpDown nbuGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDanhMuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lsvChiTietMonAn;
        private System.Windows.Forms.ColumnHeader tenThucPham;
        private System.Windows.Forms.ColumnHeader soLuong;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.Panel gpThucPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbThucPham;
        private System.Windows.Forms.NumericUpDown nbuSoLuong;
        private System.Windows.Forms.ColumnHeader donViTinh;
    }
}