
namespace restaurant_management.MenuTab
{
    partial class frmNhapKho
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
            this.cmbThucPham = new System.Windows.Forms.ComboBox();
            this.nbuSoLuong = new System.Windows.Forms.NumericUpDown();
            this.gpThucPham = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.donViTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenThucPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvChiTietPhieuNhap = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProviderTenMonAn = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvPhieuNhap = new ADGV.AdvancedDataGridView();
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grPanel = new System.Windows.Forms.Panel();
            this.dtpkNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.nbuGia = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nbuSoLuong)).BeginInit();
            this.gpThucPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTenMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhap)).BeginInit();
            this.panel2.SuspendLayout();
            this.grPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbuGia)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbThucPham
            // 
            this.cmbThucPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThucPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThucPham.FormattingEnabled = true;
            this.cmbThucPham.Location = new System.Drawing.Point(3, 8);
            this.cmbThucPham.Name = "cmbThucPham";
            this.cmbThucPham.Size = new System.Drawing.Size(176, 23);
            this.cmbThucPham.TabIndex = 15;
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
            this.nbuSoLuong.Size = new System.Drawing.Size(59, 24);
            this.nbuSoLuong.TabIndex = 16;
            // 
            // gpThucPham
            // 
            this.gpThucPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gpThucPham.Controls.Add(this.cmbThucPham);
            this.gpThucPham.Controls.Add(this.btnThem);
            this.gpThucPham.Controls.Add(this.nbuGia);
            this.gpThucPham.Controls.Add(this.nbuSoLuong);
            this.gpThucPham.Location = new System.Drawing.Point(488, 121);
            this.gpThucPham.Name = "gpThucPham";
            this.gpThucPham.Size = new System.Drawing.Size(433, 39);
            this.gpThucPham.TabIndex = 36;
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.Location = new System.Drawing.Point(370, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 26);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // donViTinh
            // 
            this.donViTinh.Text = "Đơn vị";
            this.donViTinh.Width = 70;
            // 
            // soLuong
            // 
            this.soLuong.Text = "Số lượng";
            this.soLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soLuong.Width = 63;
            // 
            // tenThucPham
            // 
            this.tenThucPham.Text = "Tên thực phẩm";
            this.tenThucPham.Width = 162;
            // 
            // stt
            // 
            this.stt.Text = "STT";
            this.stt.Width = 40;
            // 
            // lsvChiTietPhieuNhap
            // 
            this.lsvChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.tenThucPham,
            this.soLuong,
            this.donViTinh,
            this.columnHeader1});
            this.lsvChiTietPhieuNhap.FullRowSelect = true;
            this.lsvChiTietPhieuNhap.GridLines = true;
            this.lsvChiTietPhieuNhap.HideSelection = false;
            this.lsvChiTietPhieuNhap.Location = new System.Drawing.Point(488, 166);
            this.lsvChiTietPhieuNhap.Name = "lsvChiTietPhieuNhap";
            this.lsvChiTietPhieuNhap.Size = new System.Drawing.Size(433, 352);
            this.lsvChiTietPhieuNhap.TabIndex = 39;
            this.lsvChiTietPhieuNhap.UseCompatibleStateImageBehavior = false;
            this.lsvChiTietPhieuNhap.View = System.Windows.Forms.View.Details;
            this.lsvChiTietPhieuNhap.SelectedIndexChanged += new System.EventHandler(this.lsvChiTietPhieuNhap_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Giá";
            this.columnHeader1.Width = 88;
            // 
            // errorProviderTenMonAn
            // 
            this.errorProviderTenMonAn.ContainerControl = this;
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(275, 10);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(185, 21);
            this.cmbNhaCungCap.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(185, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nhà cung cấp:";
            // 
            // dtgvPhieuNhap
            // 
            this.dtgvPhieuNhap.AllowUserToAddRows = false;
            this.dtgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dtgvPhieuNhap.AutoGenerateContextFilters = true;
            this.dtgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.gia,
            this.tenDanhMucMon});
            this.dtgvPhieuNhap.DateWithTime = false;
            this.dtgvPhieuNhap.Location = new System.Drawing.Point(10, 166);
            this.dtgvPhieuNhap.Name = "dtgvPhieuNhap";
            this.dtgvPhieuNhap.ReadOnly = true;
            this.dtgvPhieuNhap.RowHeadersVisible = false;
            this.dtgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPhieuNhap.Size = new System.Drawing.Size(472, 352);
            this.dtgvPhieuNhap.TabIndex = 38;
            this.dtgvPhieuNhap.TimeFilter = false;
            this.dtgvPhieuNhap.SortStringChanged += new System.EventHandler(this.dtgvPhieuNhap_SortStringChanged);
            this.dtgvPhieuNhap.FilterStringChanged += new System.EventHandler(this.dtgvPhieuNhap_FilterStringChanged);
            this.dtgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPhieuNhap_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maPhieuNhap";
            this.Column1.HeaderText = "Mã phiếu nhập";
            this.Column1.MinimumWidth = 22;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "tenNhaCungCap";
            this.Column2.HeaderText = "Nhà cung cấp";
            this.Column2.MinimumWidth = 22;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "ngayNhap";
            this.gia.HeaderText = "Ngày nhập";
            this.gia.MinimumWidth = 22;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            this.gia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tenDanhMucMon
            // 
            this.tenDanhMucMon.DataPropertyName = "tongTien";
            this.tenDanhMucMon.HeaderText = "Tổng tiền";
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
            this.label1.Location = new System.Drawing.Point(290, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 47);
            this.label1.TabIndex = 34;
            this.label1.Text = "QUẢN LÝ PHIẾU NHẬP";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(42, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 39);
            this.panel2.TabIndex = 37;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(720, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tổng tiền:";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(100, 12);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.ReadOnly = true;
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(67, 20);
            this.txtMaPhieuNhap.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(473, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu nhập:";
            // 
            // grPanel
            // 
            this.grPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grPanel.Controls.Add(this.dtpkNgayNhap);
            this.grPanel.Controls.Add(this.cmbNhaCungCap);
            this.grPanel.Controls.Add(this.label3);
            this.grPanel.Controls.Add(this.label8);
            this.grPanel.Controls.Add(this.txtTongTien);
            this.grPanel.Controls.Add(this.txtMaPhieuNhap);
            this.grPanel.Controls.Add(this.label6);
            this.grPanel.Controls.Add(this.label2);
            this.grPanel.Location = new System.Drawing.Point(10, 72);
            this.grPanel.Name = "grPanel";
            this.grPanel.Size = new System.Drawing.Size(910, 43);
            this.grPanel.TabIndex = 35;
            // 
            // dtpkNgayNhap
            // 
            this.dtpkNgayNhap.Location = new System.Drawing.Point(547, 9);
            this.dtpkNgayNhap.Name = "dtpkNgayNhap";
            this.dtpkNgayNhap.Size = new System.Drawing.Size(152, 20);
            this.dtpkNgayNhap.TabIndex = 3;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(798, 9);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(105, 20);
            this.txtTongTien.TabIndex = 4;
            // 
            // nbuGia
            // 
            this.nbuGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbuGia.Location = new System.Drawing.Point(250, 7);
            this.nbuGia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nbuGia.Name = "nbuGia";
            this.nbuGia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nbuGia.Size = new System.Drawing.Size(114, 24);
            this.nbuGia.TabIndex = 16;
            // 
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 536);
            this.Controls.Add(this.gpThucPham);
            this.Controls.Add(this.lsvChiTietPhieuNhap);
            this.Controls.Add(this.dtgvPhieuNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grPanel);
            this.Name = "frmNhapKho";
            this.Text = "Phiếu nhập";
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbuSoLuong)).EndInit();
            this.gpThucPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTenMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grPanel.ResumeLayout(false);
            this.grPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbuGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbThucPham;
        private System.Windows.Forms.NumericUpDown nbuSoLuong;
        private System.Windows.Forms.Panel gpThucPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ColumnHeader donViTinh;
        private System.Windows.Forms.ColumnHeader soLuong;
        private System.Windows.Forms.ColumnHeader tenThucPham;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.ListView lsvChiTietPhieuNhap;
        private System.Windows.Forms.ErrorProvider errorProviderTenMonAn;
        private ADGV.AdvancedDataGridView dtgvPhieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel grPanel;
        private System.Windows.Forms.ComboBox cmbNhaCungCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkNgayNhap;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDanhMucMon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.NumericUpDown nbuGia;
    }
}