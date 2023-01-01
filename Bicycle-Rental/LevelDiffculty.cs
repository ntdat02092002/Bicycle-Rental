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
    public partial class LevelDiffculty : Form
    {
        Main main;
        public LevelDiffculty(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TourInquiry sub_form = new TourInquiry();
            main.Open_Sub_Form(sub_form);
        }

        private void challenge_linklable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void moderate_linklable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void easy_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
