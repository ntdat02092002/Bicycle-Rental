using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Bicycle_Rental
{
    public partial class ResestPassword : Form
    {
        string code = "";
        public ResestPassword()
        {
            InitializeComponent();
        }

        private void send_code_btn_Click(object sender, EventArgs e)
        {
            DataRow[] drr = Database.User.Select("tendangnhap = '" + txt_email.Text + "'");
            if (drr.Length == 0)
            {
                MessageBox.Show("Can't find this user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_email.Focus();
                return;
            }
            DataRow dr = drr[0];

            Random generator = new Random();
            code = generator.Next(0, 1000000).ToString("D6");

            String SendMailFrom = "bicycle.rental.cs@gmail.com";
            String SendMailTo = dr[8].ToString().Trim();
            String SendMailSubject = "Your verify code";
            String SendMailBody = String.Format("verify code: <h2>{0}</h2>", code);

            try
            {
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                MailMessage email = new MailMessage();
                // START
                email.From = new MailAddress(SendMailFrom);
                email.To.Add(SendMailTo);
                email.CC.Add(SendMailFrom);
                email.Subject = SendMailSubject;
                email.Body = SendMailBody;
                email.IsBodyHtml = true;
                //END
                SmtpServer.Timeout = 5000;
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new NetworkCredential(SendMailFrom, "lxxzopxjdogmvloc");
                SmtpServer.Send(email);

                MessageBox.Show("Email Successfully Sent");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string pass = txt_pass.Text;
            string re_pass = txt_re_pass.Text;
                
            int verify_code = int.Parse(txt_code.Text);
            int true_code = int.Parse(code);
            if (verify_code != true_code)
            {
                MessageBox.Show("Verify code miss match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_code.Text = "";
                this.txt_re_pass.Focus();
                return;
            }

            if (pass != re_pass)
            {
                MessageBox.Show("Password confirm miss match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_re_pass.Text = "";
                this.txt_re_pass.Focus();
                return;
            }

            DataRow dr = Database.User.Select("tendangnhap = '" + txt_email.Text + "'")[0];
            dr[1] = pass;
            dr.AcceptChanges();
            MessageBox.Show("Change password Successfully");
            this.Close();
        }
    }
}
