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
    public partial class MakePayment : Form
    {
        Main main;
        public MakePayment(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string url = @"https://docs.google.com/forms/d/e/1FAIpQLSegIolcUf7AeE__2JNBOy-dCQcqNsj1rK-1SWubqlRrNNhutw/viewform";
            Inquiry sub_form = new Inquiry(url);
            main.Open_Sub_Form(sub_form);
        }
    }
}
