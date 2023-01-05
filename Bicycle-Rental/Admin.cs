﻿using System;
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
    public partial class Admin : Form
    {
        Main main;
        ChromiumWebBrowser browser = null;
        public Admin(Main main)
        {
            InitializeComponent();
            this.main = main;

            Open_Login(this.browser);

        }

        void Open_Login(ChromiumWebBrowser browser)
        {
            if (!Cef.IsInitialized) // Check before init
            {
                CefSettings settings = new CefSettings();
                Cef.Initialize(settings);
            }

            browser = new ChromiumWebBrowser();

            Login_Google_Admin login_form = new Login_Google_Admin(browser);
            login_form.ShowDialog();

        }

        public void InitBrowser(string url)
        {
            if (!Cef.IsInitialized) // Check before init
            {
                CefSettings settings = new CefSettings();
                Cef.Initialize(settings);
            }

            if (browser == null)
            {
                browser = new ChromiumWebBrowser(url);
            }
            else
            {
                browser.SetZoomLevel(-1.8);
                browser.Load(url);
               
            }
            
            show_panel.Controls.Clear();
            show_panel.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        private void tour_inquiry_btn_Click(object sender, EventArgs e)
        {
            InitBrowser(@"https://docs.google.com/forms/d/1rzQM2D7TAw-kU7ZW6Vg1PWziZfuNx8w2nuGReyn92ys/edit#responses");
        }

        private void bike_inquiry_btn_Click(object sender, EventArgs e)
        {
            InitBrowser(@"https://docs.google.com/forms/d/1BDU70SShXz0Mfz1_ec0B7_k4sP351yDy7NG_xx42c3k/edit#responses");
        }

        private void general_inquiry_btn_Click(object sender, EventArgs e)
        {
            InitBrowser(@"https://docs.google.com/forms/d/1FdjWGf3Ad2NC7yg2tOajw-VFgclVWGDXL9yunjOez_U/edit#responses");
        }

        private void tour_btn_Click(object sender, EventArgs e)
        {

        }

        private void user_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
