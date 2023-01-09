
namespace Bicycle_Rental
{
    partial class Bicycle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Add_to_cart_button = new Guna.UI2.WinForms.Guna2Button();
            this.TenXe = new System.Windows.Forms.Label();
            this.GiaThue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Add_to_cart_button
            // 
            this.Add_to_cart_button.BackColor = System.Drawing.Color.Transparent;
            this.Add_to_cart_button.BorderColor = System.Drawing.Color.Transparent;
            this.Add_to_cart_button.BorderThickness = 2;
            this.Add_to_cart_button.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.Add_to_cart_button.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Add_to_cart_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Add_to_cart_button.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_to_cart_button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Add_to_cart_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_to_cart_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add_to_cart_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add_to_cart_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_to_cart_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add_to_cart_button.FillColor = System.Drawing.Color.LightPink;
            this.Add_to_cart_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_to_cart_button.ForeColor = System.Drawing.Color.White;
            this.Add_to_cart_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Add_to_cart_button.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Add_to_cart_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Add_to_cart_button.ImageSize = new System.Drawing.Size(30, 30);
            this.Add_to_cart_button.Location = new System.Drawing.Point(58, 270);
            this.Add_to_cart_button.Name = "Add_to_cart_button";
            this.Add_to_cart_button.Size = new System.Drawing.Size(132, 38);
            this.Add_to_cart_button.TabIndex = 8;
            this.Add_to_cart_button.Text = "Add To Cart";
            this.Add_to_cart_button.Click += new System.EventHandler(this.Add_to_cart_button_Click);
            // 
            // TenXe
            // 
            this.TenXe.AutoSize = true;
            this.TenXe.BackColor = System.Drawing.Color.Transparent;
            this.TenXe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenXe.ForeColor = System.Drawing.Color.White;
            this.TenXe.Location = new System.Drawing.Point(55, 222);
            this.TenXe.Name = "TenXe";
            this.TenXe.Size = new System.Drawing.Size(29, 17);
            this.TenXe.TabIndex = 9;
            this.TenXe.Text = "Tên";
            // 
            // GiaThue
            // 
            this.GiaThue.AutoSize = true;
            this.GiaThue.BackColor = System.Drawing.Color.Transparent;
            this.GiaThue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaThue.ForeColor = System.Drawing.Color.White;
            this.GiaThue.Location = new System.Drawing.Point(3, 216);
            this.GiaThue.Name = "GiaThue";
            this.GiaThue.Size = new System.Drawing.Size(40, 25);
            this.GiaThue.TabIndex = 9;
            this.GiaThue.Text = "Giá";
            // 
            // Bicycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.GiaThue);
            this.Controls.Add(this.TenXe);
            this.Controls.Add(this.Add_to_cart_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Bicycle";
            this.Size = new System.Drawing.Size(260, 311);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button Add_to_cart_button;
        private System.Windows.Forms.Label TenXe;
        private System.Windows.Forms.Label GiaThue;
    }
}
