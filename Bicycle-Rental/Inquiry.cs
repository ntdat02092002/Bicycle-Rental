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
    public partial class Inquiry : Form
    {
        public Inquiry(string url)
        {
            InitializeComponent();
            InitBrowser(url);
        }

        public ChromiumWebBrowser browser;
        public void InitBrowser(string url)
        {
            if (!Cef.IsInitialized) // Check before init
            {
                CefSettings settings = new CefSettings();
                Cef.Initialize(settings);
            }

            browser = new ChromiumWebBrowser(url);
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
    }
}
