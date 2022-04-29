
namespace restaurant_management.MenuTab
{
    partial class frmBan
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
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.donGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lbTenBan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbVoucher = new System.Windows.Forms.Label();
            this.lbSuDungDiem = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProviderVoucher = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.errorProviderKhachHang = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpanel = new System.Windows.Forms.Panel();
            this.nbuSuDungDiem = new System.Windows.Forms.NumericUpDown();
            this.txtMaVoucher = new System.Windows.Forms.TextBox();
            this.txtDiemTichLuy = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenKhachHang = new System.Windows.Forms.Label();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.cmbBan = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKhachHang)).BeginInit();
            this.grpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbuSuDungDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // flpBan
            // 
            this.flpBan.AutoScroll = true;
            this.flpBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBan.Location = new System.Drawing.Point(12, 12);
            this.flpBan.Name = "flpBan";
            this.flpBan.Padding = new System.Windows.Forms.Padding(7);
            this.flpBan.Size = new System.Drawing.Size(415, 512);
            this.flpBan.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvHoaDon);
            this.panel1.Location = new System.Drawing.Point(433, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 342);
            this.panel1.TabIndex = 1;
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.tenMon,
            this.soLuong,
            this.donGia,
            this.thanhTien});
            this.lsvHoaDon.FullRowSelect = true;
            this.lsvHoaDon.GridLines = true;
            this.lsvHoaDon.HideSelection = false;
            this.lsvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(486, 342);
            this.lsvHoaDon.TabIndex = 0;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // stt
            // 
            this.stt.Text = "STT";
            this.stt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stt.Width = 36;
            // 
            // tenMon
            // 
            this.tenMon.Text = "Tên món";
            this.tenMon.Width = 194;
            // 
            // soLuong
            // 
            this.soLuong.Text = "Số lượng";
            this.soLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // donGia
            // 
            this.donGia.Text = "Đơn giá";
            this.donGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.donGia.Width = 82;
            // 
            // thanhTien
            // 
            this.thanhTien.Text = "Thành tiền";
            this.thanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.thanhTien.Width = 101;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(844, 13);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(75, 23);
            this.btnThemMon.TabIndex = 2;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.Location = new System.Drawing.Point(433, 13);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(97, 23);
            this.btnTaoHoaDon.TabIndex = 1;
            this.btnTaoHoaDon.Text = "Tạo hoá đơn";
            this.btnTaoHoaDon.UseVisualStyleBackColor = true;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(704, 501);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(175, 23);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lbTenBan
            // 
            this.lbTenBan.AutoSize = true;
            this.lbTenBan.Location = new System.Drawing.Point(667, 18);
            this.lbTenBan.Name = "lbTenBan";
            this.lbTenBan.Size = new System.Drawing.Size(44, 13);
            this.lbTenBan.TabIndex = 3;
            this.lbTenBan.Text = "Bàn xxx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng tiền";
            // 
            // lbTongTien
            // 
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(789, 421);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(90, 13);
            this.lbTongTien.TabIndex = 8;
            this.lbTongTien.Text = "đ1.000.000";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbVoucher
            // 
            this.lbVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVoucher.Location = new System.Drawing.Point(789, 438);
            this.lbVoucher.Name = "lbVoucher";
            this.lbVoucher.Size = new System.Drawing.Size(90, 13);
            this.lbVoucher.TabIndex = 8;
            this.lbVoucher.Text = "- đ1.000.000";
            this.lbVoucher.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbSuDungDiem
            // 
            this.lbSuDungDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuDungDiem.Location = new System.Drawing.Point(789, 454);
            this.lbSuDungDiem.Name = "lbSuDungDiem";
            this.lbSuDungDiem.Size = new System.Drawing.Size(90, 13);
            this.lbSuDungDiem.TabIndex = 8;
            this.lbSuDungDiem.Text = "- đ1.000.000";
            this.lbSuDungDiem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.Location = new System.Drawing.Point(789, 477);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(90, 13);
            this.lbThanhTien.TabIndex = 8;
            this.lbThanhTien.Text = "đ1.000.000";
            this.lbThanhTien.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbThanhTien.TextChanged += new System.EventHandler(this.lbThanhTien_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(701, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Thành tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(701, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Voucher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(701, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sử dụng điểm";
            // 
            // errorProviderVoucher
            // 
            this.errorProviderVoucher.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(703, 464);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 10);
            this.label8.TabIndex = 9;
            this.label8.Text = "--------------------------------------------------------";
            // 
            // errorProviderKhachHang
            // 
            this.errorProviderKhachHang.ContainerControl = this;
            // 
            // grpanel
            // 
            this.grpanel.Controls.Add(this.nbuSuDungDiem);
            this.grpanel.Controls.Add(this.txtMaVoucher);
            this.grpanel.Controls.Add(this.txtDiemTichLuy);
            this.grpanel.Controls.Add(this.txtMaKhachHang);
            this.grpanel.Controls.Add(this.label4);
            this.grpanel.Controls.Add(this.label3);
            this.grpanel.Controls.Add(this.label2);
            this.grpanel.Controls.Add(this.label1);
            this.grpanel.Location = new System.Drawing.Point(433, 388);
            this.grpanel.Name = "grpanel";
            this.grpanel.Size = new System.Drawing.Size(234, 107);
            this.grpanel.TabIndex = 10;
            // 
            // nbuSuDungDiem
            // 
            this.nbuSuDungDiem.Location = new System.Drawing.Point(96, 59);
            this.nbuSuDungDiem.Name = "nbuSuDungDiem";
            this.nbuSuDungDiem.Size = new System.Drawing.Size(122, 20);
            this.nbuSuDungDiem.TabIndex = 5;
            this.nbuSuDungDiem.ValueChanged += new System.EventHandler(this.nbuSuDungDiem_ValueChanged);
            // 
            // txtMaVoucher
            // 
            this.txtMaVoucher.Location = new System.Drawing.Point(96, 30);
            this.txtMaVoucher.Name = "txtMaVoucher";
            this.txtMaVoucher.Size = new System.Drawing.Size(122, 20);
            this.txtMaVoucher.TabIndex = 4;
            this.txtMaVoucher.Leave += new System.EventHandler(this.txtMaVoucher_Leave);
            // 
            // txtDiemTichLuy
            // 
            this.txtDiemTichLuy.Location = new System.Drawing.Point(96, 86);
            this.txtDiemTichLuy.Name = "txtDiemTichLuy";
            this.txtDiemTichLuy.ReadOnly = true;
            this.txtDiemTichLuy.Size = new System.Drawing.Size(122, 20);
            this.txtDiemTichLuy.TabIndex = 13;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(96, 2);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(122, 20);
            this.txtMaKhachHang.TabIndex = 3;
            this.txtMaKhachHang.Leave += new System.EventHandler(this.txtMaKhachHang_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã voucher:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Điểm tích luỹ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sử dụng điểm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã khách hàng:";
            // 
            // lbTenKhachHang
            // 
            this.lbTenKhachHang.AutoSize = true;
            this.lbTenKhachHang.Location = new System.Drawing.Point(667, 393);
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            this.lbTenKhachHang.Size = new System.Drawing.Size(168, 13);
            this.lbTenKhachHang.TabIndex = 11;
            this.lbTenKhachHang.Text = "Tên khách hàng hiện có xxx điểm";
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Location = new System.Drawing.Point(536, 501);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(75, 23);
            this.btnChuyenBan.TabIndex = 6;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // cmbBan
            // 
            this.cmbBan.FormattingEnabled = true;
            this.cmbBan.Location = new System.Drawing.Point(433, 503);
            this.cmbBan.Name = "cmbBan";
            this.cmbBan.Size = new System.Drawing.Size(97, 21);
            this.cmbBan.TabIndex = 12;
            this.cmbBan.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbBan_Format);
            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 536);
            this.Controls.Add(this.cmbBan);
            this.Controls.Add(this.grpanel);
            this.Controls.Add(this.lbThanhTien);
            this.Controls.Add(this.lbSuDungDiem);
            this.Controls.Add(this.lbVoucher);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbTenKhachHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTenBan);
            this.Controls.Add(this.btnChuyenBan);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnTaoHoaDon);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpBan);
            this.Controls.Add(this.label8);
            this.Name = "frmBan";
            this.Text = "Bàn";
            this.Load += new System.EventHandler(this.frmBan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKhachHang)).EndInit();
            this.grpanel.ResumeLayout(false);
            this.grpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbuSuDungDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.ColumnHeader tenMon;
        private System.Windows.Forms.ColumnHeader soLuong;
        private System.Windows.Forms.ColumnHeader donGia;
        private System.Windows.Forms.ColumnHeader thanhTien;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lbTenBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbVoucher;
        private System.Windows.Forms.Label lbSuDungDiem;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProviderVoucher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProviderKhachHang;
        private System.Windows.Forms.Panel grpanel;
        private System.Windows.Forms.NumericUpDown nbuSuDungDiem;
        private System.Windows.Forms.TextBox txtMaVoucher;
        private System.Windows.Forms.TextBox txtDiemTichLuy;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTenKhachHang;
        private System.Windows.Forms.ComboBox cmbBan;
        private System.Windows.Forms.Button btnChuyenBan;
    }
}