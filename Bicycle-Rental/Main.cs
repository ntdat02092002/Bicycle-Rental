using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GunaControl = Guna.UI2.WinForms;

namespace Bicycle_Rental
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private bool MouseIsOverControl(Control control) =>
           control.ClientRectangle.Contains(control.PointToClient(Cursor.Position));

        private void Bike_button_MouseHover(object sender, EventArgs e)
        {
            panel_bike.BringToFront();
            panel_bike.Visible = true;
        }

        private void Bike_button_MouseLeave(object sender, EventArgs e)
        {
            if (!MouseIsOverControl(panel_bike) && !MouseIsOverControl(Bike_button))
            {
                panel_bike.Visible = false;
            }

        }
        private void panel_bike_MouseLeave(object sender, EventArgs e)
        {
            if (!MouseIsOverControl(panel_bike) && !MouseIsOverControl(Bike_button))
            {
                panel_bike.Visible = false;
            }
        }

        private void bike_for_tour_btn_MouseHover(object sender, EventArgs e)
        {
            Bicycle_tour_panel.BringToFront();
            Bicycle_tour_panel.Visible = true;

        }

        private void bike_for_tour_btn_MouseLeave(object sender, EventArgs e)
        {
            if (!MouseIsOverControl(Bicycle_tour_panel) && !MouseIsOverControl(bike_for_tour_btn))
            {
                Bicycle_tour_panel.Visible = false;
            }
        }

        private void Bicycle_tour_panel_MouseLeave(object sender, EventArgs e)
        {
            if (!MouseIsOverControl(Bicycle_tour_panel) && !MouseIsOverControl(bike_for_tour_btn))
            {
                panel_bike.Visible = false;
                Bicycle_tour_panel.Visible = false;
            }
        }
    }
}
