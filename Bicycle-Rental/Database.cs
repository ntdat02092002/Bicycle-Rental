using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle_Rental
{
    internal class Database
    {
        public static Database Bicycle { get; set; }
        public static Database User { get; set; }

        public static void KhoiTao()
        {
            Bicycle = new Database();
            User = new Database();
        }
    }
}
