using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace Bicycle_Rental
{
    public partial class Login_Google_Admin : Form
    {
        ChromiumWebBrowser browser = null;
        public Login_Google_Admin(ChromiumWebBrowser browser)
        {
            InitializeComponent();
            this.browser = browser;
            browser.AddressChanged += OnBrowserAddressChanged;

            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

            browser.Load(@"https://accounts.google.com/");
        }

        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs e)
        {
            /*MessageBox.Show(e.Address);*/
            if (e.Address.ToString() == "https://myaccount.google.com/?pli=1" || e.Address.ToString() == "https://myaccount.google.com/")
            {
                this.Invoke((MethodInvoker)delegate
                {
                    // close the form on the forms thread
                    this.Close();
                });
            }
        }
    }
}
