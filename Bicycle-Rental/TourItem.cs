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
        public Guna.UI2.WinForms.Guna2Button GetJoin_Now_Button()
        {
            return this.join_btn;
        }
        private void join_btn_Click(object sender, EventArgs e)
        {
            if (main.is_login == false)
            {
                main.Login.PerformClick();
                return;
            }
            //MessageBox.Show(String.Format("username: {0}, tour_code: {1}", username, tour_code));
            DataRow user = Database.User.Select("tendangnhap='" + username + "'")[0];
            DataRow tour = Database.Tour.Select("tour_code='" + tour_code + "'")[0];
            if(Convert.ToInt32(user["money"])<Convert.ToInt32(tour["price"]))
            {
                MessageBox.Show("Your Acount Is Not Enough. Please Recharge!");
                return;
            }
            if(Convert.ToInt32(user["nam"])<Convert.ToInt32(tour["minimum_age"]))
            {
                MessageBox.Show("You Are Not Old Enough To Join This Tour.");
                return;
            }
            user["money"] = (Convert.ToInt32(user["money"]) - Convert.ToInt32(tour["price"])).ToString();
            tour["curent_menber"] = (Convert.ToInt32(tour["curent_menber"]) + 1).ToString();
            this.number.Text = String.Format("{0}/{1}", tour["curent_menber"], tour["group_size"]);
            string ngay_join = DateTime.Now.ToString();
            Database.History_tour.Rows.Add(username, ngay_join, tour_code);
            this.join_btn.Enabled = false;
            this.join_btn.Text = "Joined";
            MessageBox.Show("Join Tour Successfully!");

        }
    }
}
