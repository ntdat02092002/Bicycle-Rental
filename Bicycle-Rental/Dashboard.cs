using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycle_Rental
{
    public partial class Dashboard : Form
    {
        Main main;
        public Dashboard(Main main)
        {
            InitializeComponent();
            this.main = main;

            Load_Info();
            Load_Recent_Renting();
        }

        void Load_Info()
        {
            DataRow[] drr = Database.History.Select(String.Format("username = '{0}'", main.user_name));
            num_bike_rented.Text = drr.Length.ToString();
            bike_this_month.Text = String.Format("This month - {0}", drr.Length);
            bike_this_year.Text = String.Format("This year - {0}", drr.Length);

            DataRow User = Database.User.Select(String.Format("tendangnhap='{0}'", main.user_name))[0];
            balance.Text = String.Format("{0}$", User["money"]);

        }

        void Load_Recent_Renting()
        {
            DataRow[] drr = Database.History.Select(String.Format("username = '{0}'", main.user_name));
            foreach (DataRow dr in drr)
            {
                RecentRenting item = new RecentRenting();

                DateTime start_date = DateTime.Parse(dr[3].ToString());
                DateTime end_date = DateTime.Parse(dr[4].ToString());
                DateTime cur_date = DateTime.Today;

                if (cur_date < start_date)
                {
                    item.status.ProgressColor = Color.Gold;
                    item.status.ProgressColor2 = Color.Gold;
                    item.status.Value = 100;
                    item.status.Text = "Waiting";
                }
                else if (cur_date < end_date)
                {
                    item.status.ProgressColor = Color.Gold;
                    item.status.ProgressColor2 = Color.Gold;
                    item.status.Value = int.Parse(((end_date.Ticks - cur_date.Ticks)*100/(end_date.Ticks-start_date.Ticks)).ToString());
                    item.status.Text = "Renting";
                }
                else
                {
                    item.status.ProgressColor = Color.LimeGreen;
                    item.status.ProgressColor2 = Color.LimeGreen;
                    item.status.Value = 100;
                    item.status.Text = "Returned";
                }
                item.name.Text = dr[7].ToString();
                item.type.Text = dr[2].ToString();
                item.startday.Text = start_date.ToString("dd/MM/yyyy");
                item.endday.Text = end_date.ToString("dd/MM/yyyy");

                flowLayoutPanel1.Controls.Add(item);
            }
            
        }
    }
}
