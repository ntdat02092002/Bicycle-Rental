
namespace Bicycle_Rental
{
    partial class Bicycle_For_rent
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Deliver_radio = new RadioButtonList();
            this.Speed_radio = new RadioButtonList();
            this.Size_radio = new RadioButtonList();
            this.Bike_radio = new RadioButtonList();
            this.Color_radio = new RadioButtonList();
            this.Price_button = new Guna.UI2.WinForms.Guna2Button();
            this.Speed_button = new Guna.UI2.WinForms.Guna2Button();
            this.Deliver_button = new Guna.UI2.WinForms.Guna2Button();
            this.Size_button = new Guna.UI2.WinForms.Guna2Button();
            this.Color_button = new Guna.UI2.WinForms.Guna2Button();
            this.Bike_button = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Deliver_radio);
            this.panel1.Controls.Add(this.Speed_radio);
            this.panel1.Controls.Add(this.Size_radio);
            this.panel1.Controls.Add(this.Bike_radio);
            this.panel1.Controls.Add(this.Color_radio);
            this.panel1.Controls.Add(this.Price_button);
            this.panel1.Controls.Add(this.Speed_button);
            this.panel1.Controls.Add(this.Deliver_button);
            this.panel1.Controls.Add(this.Size_button);
            this.panel1.Controls.Add(this.Color_button);
            this.panel1.Controls.Add(this.Bike_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 210);
            this.panel1.TabIndex = 7;
            // 
            // Deliver_radio
            // 
            this.Deliver_radio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Deliver_radio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deliver_radio.FormattingEnabled = true;
            this.Deliver_radio.Items.AddRange(new object[] {
            "None",
            "Hà Nội",
            "Hồ Chí Minh",
            "Đà Nẵng"});
            this.Deliver_radio.Location = new System.Drawing.Point(301, 85);
            this.Deliver_radio.Name = "Deliver_radio";
            this.Deliver_radio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Deliver_radio.Size = new System.Drawing.Size(213, 82);
            this.Deliver_radio.TabIndex = 13;
            this.Deliver_radio.Visible = false;
            // 
            // Speed_radio
            // 
            this.Speed_radio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Speed_radio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed_radio.FormattingEnabled = true;
            this.Speed_radio.Items.AddRange(new object[] {
            "None",
            "24 Speed Bike",
            "27 Speed Bike"});
            this.Speed_radio.Location = new System.Drawing.Point(586, 39);
            this.Speed_radio.Name = "Speed_radio";
            this.Speed_radio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Speed_radio.Size = new System.Drawing.Size(213, 62);
            this.Speed_radio.TabIndex = 14;
            this.Speed_radio.Visible = false;
            // 
            // Size_radio
            // 
            this.Size_radio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Size_radio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size_radio.FormattingEnabled = true;
            this.Size_radio.Items.AddRange(new object[] {
            "None",
            "Kids",
            "L",
            "M",
            "S",
            "XL"});
            this.Size_radio.Location = new System.Drawing.Point(301, 39);
            this.Size_radio.Name = "Size_radio";
            this.Size_radio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size_radio.Size = new System.Drawing.Size(213, 122);
            this.Size_radio.TabIndex = 15;
            this.Size_radio.Visible = false;
            // 
            // Bike_radio
            // 
            this.Bike_radio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bike_radio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bike_radio.FormattingEnabled = true;
            this.Bike_radio.Items.AddRange(new object[] {
            "None",
            "Hybrid Bike",
            "Mountain Bike",
            "Road Bike",
            "Single-Speed Bike"});
            this.Bike_radio.Location = new System.Drawing.Point(2, 39);
            this.Bike_radio.Name = "Bike_radio";
            this.Bike_radio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bike_radio.Size = new System.Drawing.Size(213, 102);
            this.Bike_radio.TabIndex = 16;
            this.Bike_radio.Visible = false;
            // 
            // Color_radio
            // 
            this.Color_radio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Color_radio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color_radio.FormattingEnabled = true;
            this.Color_radio.Items.AddRange(new object[] {
            "None",
            "Azure",
            "Green",
            "Orange",
            "Pink",
            "Red"});
            this.Color_radio.Location = new System.Drawing.Point(2, 85);
            this.Color_radio.Name = "Color_radio";
            this.Color_radio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Color_radio.Size = new System.Drawing.Size(213, 122);
            this.Color_radio.TabIndex = 12;
            this.Color_radio.Visible = false;
            // 
            // Price_button
            // 
            this.Price_button.BackColor = System.Drawing.Color.Transparent;
            this.Price_button.BorderThickness = 2;
            this.Price_button.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.Price_button.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Price_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Price_button.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Price_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Price_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Price_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Price_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Price_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Price_button.FillColor = System.Drawing.Color.Transparent;
            this.Price_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_button.ForeColor = System.Drawing.Color.Black;
            this.Price_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Price_button.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Price_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Price_button.ImageSize = new System.Drawing.Size(30, 30);
            this.Price_button.Location = new System.Drawing.Point(586, 48);
            this.Price_button.Name = "Price_button";
            this.Price_button.Size = new System.Drawing.Size(213, 38);
            this.Price_button.TabIndex = 6;
            this.Price_button.Text = "Price";
            // 
            // Speed_button
            // 
            this.Speed_button.BackColor = System.Drawing.Color.Transparent;
            this.Speed_button.BorderThickness = 2;
            this.Speed_button.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.Speed_button.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Speed_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Speed_button.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed_button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Speed_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Speed_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Speed_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Speed_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Speed_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Speed_button.FillColor = System.Drawing.Color.Transparent;
            this.Speed_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed_button.ForeColor = System.Drawing.Color.Black;
            this.Speed_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Speed_button.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Speed_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Speed_button.ImageSize = new System.Drawing.Size(30, 30);
            this.Speed_button.Location = new System.Drawing.Point(586, 4);
            this.Speed_button.Name = "Speed_button";
            this.Speed_button.Size = new System.Drawing.Size(213, 38);
            this.Speed_button.TabIndex = 7;
            this.Speed_button.Text = "Speed";
            this.Speed_button.Click += new System.EventHandler(this.Speed_button_Click);
            // 
            // Deliver_button
            // 
            this.Deliver_button.BackColor = System.Drawing.Color.Transparent;
            this.Deliver_button.BorderThickness = 2;
            this.Deliver_button.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.Deliver_button.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Deliver_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Deliver_button.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deliver_button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Deliver_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deliver_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Deliver_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Deliver_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Deliver_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Deliver_button.FillColor = System.Drawing.Color.Transparent;
            this.Deliver_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deliver_button.ForeColor = System.Drawing.Color.Black;
            this.Deliver_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Deliver_button.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Deliver_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Deliver_button.ImageSize = new System.Drawing.Size(30, 30);
            this.Deliver_button.Location = new System.Drawing.Point(301, 48);
            this.Deliver_button.Name = "Deliver_button";
            this.Deliver_button.Size = new System.Drawing.Size(213, 38);
            this.Deliver_button.TabIndex = 8;
            this.Deliver_button.Text = "Deliver";
            this.Deliver_button.Click += new System.EventHandler(this.Deliver_button_Click);
            // 
            // Size_button
            // 
            this.Size_button.BackColor = System.Drawing.Color.Transparent;
            this.Size_button.BorderThickness = 2;
            this.Size_button.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.Size_button.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Size_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Size_button.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size_button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Size_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Size_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Size_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Size_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Size_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Size_button.FillColor = System.Drawing.Color.Transparent;
            this.Size_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size_button.ForeColor = System.Drawing.Color.Black;
            this.Size_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Size_button.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Size_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Size_button.ImageSize = new System.Drawing.Size(30, 30);
            this.Size_button.Location = new System.Drawing.Point(301, 4);
            this.Size_button.Name = "Size_button";
            this.Size_button.Size = new System.Drawing.Size(213, 38);
            this.Size_button.TabIndex = 9;
            this.Size_button.Text = "Size";
            this.Size_button.Click += new System.EventHandler(this.Size_button_Click);
            // 
            // Color_button
            // 
            this.Color_button.BackColor = System.Drawing.Color.Transparent;
            this.Color_button.BorderThickness = 2;
            this.Color_button.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.Color_button.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Color_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Color_button.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color_button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Color_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Color_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Color_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Color_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Color_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Color_button.FillColor = System.Drawing.Color.Transparent;
            this.Color_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color_button.ForeColor = System.Drawing.Color.Black;
            this.Color_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Color_button.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Color_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Color_button.ImageSize = new System.Drawing.Size(30, 30);
            this.Color_button.Location = new System.Drawing.Point(2, 48);
            this.Color_button.Name = "Color_button";
            this.Color_button.Size = new System.Drawing.Size(213, 38);
            this.Color_button.TabIndex = 10;
            this.Color_button.Text = "Color";
            this.Color_button.Click += new System.EventHandler(this.Color_button_Click);
            // 
            // Bike_button
            // 
            this.Bike_button.BackColor = System.Drawing.Color.Transparent;
            this.Bike_button.BorderThickness = 2;
            this.Bike_button.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.Bike_button.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Bike_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Bike_button.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bike_button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Bike_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bike_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Bike_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Bike_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Bike_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Bike_button.FillColor = System.Drawing.Color.Transparent;
            this.Bike_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bike_button.ForeColor = System.Drawing.Color.Black;
            this.Bike_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Bike_button.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Bike_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Bike_button.ImageSize = new System.Drawing.Size(30, 30);
            this.Bike_button.Location = new System.Drawing.Point(2, 4);
            this.Bike_button.Name = "Bike_button";
            this.Bike_button.Size = new System.Drawing.Size(213, 38);
            this.Bike_button.TabIndex = 11;
            this.Bike_button.Text = "Bike";
            this.Bike_button.Click += new System.EventHandler(this.Bike_button_Click);
            // 
            // Bicycle_For_rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Bicycle_For_rent";
            this.Text = "Bicycle_For_rent";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private RadioButtonList Deliver_radio;
        private RadioButtonList Speed_radio;
        private RadioButtonList Size_radio;
        private RadioButtonList Bike_radio;
        private RadioButtonList Color_radio;
        private Guna.UI2.WinForms.Guna2Button Price_button;
        private Guna.UI2.WinForms.Guna2Button Speed_button;
        private Guna.UI2.WinForms.Guna2Button Deliver_button;
        private Guna.UI2.WinForms.Guna2Button Size_button;
        private Guna.UI2.WinForms.Guna2Button Color_button;
        private Guna.UI2.WinForms.Guna2Button Bike_button;
    }
}