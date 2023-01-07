using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycle_Rental
{
    public partial class AgencyItem : UserControl
    {
        public AgencyItem()
        {
            InitializeComponent();
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += Control_Click;
                    control.Cursor = Cursors.Hand;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= Control_Click;
                }
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
