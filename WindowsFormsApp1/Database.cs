using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft;
using Excel = Microsoft.Office.Interop.Excel;
using System.Net.Mail;
using System.Net;


namespace WindowsFormsApp1
{
    class Database
    {
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        private string value, name, count;
        public Database(string DBname)
        {
            string DatabasePath = CreateDBPath(DBname);
            CreateArray(DatabasePath);
        }
        public string CreateDBPath(string dbName)
        {
            return  $@"DataStreams\{dbName}.xlsx";
        }
        public void CreateArray(string filepath)
        {
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(filepath);
            int row = 2, column = 1;
        }
    }
}
