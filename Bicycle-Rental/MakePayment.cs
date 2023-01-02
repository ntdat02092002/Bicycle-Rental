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
    public partial class MakePayment : Form
    {
        Main main;
        public MakePayment(Main main)
        {
            InitializeComponent();
            this.main = main;
        }
    }
}
