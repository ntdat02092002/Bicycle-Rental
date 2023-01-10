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
    public partial class TourMap : Form
    {
        string route;
        public TourMap(string route)
        {
            InitializeComponent();
            this.route = route;
            InitBrowser(route);
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
