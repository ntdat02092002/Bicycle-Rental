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
    public partial class Tour : Form
    {
        Main main;
        public Tour(Main main)
        {
            InitializeComponent();
            this.main = main;

            LoadTour();
        }

        void LoadTour()
        {
            DataRow[] user_history = Database.History_tour.Select("username='" + Database.User + "'");
            foreach (DataRow row in Database.Tour.Rows)
            {
                TourItem item = new TourItem(main, row[0].ToString(), row[12].ToString(), main.user_name);
                item.name.Text = row[1].ToString();
                item.destination.Text = String.Format("{0}-{1}", row[2], row[3]);
                item.duration.Text = String.Format("{0} days", row[6]);
                item.distance.Text = row[7].ToString();
                item.day.Text = row[5].ToString();
                item.age.Text = String.Format("{0} age+", row[8]);
                item.number.Text = String.Format("{0}/{1}", row[11], row[10]);
                item.Price.Text = "$" + row[9];
                item.GetJoin_Now_Button().Enabled = true;
                foreach (DataRow dataRow in user_history)
                {
                    if(dataRow["tour_code"].ToString() == row[0].ToString())
                    {
                        item.GetJoin_Now_Button().Enabled=false;
                    }
                }
                if (int.Parse(row[11].ToString()) == int.Parse(row[10].ToString()))
                {
                    item.join_btn.Enabled = false;
                }

                this.flowLayoutPanel1.Controls.Add(item);
            }
        }
    }
    
}
