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
    public partial class TourInquiry : Form
    {
        public TourInquiry()
        {
            InitializeComponent();
            InitBrowser();
        }

        public ChromiumWebBrowser browser;
        public void InitBrowser()
        {
            if (!Cef.IsInitialized) // Check before init
            {
                CefSettings settings = new CefSettings();
                Cef.Initialize(settings);
            }

            browser = new ChromiumWebBrowser(@"https://docs.google.com/forms/d/e/1FAIpQLSdISkkN9lU5WOp56QfWevt2DatyXhty4qtOBTtM0-X04gpc1w/viewform");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
    }
}
