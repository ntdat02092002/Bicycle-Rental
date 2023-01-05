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
    public partial class Mail : Form
    {
        ChromiumWebBrowser browser = null;
        public Mail(ChromiumWebBrowser browser)
        {
            InitializeComponent();

            this.browser = browser;

            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

            /*browser.Load(@"https://accounts.google.com/");*/
        }
    }
}
