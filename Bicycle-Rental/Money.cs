using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ZXing;
namespace Bicycle_Rental
{
    public partial class Money : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public Money()
        {
            InitializeComponent();
            DataRow user = Database.User.Select("tendangnhap='" + Database.CurentUser + "'")[0];
            this.Username.Text = Database.CurentUser;
            this.guna2Button1.Text = "Money: $" + user["money"].ToString();
        }

        private void OpenCam_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cboCamera.Items.Add(device.Name);
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            DataRow user = Database.User.Select("tendangnhap='" + Database.CurentUser + "'")[0];
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txtBarcode.Invoke(new MethodInvoker(delegate ()
                {
                    txtBarcode.Text = result.ToString();
                    user["money"] = Convert.ToInt32(user["money"]) + Convert.ToInt32(txtBarcode.Text);
                    this.guna2Button1.Text = "Money: $" + user["money"].ToString();
                    MessageBox.Show("Charge Successfully!");
                }));
            }
            pictureBox1.Image = bitmap;
        }

        private void Money_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Money_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void guna2Button1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
