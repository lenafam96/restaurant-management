
namespace restaurant_management.View
{
    partial class frmMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonAn));
            this.flpMonAn = new System.Windows.Forms.FlowLayoutPanel();
            this.grbBo = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.nbuSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            this.flpMonAn.SuspendLayout();
            this.grbBo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbuSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // flpMonAn
            // 
            this.flpMonAn.AutoScroll = true;
            this.flpMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMonAn.Controls.Add(this.grbBo);
            this.flpMonAn.Location = new System.Drawing.Point(12, 12);
            this.flpMonAn.Name = "flpMonAn";
            this.flpMonAn.Padding = new System.Windows.Forms.Padding(7);
            this.flpMonAn.Size = new System.Drawing.Size(557, 397);
            this.flpMonAn.TabIndex = 1;
            // 
            // grbBo
            // 
            this.grbBo.Controls.Add(this.button2);
            this.grbBo.Location = new System.Drawing.Point(10, 10);
            this.grbBo.Name = "grbBo";
            this.grbBo.Size = new System.Drawing.Size(537, 100);
            this.grbBo.TabIndex = 0;
            this.grbBo.TabStop = false;
            this.grbBo.Text = "Bò";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(413, 417);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // nbuSoLuong
            // 
            this.nbuSoLuong.Location = new System.Drawing.Point(328, 420);
            this.nbuSoLuong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nbuSoLuong.Name = "nbuSoLuong";
            this.nbuSoLuong.Size = new System.Drawing.Size(79, 20);
            this.nbuSoLuong.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(494, 417);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Huỷ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMonAn
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.nbuSoLuong);
            this.Controls.Add(this.flpMonAn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMonAn";
            this.Load += new System.EventHandler(this.frmMonAn_Load);
            this.flpMonAn.ResumeLayout(false);
            this.grbBo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbuSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMonAn;
        private System.Windows.Forms.GroupBox grbBo;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown nbuSoLuong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExit;
    }
}