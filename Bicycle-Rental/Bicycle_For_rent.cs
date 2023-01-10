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
                        bicycle.GetDaiLy = Database.Agency.Select("madaily='" + dataRow["madaily"].ToString() + "'")[0]["tendaily"].ToString();
                        bicycle.GetMaxe = dataRow["maxe"].ToString();
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

        private void Filter_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            string loai="none";
            string size = "none";
            string color = "none";
            string daily = "none";
            string speed = "none";
            if (Bike_radio.SelectedItem !=null)
                loai = Bike_radio.SelectedItem.ToString().ToLower();
            if (Size_radio.SelectedItem != null)
                size = Size_radio.SelectedItem.ToString().ToLower();
            if (Color_radio.SelectedItem != null)
                color = Color_radio.SelectedItem.ToString().ToLower();
            if (Deliver_radio.SelectedItem != null&&Deliver_radio.SelectedItem.ToString()!="None")
                daily = Database.Agency.Select("tendaily='"+Deliver_radio.SelectedItem.ToString()+"'")[0]["madaily"].ToString();
            if (Speed_radio.SelectedItem != null)
                speed = Speed_radio.SelectedItem.ToString().ToLower();
            IEnumerable<DataRow> rows = Database.Bicycle.AsEnumerable()
                       .Where(r => (r.Field<string>("loai").ToLower() == loai|| loai=="none")
                                && (r.Field<string>("kichthuoc").ToLower() == size|| size== "none")
                                && (r.Field<string>("mausac").ToLower() == color|| color=="none")
                                && (r.Field<string>("tocdo").ToLower()== speed|| speed =="none")
                                && (r.Field<string>("madaily").ToLower()==daily|| daily=="none"));

            if (loai == "none" && size == "none" && color == "none" && daily == "none" && speed == "none")
            {
                Bicycle_For_rent_Load(sender, e);
                return;
            }
            string url = System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\asset\Bicycle\";
            foreach (DataRow dataRow in rows)
            {
                string pic_path = url + dataRow["tenxe"] +".jpg";
                Bicycle bicycle = new Bicycle();
                bicycle.GetTenXe = dataRow["tenxe"].ToString();
                bicycle.GetGia = "$" + dataRow["giathue"].ToString();
                bicycle.GetPicture = Image.FromFile(pic_path);
                bicycle.GetDaiLy = Database.Agency.Select("madaily='"+dataRow["madaily"].ToString()+"'")[0]["tendaily"].ToString();
                bicycle.GetMaxe = dataRow["maxe"].ToString();
                this.flowLayoutPanel1.Controls.Add(bicycle);
            }

        }
    }
}
