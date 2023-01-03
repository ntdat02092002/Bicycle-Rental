using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Bicycle_Rental
{
    internal class Database
    {
        public static string asset_path;
        public static DataTable Bicycle { get; set; }
        public static DataTable User { get; set; }
        public static DataTable Destination { get; set; }

        public static void KhoiTao()
        {
            asset_path = @"..\..\asset\";

            string[] cols_bicycle = { "maxe", "tenxe", "loai", "giathue", "madiadiem", "desciption", "dathue", "mausac", "kichthuoc", "tocdo" };
            Bicycle = ExcelToDataTable(asset_path + "bicycle.xlsx", cols_bicycle);

            string[] cols_user = { "madiadiem", "ten latitude", "longitude" };
            User = ExcelToDataTable(asset_path + "user.xlsx", cols_user);

            string[] cols_destination = { "tendangnhap", "matkhau", "ten avatar", "gioitinh", "ngay", "thang", "nam", "email", "sdt" };
            Destination = ExcelToDataTable(asset_path + "diadiem.xlsx.xlsx", cols_destination);
        }

        static DataTable ExcelToDataTable(string path, string[] cols)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook workBook = app.Workbooks.Open(path, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            Excel.Worksheet workSheet = (Excel.Worksheet)workBook.ActiveSheet;

            DataTable dt = new DataTable();
            foreach (string col in cols)
            {
                dt.Columns.Add(col, typeof(String));
            }
            
            int rowIndex = 2;
            do
            {
                DataRow row = dt.NewRow();
                for (int i = 0; i < cols.Length; i++) 
                {
                    row[i] = Convert.ToString(((Excel.Range)workSheet.Cells[rowIndex, i + 1]).Value2);
                }

                rowIndex++;
                dt.Rows.Add(row);
            }
            while (((Excel.Range)workSheet.Cells[rowIndex, 1]).Value2 != null);

            return dt;
        }
    }
}
