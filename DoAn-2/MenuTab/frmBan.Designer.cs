
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
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.donGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(433, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 370);
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
            this.lsvHoaDon.Size = new System.Drawing.Size(486, 369);
            this.lsvHoaDon.TabIndex = 0;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // stt
            // 
            this.stt.Text = "STT";
            this.stt.Width = 36;
            // 
            // tenMon
            // 
            this.tenMon.Text = "Tên món";
            this.tenMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tenMon.Width = 196;
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
            this.thanhTien.Width = 108;
            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpBan);
            this.Name = "frmBan";
            this.Text = "Bàn";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.ColumnHeader tenMon;
        private System.Windows.Forms.ColumnHeader soLuong;
        private System.Windows.Forms.ColumnHeader donGia;
        private System.Windows.Forms.ColumnHeader thanhTien;
    }
}