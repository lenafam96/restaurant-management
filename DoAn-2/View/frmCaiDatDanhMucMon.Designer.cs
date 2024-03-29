﻿
namespace restaurant_management.View
{
    partial class frmCaiDatDanhMucMon
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
            this.dtgvDanhMucMon = new ADGV.AdvancedDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grPanel = new System.Windows.Forms.Panel();
            this.txtTenDanhMucMon = new System.Windows.Forms.TextBox();
            this.txtMaDanhMucMon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProviderTenDanhMucMon = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhMucMon)).BeginInit();
            this.panel2.SuspendLayout();
            this.grPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTenDanhMucMon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDanhMucMon
            // 
            this.dtgvDanhMucMon.AllowUserToAddRows = false;
            this.dtgvDanhMucMon.AllowUserToDeleteRows = false;
            this.dtgvDanhMucMon.AutoGenerateContextFilters = true;
            this.dtgvDanhMucMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhMucMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtgvDanhMucMon.DateWithTime = false;
            this.dtgvDanhMucMon.Location = new System.Drawing.Point(13, 165);
            this.dtgvDanhMucMon.Name = "dtgvDanhMucMon";
            this.dtgvDanhMucMon.ReadOnly = true;
            this.dtgvDanhMucMon.RowHeadersVisible = false;
            this.dtgvDanhMucMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhMucMon.Size = new System.Drawing.Size(910, 352);
            this.dtgvDanhMucMon.TabIndex = 28;
            this.dtgvDanhMucMon.TimeFilter = false;
            this.dtgvDanhMucMon.SortStringChanged += new System.EventHandler(this.dtgvDanhMucMon_SortStringChanged);
            this.dtgvDanhMucMon.FilterStringChanged += new System.EventHandler(this.dtgvDanhMucMon_FilterStringChanged);
            this.dtgvDanhMucMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhMucMon_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "maDanhMucMon";
            this.Column1.HeaderText = "Mã danh mục món";
            this.Column1.MinimumWidth = 22;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "tenDanhMucMon";
            this.Column2.HeaderText = "Tên danh mục món";
            this.Column2.MinimumWidth = 22;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(270, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 47);
            this.label1.TabIndex = 25;
            this.label1.Text = "QUẢN LÝ DANH MỤC MÓN";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(287, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 39);
            this.panel2.TabIndex = 27;
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
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            this.grPanel.Controls.Add(this.txtTenDanhMucMon);
            this.grPanel.Controls.Add(this.txtMaDanhMucMon);
            this.grPanel.Controls.Add(this.label6);
            this.grPanel.Controls.Add(this.label2);
            this.grPanel.Location = new System.Drawing.Point(13, 71);
            this.grPanel.Name = "grPanel";
            this.grPanel.Size = new System.Drawing.Size(910, 43);
            this.grPanel.TabIndex = 26;
            // 
            // txtTenDanhMucMon
            // 
            this.txtTenDanhMucMon.Location = new System.Drawing.Point(548, 10);
            this.txtTenDanhMucMon.Name = "txtTenDanhMucMon";
            this.txtTenDanhMucMon.Size = new System.Drawing.Size(335, 20);
            this.txtTenDanhMucMon.TabIndex = 1;
            this.txtTenDanhMucMon.Leave += new System.EventHandler(this.txtTenDanhMucMon_Leave);
            // 
            // txtMaDanhMucMon
            // 
            this.txtMaDanhMucMon.Location = new System.Drawing.Point(121, 10);
            this.txtMaDanhMucMon.Name = "txtMaDanhMucMon";
            this.txtMaDanhMucMon.ReadOnly = true;
            this.txtMaDanhMucMon.Size = new System.Drawing.Size(218, 20);
            this.txtMaDanhMucMon.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(427, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên danh mục món:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã danh mục món:";
            // 
            // errorProviderTenDanhMucMon
            // 
            this.errorProviderTenDanhMucMon.ContainerControl = this;
            // 
            // frmCaiDatDanhMucMon
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(936, 534);
            this.Controls.Add(this.dtgvDanhMucMon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grPanel);
            this.Name = "frmCaiDatDanhMucMon";
            this.Text = "frmCaiDatDanhMucMon";
            this.Load += new System.EventHandler(this.frmCaiDatDanhMucMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhMucMon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grPanel.ResumeLayout(false);
            this.grPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTenDanhMucMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ADGV.AdvancedDataGridView dtgvDanhMucMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel grPanel;
        private System.Windows.Forms.TextBox txtMaDanhMucMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProviderTenDanhMucMon;
        private System.Windows.Forms.TextBox txtTenDanhMucMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}