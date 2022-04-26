
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
            this.flpMonAn = new System.Windows.Forms.FlowLayoutPanel();
            this.grbBo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.flpMonAn.SuspendLayout();
            this.grbBo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(409, 417);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown1.TabIndex = 2;
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
            // frmMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.flpMonAn);
            this.Controls.Add(this.button1);
            this.Name = "frmMonAn";
            this.Text = "frmMonAn";
            this.Load += new System.EventHandler(this.frmMonAn_Load);
            this.flpMonAn.ResumeLayout(false);
            this.grbBo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMonAn;
        private System.Windows.Forms.GroupBox grbBo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
    }
}