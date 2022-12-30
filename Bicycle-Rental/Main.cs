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
    }
}
