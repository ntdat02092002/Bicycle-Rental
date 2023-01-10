namespace Bicycle_Rental
{
    partial class RecentRenting
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
            this.name = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.startday = new System.Windows.Forms.Label();
            this.endday = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(8, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(234, 21);
            this.name.TabIndex = 0;
            this.name.Text = "Youth LIV Enchant 24 Disc 2022 ";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(265, 4);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(110, 21);
            this.type.TabIndex = 1;
            this.type.Text = "Mountain Bike";
            // 
            // startday
            // 
            this.startday.AutoSize = true;
            this.startday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startday.Location = new System.Drawing.Point(614, 4);
            this.startday.Name = "startday";
            this.startday.Size = new System.Drawing.Size(85, 21);
            this.startday.TabIndex = 2;
            this.startday.Text = "20/2/2023";
            // 
            // endday
            // 
            this.endday.AutoSize = true;
            this.endday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endday.Location = new System.Drawing.Point(757, 4);
            this.endday.Name = "endday";
            this.endday.Size = new System.Drawing.Size(85, 21);
            this.endday.TabIndex = 3;
            this.endday.Text = "20/2/2023";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1021, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "________";
            // 
            // status
            // 
            this.status.BorderRadius = 5;
            this.status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(436, 5);
            this.status.Name = "status";
            this.status.ProgressColor = System.Drawing.Color.Gold;
            this.status.ProgressColor2 = System.Drawing.Color.Gold;
            this.status.ShowText = true;
            this.status.Size = new System.Drawing.Size(136, 20);
            this.status.TabIndex = 5;
            this.status.Text = "Renting";
            this.status.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            this.status.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.status.Value = 50;
            // 
            // RecentRenting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.status);
            this.Controls.Add(this.endday);
            this.Controls.Add(this.startday);
            this.Controls.Add(this.type);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "RecentRenting";
            this.Size = new System.Drawing.Size(855, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label name;
        public System.Windows.Forms.Label type;
        public System.Windows.Forms.Label startday;
        public System.Windows.Forms.Label endday;
        public Guna.UI2.WinForms.Guna2ProgressBar status;
    }
}
