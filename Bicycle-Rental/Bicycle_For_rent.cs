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
    public partial class Bicycle_For_rent : Form
    {
        public Bicycle_For_rent()
        {
            InitializeComponent();
        }

        private void Bike_button_Click(object sender, EventArgs e)
        {
            if (Bike_radio.Visible == false)
            {
                Bike_radio.Visible = true;
                Bike_radio.BringToFront();
            }
            else
                Bike_radio.Visible = false;
        }

        private void Blue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Color_button_Click(object sender, EventArgs e)
        {
            if (Color_radio.Visible == false)
            {
                Color_radio.Visible = true;
                Color_radio.BringToFront();
            }
            else
                Color_radio.Visible = false;
        }

        private void Size_button_Click(object sender, EventArgs e)
        {
            if (Size_radio.Visible == false)
            {
                Size_radio.Visible = true;
                Size_radio.BringToFront();
            }
            else
                Size_radio.Visible = false;
        }

        private void Deliver_button_Click(object sender, EventArgs e)
        {
            if (Deliver_radio.Visible == false)
            {
                Deliver_radio.Visible = true;
                Deliver_radio.BringToFront();
            }
            else
                Deliver_radio.Visible = false;
        }

        private void Speed_button_Click(object sender, EventArgs e)
        {
            if (Speed_radio.Visible == false)
            {
                Speed_radio.BringToFront();
                Speed_radio.Visible = true;
            }
            else
                Speed_radio.Visible = false;
        }

        private void Bicycle_For_rent_Load(object sender, EventArgs e)
        {
            var names = (from DataRow dRow in Database.Bicycle.Rows
                                select dRow["tenxe"]).Distinct();
            string url= System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\asset\Bicycle\";
            foreach (string name in names)
            {
                string pic_path = url + name+".jpg"; 
                foreach (DataRow dataRow in Database.Bicycle.Rows)
                {
                    
                    if(dataRow["tenxe"].ToString() == name)
                    {
                        Bicycle bicycle = new Bicycle();
                        bicycle.GetTenXe = dataRow["tenxe"].ToString();
                        bicycle.GetGia = "$"+dataRow["giathue"].ToString();
                        bicycle.GetPicture = Image.FromFile(pic_path);
                        this.flowLayoutPanel1.Controls.Add(bicycle);
                        break;
                    }
                }
            }
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count % 3 == 0)
                flowLayoutPanel1.SetFlowBreak(e.Control as Control, true);
        }
    }
}
