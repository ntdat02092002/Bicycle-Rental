﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Bicycle_Rental
{
    internal class Database
    {
        public static string asset_path;
        public static DataTable Bicycle { get; set; }
        public static DataTable User { get; set; }
        public static DataTable Agency { get; set; }

        public static DataTable Tour { get; set; }

        public static void KhoiTao()
        {
            asset_path = System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\asset\";

            string[] cols_bicycle = { "maxe", "tenxe", "loai", "giathue", "madaily", "desciption", "dathue", "mausac", "kichthuoc", "tocdo" };
            Bicycle = ExcelToDataTable(asset_path + "bicycle.xlsx", cols_bicycle);

            string[] cols_user = { "tendangnhap", "matkhau", "ten", "avatar", "gioitinh", "ngay", "thang", "nam", "email", "sdt", "admin", "penalty" };
            User = ExcelToDataTable(asset_path + "user.xlsx", cols_user);

            string[] cols_agency = { "madaily", "tendaily", "diachi", "tinh", "sdt", "latitude", "longitude" };
            Agency = ExcelToDataTable(asset_path + "agency.xlsx", cols_agency);

            string[] cols_tour = { "tour_code", "name", "departure", "destination", "available", "start_day", "duration", "distance", "minimum_age", "price", "group_size", "curent_menber", "route" };
            Tour = ExcelToDataTable(asset_path + "tour.xlsx", cols_tour);
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

            workBook.Close(0);
            app.Quit();

            return dt;
        }
    }
}
