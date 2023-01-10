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
    public partial class Bicycle : UserControl
    {
        public Bicycle()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Add_to_cart_button_Click(object sender, EventArgs e)
        {

        }
        public string GetTenXe
        {
            set { this.TenXe.Text = value; }
            get { return this.TenXe.Text;}
        }
        public string GetGia
        {
            set { this.GiaThue.Text = value; }
            get { return this.GiaThue.Text; }
        }
        public Image GetPicture
        {
            set { this.pictureBox1.Image = value; }
            get { return this.pictureBox1.Image; }
        }
    }
}
