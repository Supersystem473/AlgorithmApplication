using System.Collections.Generic;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApp1
{
    public class Database
    {
        Excel.Application xlApp;
        Excel.Workbooks xlWorkBook;
        Excel.Workbook _xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        private string value, name;
        private int count;
        public List<string> Distinct = new List<string>();
        public Node<string> DBList = new Node<string>();
        public System.Array DBArray;
        public string DatabasePath;
        public AVLTree AVL = new AVLTree();
        public string key;
        public int Count
        {
            get { return count; }
            set { }
        }
        public Database(string DBname, int keyrow, int keycolumn, string cell1, string cell2)
        {
            DatabasePath = CreateDBPath(DBname);
            CreateArray(DatabasePath, keyrow, keycolumn, cell1, cell2);
        }
        public string CreateDBPath(string dbName)
        {
            return $@"D:\AlgorithmApplication\WindowsFormsApp1\Properties\{dbName}.xlsx";
        }
        public void CreateArray(string filepath, int keyrow, int keycolumn, string cell1, string cell2)
        {

            Node<string> temp = DBList;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks;
            _xlWorkBook = xlWorkBook.Open(filepath);
            xlWorkSheet = (Excel.Worksheet)_xlWorkBook.Sheets[1];
            System.Array array;
            Excel.Range range = xlWorkSheet.Range[cell1, cell2];
            array = (System.Array)range.Cells.Value;
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (!Distinct.Contains(array.GetValue(i + 1, j + 1).ToString()))
                    {
                        Distinct.Add(array.GetValue(i + 1, j + 1).ToString());
                    }
                }
            }
                DBArray = array;
                //get the key cell
                key = xlWorkSheet.Cells[keyrow, keycolumn].Value.ToString();
            xlWorkBook.Close();
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(range);
            xlApp.Quit();
            }
        }
    }

