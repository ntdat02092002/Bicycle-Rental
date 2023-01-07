namespace Bicycle_Rental
{
    partial class Agency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agency));
            this.panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.list_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.search_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.cb_tinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.map_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.panel.SuspendLayout();
            this.search_panel.SuspendLayout();
            this.map_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.list_panel);
            this.panel.Controls.Add(this.search_panel);
            this.panel.FillColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.ShadowColor = System.Drawing.Color.Black;
            this.panel.ShadowShift = 3;
            this.panel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.G360400081A33240D0117.G3619131E1A3107060016;
            this.panel.Size = new System.Drawing.Size(280, 488);
            this.panel.TabIndex = 0;
            // 
            // list_panel
            // 
            this.list_panel.AutoScroll = true;
            this.list_panel.Location = new System.Drawing.Point(4, 106);
            this.list_panel.Name = "list_panel";
            this.list_panel.Size = new System.Drawing.Size(273, 379);
            this.list_panel.TabIndex = 1;
            // 
            // search_panel
            // 
            this.search_panel.Controls.Add(this.txt_search);
            this.search_panel.Controls.Add(this.cb_tinh);
            this.search_panel.Location = new System.Drawing.Point(3, 3);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(274, 99);
            this.search_panel.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_search.IconLeft")));
            this.txt_search.Location = new System.Drawing.Point(14, 60);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Search";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(247, 36);
            this.txt_search.TabIndex = 1;
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // cb_tinh
            // 
            this.cb_tinh.BackColor = System.Drawing.Color.Transparent;
            this.cb_tinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_tinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_tinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_tinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_tinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_tinh.ItemHeight = 30;
            this.cb_tinh.Items.AddRange(new object[] {
            "Chọn tỉnh/thành phố",
            "Hà Nội",
            "Đà Nẵng",
            "Huế",
            "Hồ Chí Minh"});
            this.cb_tinh.Location = new System.Drawing.Point(14, 12);
            this.cb_tinh.MaxDropDownItems = 10;
            this.cb_tinh.Name = "cb_tinh";
            this.cb_tinh.Size = new System.Drawing.Size(247, 36);
            this.cb_tinh.TabIndex = 0;
            this.cb_tinh.SelectedIndexChanged += new System.EventHandler(this.cb_tinh_SelectedIndexChanged);
            // 
            // map_panel
            // 
            this.map_panel.BackColor = System.Drawing.Color.Transparent;
            this.map_panel.Controls.Add(this.gmap);
            this.map_panel.FillColor = System.Drawing.Color.White;
            this.map_panel.Location = new System.Drawing.Point(308, 12);
            this.map_panel.Name = "map_panel";
            this.map_panel.ShadowColor = System.Drawing.Color.Black;
            this.map_panel.ShadowShift = 3;
            this.map_panel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.G360400081A33240D0117.G3619131E1A3107060016;
            this.map_panel.Size = new System.Drawing.Size(872, 488);
            this.map_panel.TabIndex = 1;
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(0, 0);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(872, 488);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 5D;
            this.gmap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gmap_OnMarkerClick);
            // 
            // Agency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 512);
            this.Controls.Add(this.map_panel);
            this.Controls.Add(this.panel);
            this.Name = "Agency";
            this.Text = "Agency";
            this.panel.ResumeLayout(false);
            this.search_panel.ResumeLayout(false);
            this.map_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel panel;
        private Guna.UI2.WinForms.Guna2ShadowPanel map_panel;
        private Guna.UI2.WinForms.Guna2Panel search_panel;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2ComboBox cb_tinh;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.FlowLayoutPanel list_panel;
    }
}