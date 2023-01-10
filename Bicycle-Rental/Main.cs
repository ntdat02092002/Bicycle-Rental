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
        public bool is_login = false;
        public bool is_admin = false;
        public string user_name;
        public Main()
        {
            InitializeComponent();
            Database.KhoiTao();
            Database.mainform = this;
        }
        private bool MouseIsOverControl(Control control) =>
           control.ClientRectangle.Contains(control.PointToClient(Cursor.Position));

        private void bike_for_tour_btn_MouseHover(object sender, EventArgs e)
        {
            Bicycle_tour_panel.BringToFront();
            Bicycle_tour_panel.Visible = true;

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
            Bicycle_For_rent bicycle_For_Rent = new Bicycle_For_rent();
            Open_Sub_Form(bicycle_For_Rent);
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
            //string url = System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\asset\logo\Background.jpg";
            sub.TopLevel = false;
            sub.Dock = DockStyle.Fill;//Set the subform as a control
            //sub.BackgroundImage = Image.FromFile(url);
            //sub.BackgroundImageLayout = ImageLayout.Stretch;
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
            string url = @"https://docs.google.com/forms/d/e/1FAIpQLSdISkkN9lU5WOp56QfWevt2DatyXhty4qtOBTtM0-X04gpc1w/viewform";
            Inquiry sub_form = new Inquiry(url);
            this.Open_Sub_Form(sub_form);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_button.PerformClick();
        }

        private void Lever_Of_Diffculty_Click(object sender, EventArgs e)
        {
            LevelDiffculty sub_form = new LevelDiffculty(this);
            this.Open_Sub_Form(sub_form);
        }

        private void Make_A_Payment_Click(object sender, EventArgs e)
        {
            MakePayment sub_form = new MakePayment(this);
            this.Open_Sub_Form(sub_form);
        }

        private void How_To_Book_Click(object sender, EventArgs e)
        {
            HowToBook sub_form = new HowToBook(this);
            this.Open_Sub_Form(sub_form);
        }

        private void Join_A_Group_Tour_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/groups/552639710088460");
        }

        private void General_Inquiry_Click(object sender, EventArgs e)
        {
            string url = @"https://docs.google.com/forms/d/e/1FAIpQLSegIolcUf7AeE__2JNBOy-dCQcqNsj1rK-1SWubqlRrNNhutw/viewform";
            Inquiry sub_form = new Inquiry(url);
            this.Open_Sub_Form(sub_form);
        }

        private void Bike_Rental_inquiry_Click(object sender, EventArgs e)
        {
            string url = @"https://docs.google.com/forms/d/e/1FAIpQLSdjcaegNYKGkiXT8MiqGcj084VwlCLJDX-syHzLfbsXY7A3iw/viewform";
            Inquiry sub_form = new Inquiry(url);
            this.Open_Sub_Form(sub_form);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (!is_login)
            {
                Login sub = new Login(this);
                this.Open_Sub_Form(sub);
                return;
            }
            if (is_admin)
            {
                Admin_panel.BringToFront();
                Admin_panel.Visible = true;
            }
            else
            {
                User_panel.BringToFront();
                User_panel.Visible = true;
            }
            
        }

        private void User_panel_MouseLeave(object sender, EventArgs e)
        {
            if (is_admin)
            {
                if (!MouseIsOverControl(Admin_panel) && !MouseIsOverControl(Login))
                {
                    Admin_panel.Visible = false;
                }
            }
            else
            {
                if (!MouseIsOverControl(User_panel) && !MouseIsOverControl(Login))
                {
                    User_panel.Visible = false;
                }
            }
            
        }

        private void Login_MouseLeave(object sender, EventArgs e)
        {
            if (is_login)
            {
                if (is_admin)
                {
                    if (!MouseIsOverControl(Admin_panel) && !MouseIsOverControl(Login))
                    {
                        Admin_panel.Visible = false;
                    }
                }
                else
                {
                    if (!MouseIsOverControl(User_panel) && !MouseIsOverControl(Login))
                    {
                        User_panel.Visible = false;
                    }
                }
            }
        }

        public void set_name_in_login_btn(string name)
        {
            this.Login.Text = name;
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            this.is_admin = false;
            this.is_login = false;
            this.user_name = "";
            this.Login.Text = "Login";
            Admin_panel.Visible = false;
            User_panel.Visible = false;
            this.Home_button.PerformClick();
        }

        private void Profile_Admin_btn_Click(object sender, EventArgs e)
        {
            Profile sub = new Profile(this);
            this.Open_Sub_Form(sub);
        }

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            Admin sub = new Admin(this);
            this.Open_Sub_Form(sub);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Agency sub = new Agency(this);
            this.Open_Sub_Form(sub);
        }

        private void Tour_button_Click(object sender, EventArgs e)
        {
            Tour sub = new Tour(this);
            this.Open_Sub_Form(sub);
        }

        private void Dashboard_admin_btn_Click(object sender, EventArgs e)
        {
            Dashboard sub = new Dashboard(this);
            this.Open_Sub_Form(sub);
        }
    }
}
