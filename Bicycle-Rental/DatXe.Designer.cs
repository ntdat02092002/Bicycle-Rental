
namespace Bicycle_Rental
{
    partial class DatXe
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
            this.NgayLay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.NgayTra = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Rent_button = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.price = new System.Windows.Forms.Label();
            this.total_price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NgayLay
            // 
            this.NgayLay.Checked = true;
            this.NgayLay.FillColor = System.Drawing.Color.White;
            this.NgayLay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NgayLay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.NgayLay.Location = new System.Drawing.Point(370, 2);
            this.NgayLay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.NgayLay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.NgayLay.Name = "NgayLay";
            this.NgayLay.Size = new System.Drawing.Size(180, 36);
            this.NgayLay.TabIndex = 1;
            this.NgayLay.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.NgayLay.Value = new System.DateTime(2023, 1, 10, 21, 15, 2, 938);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(305, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Start Day";
            // 
            // NgayTra
            // 
            this.NgayTra.Checked = true;
            this.NgayTra.FillColor = System.Drawing.Color.White;
            this.NgayTra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.NgayTra.Location = new System.Drawing.Point(370, 47);
            this.NgayTra.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.NgayTra.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Size = new System.Drawing.Size(180, 36);
            this.NgayTra.TabIndex = 1;
            this.NgayTra.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.NgayTra.Value = new System.DateTime(2023, 1, 10, 21, 15, 2, 938);
            this.NgayTra.ValueChanged += new System.EventHandler(this.NgayDat_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(306, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "End Day";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Rent_button
            // 
            this.Rent_button.BackColor = System.Drawing.Color.Transparent;
            this.Rent_button.BorderColor = System.Drawing.Color.Transparent;
            this.Rent_button.BorderThickness = 2;
            this.Rent_button.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.Rent_button.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Rent_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Rent_button.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent_button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Rent_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rent_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Rent_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Rent_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Rent_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Rent_button.FillColor = System.Drawing.Color.LightPink;
            this.Rent_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent_button.ForeColor = System.Drawing.Color.White;
            this.Rent_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Rent_button.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Rent_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Rent_button.ImageSize = new System.Drawing.Size(30, 30);
            this.Rent_button.Location = new System.Drawing.Point(418, 157);
            this.Rent_button.Name = "Rent_button";
            this.Rent_button.Size = new System.Drawing.Size(132, 38);
            this.Rent_button.TabIndex = 11;
            this.Rent_button.Text = "Rent Now";
            this.Rent_button.Click += new System.EventHandler(this.Rent_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 279);
            this.panel1.TabIndex = 12;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Black;
            this.price.Location = new System.Drawing.Point(444, 88);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(83, 25);
            this.price.TabIndex = 13;
            this.price.Text = "End Day";
            // 
            // total_price
            // 
            this.total_price.AutoSize = true;
            this.total_price.BackColor = System.Drawing.Color.Transparent;
            this.total_price.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_price.ForeColor = System.Drawing.Color.Black;
            this.total_price.Location = new System.Drawing.Point(444, 120);
            this.total_price.Name = "total_price";
            this.total_price.Size = new System.Drawing.Size(83, 25);
            this.total_price.TabIndex = 14;
            this.total_price.Text = "End Day";
            // 
            // DatXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 279);
            this.Controls.Add(this.total_price);
            this.Controls.Add(this.price);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Rent_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NgayTra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NgayLay);
            this.Name = "DatXe";
            this.Text = "DatXe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker NgayLay;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker NgayTra;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button Rent_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label total_price;
    }
}