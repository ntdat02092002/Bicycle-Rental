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

            Load_Recent_Renting();
        }

        void Load_Recent_Renting()
        {
            for (int i = 0;i<5;i++)
            {
                if (i == 3)
                {
                    RecentRenting item = new RecentRenting();
                    item.status.ProgressColor = Color.LimeGreen;
                    item.status.ProgressColor2 = Color.LimeGreen;
                    item.status.Value = 100;
                    item.status.Text = "Returned";
                    flowLayoutPanel1.Controls.Add(item);
                }
                if (i == 1)
                {
                    RecentRenting item = new RecentRenting();
                    item.status.ProgressColor = Color.Gold;
                    item.status.ProgressColor2 = Color.Gold;
                    item.status.Value = 100;
                    item.status.Text = "Waiting";
                    flowLayoutPanel1.Controls.Add(item);
                }
                else 
                {
                    RecentRenting item = new RecentRenting();
                    flowLayoutPanel1.Controls.Add(item);
                }
                
            }
            
        }
    }
}
