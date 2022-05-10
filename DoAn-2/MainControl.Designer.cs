namespace restaurant_management
{
    partial class MainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.PanelDropDownSP = new System.Windows.Forms.Panel();
            this.iconButtonNhapKho = new FontAwesome.Sharp.IconButton();
            this.iconButtonTonKho = new FontAwesome.Sharp.IconButton();
            this.iconButtonKho = new FontAwesome.Sharp.IconButton();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnVoucher = new FontAwesome.Sharp.IconButton();
            this.btnBan = new FontAwesome.Sharp.IconButton();
            this.btnKhachHang = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            this.iconMinimize = new FontAwesome.Sharp.IconButton();
            this.iconZoom = new FontAwesome.Sharp.IconButton();
            this.iconExit = new FontAwesome.Sharp.IconButton();
            this.labelcon = new System.Windows.Forms.Label();
            this.iconmenusmall = new FontAwesome.Sharp.IconPictureBox();
            this.panelshadow = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.paneltrangcon = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.PanelDropDownSP.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconmenusmall)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PanelMenu.Controls.Add(this.btnNhanVien);
            this.PanelMenu.Controls.Add(this.btnSetting);
            this.PanelMenu.Controls.Add(this.PanelDropDownSP);
            this.PanelMenu.Controls.Add(this.btnThongKe);
            this.PanelMenu.Controls.Add(this.btnLogout);
            this.PanelMenu.Controls.Add(this.btnVoucher);
            this.PanelMenu.Controls.Add(this.btnBan);
            this.PanelMenu.Controls.Add(this.btnKhachHang);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(170, 600);
            this.PanelMenu.TabIndex = 0;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.Odnoklassniki;
            this.btnNhanVien.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNhanVien.IconSize = 35;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 150);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNhanVien.Rotation = 0D;
            this.btnNhanVien.Size = new System.Drawing.Size(170, 50);
            this.btnNhanVien.TabIndex = 9;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSetting.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconSize = 35;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 500);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSetting.Rotation = 0D;
            this.btnSetting.Size = new System.Drawing.Size(170, 50);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "Thiết lập";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // PanelDropDownSP
            // 
            this.PanelDropDownSP.Controls.Add(this.iconButtonNhapKho);
            this.PanelDropDownSP.Controls.Add(this.iconButtonTonKho);
            this.PanelDropDownSP.Controls.Add(this.iconButtonKho);
            this.PanelDropDownSP.Location = new System.Drawing.Point(0, 350);
            this.PanelDropDownSP.Name = "PanelDropDownSP";
            this.PanelDropDownSP.Size = new System.Drawing.Size(170, 50);
            this.PanelDropDownSP.TabIndex = 5;
            // 
            // iconButtonNhapKho
            // 
            this.iconButtonNhapKho.BackColor = System.Drawing.Color.Indigo;
            this.iconButtonNhapKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonNhapKho.FlatAppearance.BorderSize = 0;
            this.iconButtonNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNhapKho.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonNhapKho.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonNhapKho.IconChar = FontAwesome.Sharp.IconChar.WeightHanging;
            this.iconButtonNhapKho.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonNhapKho.IconSize = 35;
            this.iconButtonNhapKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNhapKho.Location = new System.Drawing.Point(0, 100);
            this.iconButtonNhapKho.Name = "iconButtonNhapKho";
            this.iconButtonNhapKho.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonNhapKho.Rotation = 0D;
            this.iconButtonNhapKho.Size = new System.Drawing.Size(170, 50);
            this.iconButtonNhapKho.TabIndex = 6;
            this.iconButtonNhapKho.Text = "Nhập Kho";
            this.iconButtonNhapKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNhapKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonNhapKho.UseVisualStyleBackColor = false;
            this.iconButtonNhapKho.Click += new System.EventHandler(this.iconButtonNhapKho_Click);
            // 
            // iconButtonTonKho
            // 
            this.iconButtonTonKho.BackColor = System.Drawing.Color.Indigo;
            this.iconButtonTonKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonTonKho.FlatAppearance.BorderSize = 0;
            this.iconButtonTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTonKho.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonTonKho.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonTonKho.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.iconButtonTonKho.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonTonKho.IconSize = 35;
            this.iconButtonTonKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTonKho.Location = new System.Drawing.Point(0, 50);
            this.iconButtonTonKho.Name = "iconButtonTonKho";
            this.iconButtonTonKho.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonTonKho.Rotation = 0D;
            this.iconButtonTonKho.Size = new System.Drawing.Size(170, 50);
            this.iconButtonTonKho.TabIndex = 5;
            this.iconButtonTonKho.Text = "Tồn Kho";
            this.iconButtonTonKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTonKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonTonKho.UseVisualStyleBackColor = false;
            this.iconButtonTonKho.Click += new System.EventHandler(this.iconButtonTonKho_Click);
            // 
            // iconButtonKho
            // 
            this.iconButtonKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonKho.FlatAppearance.BorderSize = 0;
            this.iconButtonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonKho.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonKho.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonKho.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.iconButtonKho.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonKho.IconSize = 35;
            this.iconButtonKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonKho.Location = new System.Drawing.Point(0, 0);
            this.iconButtonKho.Name = "iconButtonKho";
            this.iconButtonKho.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonKho.Rotation = 0D;
            this.iconButtonKho.Size = new System.Drawing.Size(170, 50);
            this.iconButtonKho.TabIndex = 4;
            this.iconButtonKho.Text = "Kho";
            this.iconButtonKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonKho.UseVisualStyleBackColor = true;
            this.iconButtonKho.Click += new System.EventHandler(this.iconButtonSP_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.TachometerAlt;
            this.btnThongKe.IconColor = System.Drawing.Color.Gainsboro;
            this.btnThongKe.IconSize = 35;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 300);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnThongKe.Rotation = 0D;
            this.btnThongKe.Size = new System.Drawing.Size(170, 50);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconSize = 35;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 550);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogout.Rotation = 0D;
            this.btnLogout.Size = new System.Drawing.Size(170, 50);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnVoucher
            // 
            this.btnVoucher.FlatAppearance.BorderSize = 0;
            this.btnVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoucher.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoucher.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVoucher.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnVoucher.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVoucher.IconSize = 35;
            this.btnVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoucher.Location = new System.Drawing.Point(0, 250);
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVoucher.Rotation = 0D;
            this.btnVoucher.Size = new System.Drawing.Size(170, 50);
            this.btnVoucher.TabIndex = 6;
            this.btnVoucher.Text = "Voucher";
            this.btnVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoucher.UseVisualStyleBackColor = true;
            this.btnVoucher.Click += new System.EventHandler(this.btnVoucher_Click);
            // 
            // btnBan
            // 
            this.btnBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBan.FlatAppearance.BorderSize = 0;
            this.btnBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBan.IconChar = FontAwesome.Sharp.IconChar.Microsoft;
            this.btnBan.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBan.IconSize = 35;
            this.btnBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBan.Location = new System.Drawing.Point(0, 100);
            this.btnBan.Name = "btnBan";
            this.btnBan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBan.Rotation = 0D;
            this.btnBan.Size = new System.Drawing.Size(170, 50);
            this.btnBan.TabIndex = 2;
            this.btnBan.Text = "Bàn";
            this.btnBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.Male;
            this.btnKhachHang.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKhachHang.IconSize = 35;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 200);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKhachHang.Rotation = 0D;
            this.btnKhachHang.Size = new System.Drawing.Size(170, 50);
            this.btnKhachHang.TabIndex = 5;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.picLogo);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(170, 100);
            this.PanelLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::restaurant_management.Properties.Resources.logo200;
            this.picLogo.Location = new System.Drawing.Point(30, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(105, 97);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelTitlebar.Controls.Add(this.lbDateTime);
            this.panelTitlebar.Controls.Add(this.LabelUser);
            this.panelTitlebar.Controls.Add(this.iconMinimize);
            this.panelTitlebar.Controls.Add(this.iconZoom);
            this.panelTitlebar.Controls.Add(this.iconExit);
            this.panelTitlebar.Controls.Add(this.labelcon);
            this.panelTitlebar.Controls.Add(this.iconmenusmall);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(170, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(930, 70);
            this.panelTitlebar.TabIndex = 1;
            this.panelTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlebar_MouseDown);
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbDateTime.Location = new System.Drawing.Point(366, 31);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(71, 20);
            this.lbDateTime.TabIndex = 6;
            this.lbDateTime.Text = "12:30:00";
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelUser.Location = new System.Drawing.Point(184, 31);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(54, 16);
            this.LabelUser.TabIndex = 5;
            this.LabelUser.Text = "Nhóm 8";
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMinimize.IconSize = 25;
            this.iconMinimize.Location = new System.Drawing.Point(835, 7);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Rotation = 0D;
            this.iconMinimize.Size = new System.Drawing.Size(30, 30);
            this.iconMinimize.TabIndex = 4;
            this.iconMinimize.UseVisualStyleBackColor = true;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // iconZoom
            // 
            this.iconZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconZoom.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconZoom.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.iconZoom.IconColor = System.Drawing.Color.Gainsboro;
            this.iconZoom.IconSize = 25;
            this.iconZoom.Location = new System.Drawing.Point(865, 7);
            this.iconZoom.Name = "iconZoom";
            this.iconZoom.Rotation = 0D;
            this.iconZoom.Size = new System.Drawing.Size(30, 30);
            this.iconZoom.TabIndex = 3;
            this.iconZoom.UseVisualStyleBackColor = true;
            this.iconZoom.Click += new System.EventHandler(this.iconZoom_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconExit.IconColor = System.Drawing.Color.Gainsboro;
            this.iconExit.IconSize = 25;
            this.iconExit.Location = new System.Drawing.Point(895, 7);
            this.iconExit.Name = "iconExit";
            this.iconExit.Rotation = 0D;
            this.iconExit.Size = new System.Drawing.Size(30, 30);
            this.iconExit.TabIndex = 2;
            this.iconExit.UseVisualStyleBackColor = true;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // labelcon
            // 
            this.labelcon.AutoSize = true;
            this.labelcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelcon.Location = new System.Drawing.Point(64, 31);
            this.labelcon.Name = "labelcon";
            this.labelcon.Size = new System.Drawing.Size(45, 16);
            this.labelcon.TabIndex = 1;
            this.labelcon.Text = "Home";
            // 
            // iconmenusmall
            // 
            this.iconmenusmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconmenusmall.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconmenusmall.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconmenusmall.IconColor = System.Drawing.Color.Gainsboro;
            this.iconmenusmall.Location = new System.Drawing.Point(19, 23);
            this.iconmenusmall.Name = "iconmenusmall";
            this.iconmenusmall.Size = new System.Drawing.Size(32, 32);
            this.iconmenusmall.TabIndex = 0;
            this.iconmenusmall.TabStop = false;
            // 
            // panelshadow
            // 
            this.panelshadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelshadow.Location = new System.Drawing.Point(173, 64);
            this.panelshadow.Name = "panelshadow";
            this.panelshadow.Size = new System.Drawing.Size(628, 9);
            this.panelshadow.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // paneltrangcon
            // 
            this.paneltrangcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.paneltrangcon.BackgroundImage = global::restaurant_management.Properties.Resources._12508948_1670998316473982_4851468845388207905_n;
            this.paneltrangcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paneltrangcon.Location = new System.Drawing.Point(170, 67);
            this.paneltrangcon.Name = "paneltrangcon";
            this.paneltrangcon.Size = new System.Drawing.Size(930, 533);
            this.paneltrangcon.TabIndex = 3;
            this.paneltrangcon.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltrangcon_Paint);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.paneltrangcon);
            this.Controls.Add(this.panelshadow);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainControl";
            this.Load += new System.EventHandler(this.MainControl_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelDropDownSP.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconmenusmall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelLogo;
        private FontAwesome.Sharp.IconButton btnKhachHang;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnBan;
        private FontAwesome.Sharp.IconButton btnVoucher;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelTitlebar;
        private FontAwesome.Sharp.IconPictureBox iconmenusmall;
        private System.Windows.Forms.Label labelcon;
        private System.Windows.Forms.Panel panelshadow;
        private System.Windows.Forms.Panel paneltrangcon;
        private FontAwesome.Sharp.IconButton iconExit;
        private FontAwesome.Sharp.IconButton iconZoom;
        private FontAwesome.Sharp.IconButton iconMinimize;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Panel PanelDropDownSP;
        private FontAwesome.Sharp.IconButton iconButtonKho;
        private FontAwesome.Sharp.IconButton iconButtonNhapKho;
        private FontAwesome.Sharp.IconButton iconButtonTonKho;
        private FontAwesome.Sharp.IconButton btnSetting;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnNhanVien;
    }
}