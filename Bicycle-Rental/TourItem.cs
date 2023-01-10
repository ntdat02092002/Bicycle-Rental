using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CefSharp;
using CefSharp.WinForms;


namespace Bicycle_Rental
{
    public partial class TourItem : UserControl
    {
        string tour_code, route, username;
        Main main;
        public TourItem(Main main, string tour_code, string route, string username)
        {
            InitializeComponent();
            this.tour_code = tour_code;
            this.route = route;
            this.main = main;
            this.username = username;
        }

        private void seemap_btn_Click(object sender, EventArgs e)
        {
            TourMap map = new TourMap(route);
            map.Show();
        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            if (main.is_login == false)
            {
                main.Login.PerformClick();
                return;
            }
            MessageBox.Show(String.Format("username: {0}, tour_code: {1}", username, tour_code));
        }
    }
}
