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
        Form sub_form = null;
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

            if (!MouseIsOverControl(Bicycle_tour_panel) && !MouseIsOverControl(Bike_For_Tour))
            {
                Bicycle_tour_panel.Visible = false;
            }
        }

        private void bike_for_tour_btn_MouseHover(object sender, EventArgs e)
        {
            Bicycle_tour_panel.BringToFront();
            Bicycle_tour_panel.Visible = true;

        }

        private void bike_for_tour_btn_MouseLeave(object sender, EventArgs e)
        {
            if (!MouseIsOverControl(Bicycle_tour_panel) && !MouseIsOverControl(Bike_For_Tour))
            {
                Bicycle_tour_panel.Visible = false;
            }
        }

        private void Bicycle_tour_panel_MouseLeave(object sender, EventArgs e)
        {
            if (!MouseIsOverControl(Bicycle_tour_panel) && !MouseIsOverControl(Bike_For_Tour))
            {
                panel_bike.Visible = false;
                Bicycle_tour_panel.Visible = false;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Open_Sub_Form(home);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bike_for_tour_btn_Click(object sender, EventArgs e)
        {

        }

        private void bike_for_rent_btn_Click(object sender, EventArgs e)
        {

        }

        private void bike_for_sale_btn_Click(object sender, EventArgs e)
        {

        }

        private void bike_equipment_btn_Click(object sender, EventArgs e)
        {

        }

        private void Contact_button_MouseHover(object sender, EventArgs e)
        {
            Contact_panel.BringToFront();
            Contact_panel.Visible = true;

        }

        private void Contact_button_MouseLeave(object sender, EventArgs e)
        {
            if (!MouseIsOverControl(Contact_panel) && !MouseIsOverControl(Contact_button))
            {
                Contact_panel.Visible = false;
            }
        }

        private void Contact_panel_MouseLeave(object sender, EventArgs e)
        {
            if (!MouseIsOverControl(Contact_panel) && !MouseIsOverControl(Contact_button))
            {
                Contact_panel.Visible = false;
            }
        }

        public void Open_Sub_Form(Form sub)
        {
            sub.TopLevel = false;
            sub.Dock = DockStyle.Fill;//Set the subform as a control

            sub.FormBorderStyle = FormBorderStyle.None;
            Sub_Form_panel.Controls.Add(sub);
            sub.Show();

            if (sub_form != null)
                sub_form.Close();

            sub_form = sub;
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Open_Sub_Form(home);
        }

        private void Tour_Inquiry_Click(object sender, EventArgs e)
        {
            TourInquiry sub_form = new TourInquiry();
            this.Open_Sub_Form(sub_form);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_button.PerformClick();
        }
    }
}
