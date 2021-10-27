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
        private string value, name; 
        private int count;
        public Node<string> DBList = new Node<string>();
        public string[] DBArray;
        public int Count
        {
            get { return count; }
            set { }
        }
        public Database(string DBname)
        {
            string DatabasePath = CreateDBPath(DBname);
            CreateArray(DatabasePath);
        }

        //For Maggie: Need to return the filepath
        public string CreateDBPath(string dbName)
        {
            return  $@"DataStreams\{dbName}.xlsx";
        }
        public void CreateArray(string filepath)
        {
            Node<string> temp = DBList;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(filepath);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Sheets[1];
            int row = 1, column = 1;
            name = xlWorkSheet.Cells[row, column].Value.ToString();
            column++;
            while (row != 0)
            {
                
                
                if (xlWorkSheet.Cells[row, column].Value == null)
                {
                    row++;

                    if (xlWorkSheet.Cells[row, column].Value == null)
                    {
                        row = 0;
                    }
                }

                else
                {
                    while (temp != null)
                    {
                        temp = temp.Next;
                    }
                    value = xlWorkSheet.Cells[row, column].Value.ToString();
                    temp.value = xlWorkSheet.Cells[row, column].Value.ToString();
                    DBList.count++;
                    count++;
                    column++;
                }
                

            }
            DBArray = new string[count];
            for(int i = 0; i < DBArray.Length; i++) 
            {
                temp = DBList;
                DBArray[i] = temp.value;
                temp = temp.Next;
                
            }
            xlWorkBook.Close();
            xlApp.Quit();
        }
    }
}
