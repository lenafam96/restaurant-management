
namespace restaurant_management.MenuTab
{
    partial class frmPhanQuyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grPanel = new System.Windows.Forms.Panel();
            this.ckbKho = new System.Windows.Forms.CheckBox();
            this.ckbThongKe = new System.Windows.Forms.CheckBox();
            this.ckbVoucher = new System.Windows.Forms.CheckBox();
            this.ckbKhachHang = new System.Windows.Forms.CheckBox();
            this.ckbNhanVien = new System.Windows.Forms.CheckBox();
            this.ckbBan = new System.Windows.Forms.CheckBox();
            this.cboLoaiTK = new System.Windows.Forms.ComboBox();
            this.grPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(272, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 47);
            this.label1.TabIndex = 12;
            this.label1.Text = "PHÂN QUYỀN TÀI KHOẢN";
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Location = new System.Drawing.Point(841, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 26);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(29, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chức năng:";
            // 
            // grPanel
            // 
            this.grPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grPanel.Controls.Add(this.ckbKho);
            this.grPanel.Controls.Add(this.ckbThongKe);
            this.grPanel.Controls.Add(this.ckbVoucher);
            this.grPanel.Controls.Add(this.ckbKhachHang);
            this.grPanel.Controls.Add(this.ckbNhanVien);
            this.grPanel.Controls.Add(this.ckbBan);
            this.grPanel.Controls.Add(this.cboLoaiTK);
            this.grPanel.Controls.Add(this.label3);
            this.grPanel.Controls.Add(this.label2);
            this.grPanel.Location = new System.Drawing.Point(9, 96);
            this.grPanel.Name = "grPanel";
            this.grPanel.Size = new System.Drawing.Size(910, 221);
            this.grPanel.TabIndex = 13;
            // 
            // ckbKho
            // 
            this.ckbKho.AutoSize = true;
            this.ckbKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbKho.Location = new System.Drawing.Point(131, 167);
            this.ckbKho.Name = "ckbKho";
            this.ckbKho.Size = new System.Drawing.Size(111, 24);
            this.ckbKho.TabIndex = 9;
            this.ckbKho.Text = "Quản lý kho";
            this.ckbKho.UseVisualStyleBackColor = true;
            // 
            // ckbThongKe
            // 
            this.ckbThongKe.AutoSize = true;
            this.ckbThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbThongKe.Location = new System.Drawing.Point(131, 143);
            this.ckbThongKe.Name = "ckbThongKe";
            this.ckbThongKe.Size = new System.Drawing.Size(94, 24);
            this.ckbThongKe.TabIndex = 9;
            this.ckbThongKe.Text = "Thống kê";
            this.ckbThongKe.UseVisualStyleBackColor = true;
            // 
            // ckbVoucher
            // 
            this.ckbVoucher.AutoSize = true;
            this.ckbVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbVoucher.Location = new System.Drawing.Point(131, 119);
            this.ckbVoucher.Name = "ckbVoucher";
            this.ckbVoucher.Size = new System.Drawing.Size(141, 24);
            this.ckbVoucher.TabIndex = 9;
            this.ckbVoucher.Text = "Quản lý voucher";
            this.ckbVoucher.UseVisualStyleBackColor = true;
            // 
            // ckbKhachHang
            // 
            this.ckbKhachHang.AutoSize = true;
            this.ckbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbKhachHang.Location = new System.Drawing.Point(131, 95);
            this.ckbKhachHang.Name = "ckbKhachHang";
            this.ckbKhachHang.Size = new System.Drawing.Size(168, 24);
            this.ckbKhachHang.TabIndex = 9;
            this.ckbKhachHang.Text = "Quản lý khách hàng";
            this.ckbKhachHang.UseVisualStyleBackColor = true;
            // 
            // ckbNhanVien
            // 
            this.ckbNhanVien.AutoSize = true;
            this.ckbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNhanVien.Location = new System.Drawing.Point(131, 71);
            this.ckbNhanVien.Name = "ckbNhanVien";
            this.ckbNhanVien.Size = new System.Drawing.Size(153, 24);
            this.ckbNhanVien.TabIndex = 9;
            this.ckbNhanVien.Text = "Quản lý nhân viên";
            this.ckbNhanVien.UseVisualStyleBackColor = true;
            // 
            // ckbBan
            // 
            this.ckbBan.AutoSize = true;
            this.ckbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBan.Location = new System.Drawing.Point(131, 47);
            this.ckbBan.Name = "ckbBan";
            this.ckbBan.Size = new System.Drawing.Size(112, 24);
            this.ckbBan.TabIndex = 9;
            this.ckbBan.Text = "Quản lý bàn";
            this.ckbBan.UseVisualStyleBackColor = true;
            // 
            // cboLoaiTK
            // 
            this.cboLoaiTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiTK.FormattingEnabled = true;
            this.cboLoaiTK.Location = new System.Drawing.Point(131, 8);
            this.cboLoaiTK.Name = "cboLoaiTK";
            this.cboLoaiTK.Size = new System.Drawing.Size(238, 28);
            this.cboLoaiTK.TabIndex = 8;
            this.cboLoaiTK.SelectedIndexChanged += new System.EventHandler(this.cboLoaiTK_SelectedIndexChanged);
            // 
            // frmPhanQuyen
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 536);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grPanel);
            this.Name = "frmPhanQuyen";
            this.Text = "Phân quyền";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.grPanel.ResumeLayout(false);
            this.grPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel grPanel;
        private System.Windows.Forms.CheckBox ckbKho;
        private System.Windows.Forms.CheckBox ckbThongKe;
        private System.Windows.Forms.CheckBox ckbVoucher;
        private System.Windows.Forms.CheckBox ckbKhachHang;
        private System.Windows.Forms.CheckBox ckbNhanVien;
        private System.Windows.Forms.CheckBox ckbBan;
        private System.Windows.Forms.ComboBox cboLoaiTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
    }
}