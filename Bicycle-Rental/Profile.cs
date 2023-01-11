using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycle_Rental
{
    public partial class Profile : Form
    {
        Main main;
        bool is_edit = false;
        DataRow dr;
        public Profile(Main main)
        {
            InitializeComponent();

            this.main = main;
            dr = Database.User.Select("tendangnhap = '" + main.user_name + "' ")[0];

            Load_Data();
        }

        void Load_Data()
        {
            txt_username.Text = dr[0].ToString();
            txt_name.Text = dr[2].ToString();
            txt_mail.Text = dr[8].ToString();
            txt_phone.Text = dr[9].ToString();
            cb_gender.Text = dr[4].ToString();
            cb_day.Text = dr[5].ToString();
            cb_month.Text = dr[6].ToString();
            cb_year.Text = dr[7].ToString();

            if (dr[3].ToString() != "")
            {
                pic_avt.Image = Image.FromFile(dr[3].ToString());
            }

        }

        private void select_avt_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File|*.jpg;*.png";
            openFileDialog.Title = "Select image";

            string avatar_path = Database.asset_path + @"avatar\custom";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dr[3] = openFileDialog.FileName.ToString();
                dr.AcceptChanges();
                pic_avt.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (is_edit)
            {
                is_edit = false;

                txt_name.Enabled = false;
                txt_phone.Enabled = false;
                cb_day.Enabled = false;
                cb_gender.Enabled = false;
                cb_month.Enabled = false;
                cb_year.Enabled = false;
                btn_edit.Text = "Edit";

                dr[2] = txt_name.Text;
                dr[8] = txt_mail.Text;
                dr[9] = txt_phone.Text;
                dr[4] = cb_gender.Text;
                dr[5] = cb_day.Text;
                dr[6] = cb_month.Text;
                dr[7] = cb_year.Text;

                dr.AcceptChanges();
            }
            else
            {
                is_edit = true;

                txt_name.Enabled = true;
                txt_phone.Enabled = true;
                cb_day.Enabled = true;
                cb_gender.Enabled = true;
                cb_month.Enabled = true;
                cb_year.Enabled = true;

                btn_edit.Text = "Save";
            }
        }
    }
}
