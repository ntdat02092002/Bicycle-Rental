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
    public partial class DatXe : Form
    {
        Bicycle bicycle1 = new Bicycle();
        int total;
        public DatXe(Bicycle bicycle)
        {

            InitializeComponent();
            bicycle1.GetPicture = bicycle.GetPicture;
            bicycle1.GetGia = bicycle.GetGia;
            bicycle1.GetDaiLy = bicycle.GetDaiLy;
            bicycle1.GetTenXe = bicycle.GetTenXe;
            bicycle1.GetMaxe = bicycle.GetMaxe;
            this.panel1.Controls.Add(bicycle1);
            bicycle1.Dock = DockStyle.Fill;
            bicycle1.Controls.Remove(bicycle1.GetAdd_to_cart_button());
            bicycle1.AutoSize = true;
            this.panel1.AutoSize = true;
            this.AutoSize = true;

            int gia = Convert.ToInt32(Database.Bicycle.Select("maxe='" + bicycle1.GetMaxe.ToString() + "'")[0]["giathue"].ToString());
            this.price.Text = String.Format("{0}$/day", gia);
            this.total_price.Text = "Total: 0$";
        }

        private void NgayDat_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngaylay = this.NgayLay.Value;
            DateTime ngaytra = this.NgayTra.Value;
            int gia = Convert.ToInt32(Database.Bicycle.Select("maxe='" + bicycle1.GetMaxe.ToString() + "'")[0]["giathue"].ToString());
            string Total = (ngaytra - ngaylay).TotalDays.ToString();
            int total_day = Convert.ToInt32((ngaytra - ngaylay).TotalDays);
            total = gia * total_day;
            this.total_price.Text = String.Format("Total: {0}$", total);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Rent_button_Click(object sender, EventArgs e)
        {
            if (Database.CurentUser == "")
                MessageBox.Show("Please Login");
            else
            {
                string username = Database.CurentUser;
                string maxe = this.bicycle1.GetMaxe.ToString();
                string ngaylay = this.NgayLay.Value.ToString();
                string ngaydat = DateTime.Today.ToString();
                string ngaytra = this.NgayTra.Value.ToString();
                DataRow User = Database.User.Select("tendangnhap='" + username + "'")[0];
                int left_money = Convert.ToInt32(User["money"].ToString());
                int gia = total;
                if (left_money >= gia)
                {
                    DataRow data_row = Database.Bicycle.Select(string.Format("maxe = '{0}'", maxe))[0];
                    Database.History.Rows.Add(username, maxe, data_row[2].ToString(), ngaylay, ngaytra, ngaydat,  1, data_row[1].ToString());
                    this.Close();
                    Database.money += gia;
                    MessageBox.Show("Rent A Bike Successfully!");
                    User["money"] = (left_money - gia).ToString();
                }
                else
                    MessageBox.Show("Please Recharge Your Acount");
            }

        }
    }
}
