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
    public partial class Login : Form
    {
        Main main;
        public Login(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void signup_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register sub_form = new Register(this.main);
            this.main.Open_Sub_Form(sub_form);
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string user_name = txt_username.Text;
            string pass = txt_password.Text;
            DataRow[] dr = Database.User.Select("tendangnhap = '" + user_name + "' and matkhau = '" + pass + "'");
            if (dr.Length != 0)
            {
                this.main.is_login = true;
                this.main.set_name_in_login_btn(dr[0][2].ToString());
                this.main.is_admin = (dr[0][10].ToString() == "1");
                this.main.user_name = user_name;

                Home sub_form = new Home();
                this.main.Open_Sub_Form(sub_form);
            }
            else
            {
                this.txt_password.Text = "";
                MessageBox.Show("User Name or Password incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_button.PerformClick();
            }
        }
    }
}
