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
    public partial class Register : Form
    {
        Main main;
        public Register(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TermsAndConditions terms = new TermsAndConditions();
            terms.Location = this.Location;

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (terms.ShowDialog(this) == DialogResult.OK)
            {
                
            }
            else
            {
            }
            terms.Dispose();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbox.Checked == true)
            {
                this.SignUp_button.Enabled = true;
            }
            else
            {
                this.SignUp_button.Enabled = false;
            }
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            string user_name = txt_username.Text;
            string pass = txt_password.Text;
            string name = txt_name.Text;
            string re_pass = txt_re_password.Text;
            DataRow[] dr = Database.User.Select("tendangnhap = '" + user_name + "'");
            if (dr.Length != 0)
            {
                MessageBox.Show("This User Name already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_username.Focus();
                return;
            }

            if (pass != re_pass)
            {
                MessageBox.Show("Password confirm miss match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_re_password.Text = "";
                this.txt_re_password.Focus();
                return;
            }

            Database.User.Rows.Add(user_name, pass, name, "", "Nam", "", "", "", "", "", "0", "0");
            this.main.is_login = true;
            this.main.set_name_in_login_btn(name);
            this.main.is_admin = false;
            this.main.user_name = user_name;
            Database.CurentUser = user_name;

            Home sub_form = new Home();
            this.main.Open_Sub_Form(sub_form);
        }
    }
}
