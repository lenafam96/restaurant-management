
namespace restaurant_management.MenuTab
{
    partial class frmVoucher
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radTienMat = new System.Windows.Forms.RadioButton();
            this.radPhanTram = new System.Windows.Forms.RadioButton();
            this.dtpkNgayBD = new System.Windows.Forms.DateTimePicker();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.dtgvVoucher = new ADGV.AdvancedDataGridView();
            this.maVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaVoucher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grPanel = new System.Windows.Forms.Panel();
            this.nbuGiaTri = new System.Windows.Forms.NumericUpDown();
            this.dtpkNgayKT = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVoucher)).BeginInit();
            this.grPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbuGiaTri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 30);
            this.btnAdd.TabIndex = 9;
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
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel.Location = new System.Drawing.Point(255, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 30);
            this.btnCancel.TabIndex = 12;
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
            this.btnSave.TabIndex = 14;
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
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(498, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 40);
            this.panel1.TabIndex = 19;
            // 
            // radTienMat
            // 
            this.radTienMat.AutoSize = true;
            this.radTienMat.Location = new System.Drawing.Point(828, 10);
            this.radTienMat.Name = "radTienMat";
            this.radTienMat.Size = new System.Drawing.Size(66, 17);
            this.radTienMat.TabIndex = 5;
            this.radTienMat.TabStop = true;
            this.radTienMat.Text = "Tiền mặt";
            this.radTienMat.UseVisualStyleBackColor = true;
            // 
            // radPhanTram
            // 
            this.radPhanTram.AutoSize = true;
            this.radPhanTram.Location = new System.Drawing.Point(744, 10);
            this.radPhanTram.Name = "radPhanTram";
            this.radPhanTram.Size = new System.Drawing.Size(73, 17);
            this.radPhanTram.TabIndex = 4;
            this.radPhanTram.TabStop = true;
            this.radPhanTram.Text = "Phần trăm";
            this.radPhanTram.UseVisualStyleBackColor = true;
            this.radPhanTram.CheckedChanged += new System.EventHandler(this.radPhanTram_CheckedChanged);
            // 
            // dtpkNgayBD
            // 
            this.dtpkNgayBD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayBD.Location = new System.Drawing.Point(115, 38);
            this.dtpkNgayBD.Name = "dtpkNgayBD";
            this.dtpkNgayBD.Size = new System.Drawing.Size(307, 22);
            this.dtpkNgayBD.TabIndex = 3;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(543, 43);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(351, 50);
            this.txtMoTa.TabIndex = 7;
            // 
            // dtgvVoucher
            // 
            this.dtgvVoucher.AllowUserToAddRows = false;
            this.dtgvVoucher.AllowUserToDeleteRows = false;
            this.dtgvVoucher.AutoGenerateContextFilters = true;
            this.dtgvVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maVoucher,
            this.ngayBatDau,
            this.ngayKetThuc,
            this.moTa,
            this.giaTri,
            this.loai});
            this.dtgvVoucher.DateWithTime = false;
            this.dtgvVoucher.Location = new System.Drawing.Point(9, 223);
            this.dtgvVoucher.Name = "dtgvVoucher";
            this.dtgvVoucher.ReadOnly = true;
            this.dtgvVoucher.RowHeadersVisible = false;
            this.dtgvVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvVoucher.Size = new System.Drawing.Size(913, 303);
            this.dtgvVoucher.TabIndex = 18;
            this.dtgvVoucher.TimeFilter = false;
            this.dtgvVoucher.SortStringChanged += new System.EventHandler(this.dtgvKhachHang_SortStringChanged);
            this.dtgvVoucher.FilterStringChanged += new System.EventHandler(this.dtgvKhachHang_FilterStringChanged);
            this.dtgvVoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVoucher_CellClick);
            // 
            // maVoucher
            // 
            this.maVoucher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maVoucher.DataPropertyName = "maVoucher";
            this.maVoucher.HeaderText = "Mã Voucher";
            this.maVoucher.MinimumWidth = 22;
            this.maVoucher.Name = "maVoucher";
            this.maVoucher.ReadOnly = true;
            this.maVoucher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ngayBatDau
            // 
            this.ngayBatDau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayBatDau.DataPropertyName = "ngayBatDau";
            this.ngayBatDau.HeaderText = "Ngày bắt đầu";
            this.ngayBatDau.MinimumWidth = 22;
            this.ngayBatDau.Name = "ngayBatDau";
            this.ngayBatDau.ReadOnly = true;
            this.ngayBatDau.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayKetThuc.DataPropertyName = "ngayKetThuc";
            this.ngayKetThuc.HeaderText = "Ngày kết thúc";
            this.ngayKetThuc.MinimumWidth = 22;
            this.ngayKetThuc.Name = "ngayKetThuc";
            this.ngayKetThuc.ReadOnly = true;
            this.ngayKetThuc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // moTa
            // 
            this.moTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.moTa.DataPropertyName = "moTa";
            this.moTa.HeaderText = "Mô tả";
            this.moTa.MinimumWidth = 22;
            this.moTa.Name = "moTa";
            this.moTa.ReadOnly = true;
            this.moTa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.moTa.Width = 300;
            // 
            // giaTri
            // 
            this.giaTri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaTri.DataPropertyName = "giaTri";
            this.giaTri.HeaderText = "Giá trị";
            this.giaTri.MinimumWidth = 22;
            this.giaTri.Name = "giaTri";
            this.giaTri.ReadOnly = true;
            this.giaTri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // loai
            // 
            this.loai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loai.DataPropertyName = "loai";
            this.loai.HeaderText = "Loại";
            this.loai.MinimumWidth = 22;
            this.loai.Name = "loai";
            this.loai.ReadOnly = true;
            this.loai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(489, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mô tả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(3, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày kết thúc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(688, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(487, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá trị:";
            // 
            // txtMaVoucher
            // 
            this.txtMaVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVoucher.Location = new System.Drawing.Point(115, 8);
            this.txtMaVoucher.Name = "txtMaVoucher";
            this.txtMaVoucher.ReadOnly = true;
            this.txtMaVoucher.Size = new System.Drawing.Size(307, 22);
            this.txtMaVoucher.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 47);
            this.label1.TabIndex = 20;
            this.label1.Text = "QUẢN LÝ VOUCHER";
            // 
            // grPanel
            // 
            this.grPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grPanel.Controls.Add(this.nbuGiaTri);
            this.grPanel.Controls.Add(this.radTienMat);
            this.grPanel.Controls.Add(this.radPhanTram);
            this.grPanel.Controls.Add(this.dtpkNgayKT);
            this.grPanel.Controls.Add(this.dtpkNgayBD);
            this.grPanel.Controls.Add(this.txtMoTa);
            this.grPanel.Controls.Add(this.label7);
            this.grPanel.Controls.Add(this.label5);
            this.grPanel.Controls.Add(this.label6);
            this.grPanel.Controls.Add(this.label4);
            this.grPanel.Controls.Add(this.label3);
            this.grPanel.Controls.Add(this.txtMaVoucher);
            this.grPanel.Controls.Add(this.label2);
            this.grPanel.Location = new System.Drawing.Point(9, 64);
            this.grPanel.Name = "grPanel";
            this.grPanel.Size = new System.Drawing.Size(913, 107);
            this.grPanel.TabIndex = 21;
            // 
            // nbuGiaTri
            // 
            this.nbuGiaTri.Location = new System.Drawing.Point(544, 10);
            this.nbuGiaTri.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nbuGiaTri.Name = "nbuGiaTri";
            this.nbuGiaTri.Size = new System.Drawing.Size(138, 20);
            this.nbuGiaTri.TabIndex = 8;
            // 
            // dtpkNgayKT
            // 
            this.dtpkNgayKT.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayKT.Location = new System.Drawing.Point(115, 71);
            this.dtpkNgayKT.Name = "dtpkNgayKT";
            this.dtpkNgayKT.Size = new System.Drawing.Size(307, 22);
            this.dtpkNgayKT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Voucher:";
            // 
            // frmVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvVoucher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grPanel);
            this.Name = "frmVoucher";
            this.Text = "Voucher";
            this.Load += new System.EventHandler(this.frmVoucher_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVoucher)).EndInit();
            this.grPanel.ResumeLayout(false);
            this.grPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbuGiaTri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radTienMat;
        private System.Windows.Forms.RadioButton radPhanTram;
        private System.Windows.Forms.DateTimePicker dtpkNgayBD;
        private System.Windows.Forms.TextBox txtMoTa;
        private ADGV.AdvancedDataGridView dtgvVoucher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaVoucher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel grPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkNgayKT;
        private System.Windows.Forms.NumericUpDown nbuGiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
    }
}