using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace Bicycle_Rental
{
    public partial class Agency : Form
    {
        Main main;
        string province = "";
        string search = "";
        public Agency(Main main)
        {
            InitializeComponent();
            this.main = main;

            // this set default value for combo box will invoke Display_Item()
            this.cb_tinh.SelectedIndex = 0;

            InitMap();
            Init_Marker();
        }
        void InitMap()
        {
            gmap.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            gmap.Position = new PointLatLng(14.711893, 108.939234);
            gmap.ShowCenter = false;
        }

        void Init_Marker()
        {
            GMapOverlay markers = new GMapOverlay("markers");

            Bitmap icon_marker = new Bitmap(Database.asset_path + @"marker.png");

            DataRow[] dr = Database.Agency.Select();

            foreach (DataRow drr in dr)
            {
                GMapMarker marker = new GMarkerGoogle(
                    new PointLatLng(double.Parse(drr[5].ToString()), double.Parse(drr[6].ToString())),
                    icon_marker);

                marker.ToolTipText = "\n" + drr[1].ToString();
                marker.ToolTip.Fill = Brushes.Gray;
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.Stroke = Pens.Black;
               /* marker.ToolTip.TextPadding = new Size(20, 20);*/

                markers.Markers.Add(marker);
            }
            
            gmap.Overlays.Add(markers);

            GMaps.Instance.OptimizeMapDb(null);

            gmap.Refresh();
        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            string lat = item.Position.Lat.ToString();
            string lon = item.Position.Lng.ToString();
            System.Diagnostics.Process.Start(String.Format("https://www.google.com/maps/search/?api=1&query={0},{1}", lat, lon));
        }

        public void item_handler_click(object sender, EventArgs e)
        {
            AgencyItem item = sender as AgencyItem;
            double lat = double.Parse(item.lat.Text);
            double lon = double.Parse(item.lon.Text);

            gmap.Position = new PointLatLng(lat, lon);
            gmap.Zoom = 16;
        }

        private void cb_tinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            province = cb_tinh.Text.ToString();
            if (province == "Chọn tỉnh/thành phố")
                province = "";
            txt_search.Text = "";
            search = "";

            Display_Item(String.Format("tinh like '%{0}%' and diachi like '%{1}%'", province, search));
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search = txt_search.Text;
                Display_Item(String.Format("tinh like '%{0}%' and diachi like '%{1}%'", province, search));
            }
        }

        void Display_Item(string query)
        {
            list_panel.Controls.Clear();

            DataRow[] dr = Database.Agency.Select(query);

            foreach (DataRow drr in dr)
            {
                AgencyItem item = new AgencyItem();
                item.name.Text = drr[1].ToString();
                item.address.Text = drr[2].ToString();
                item.phone.Text = drr[4].ToString();
                item.province.Text = drr[3].ToString();
                item.lat.Text = drr[5].ToString();
                item.lon.Text = drr[6].ToString();

                item.Click += new EventHandler(this.item_handler_click);

                list_panel.Controls.Add(item);
            }
        }
    }
}
