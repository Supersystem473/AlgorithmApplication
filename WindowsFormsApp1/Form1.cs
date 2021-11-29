using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActiveDB = BoolDB;
        }

        private void DBSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Boolean Database
            Alphabet Database
            One - to - Fifty Database
            One - to - Five Database
            Names Database
            */
            if (DBSelector.SelectedIndex == 0)
            {
                ActiveDB = BoolDB;
                RunNonadaptive = true;
                SetId = DataSet.BoolDB;
               
            }
            else if (DBSelector.SelectedIndex == 1)
            {
                ActiveDB = Alphabet;
                RunNonadaptive = false;
                SetId = DataSet.Alphabet;
            }
            else if (DBSelector.SelectedIndex == 2)
            {
                ActiveDB = OneToFifty;
                RunNonadaptive = true;
                SetId = DataSet.OneToFifty;
            }

            else if (DBSelector.SelectedIndex == 3)
            {
                ActiveDB = OneToFive;
                RunNonadaptive = true;
                SetId = DataSet.OneToFive;
            }
            else if (DBSelector.SelectedIndex == 4)
            {
                ActiveDB = FiftyNames;
                RunNonadaptive = false;
                SetId = DataSet.FiftyNames;
            }
                
            Console.WriteLine(DBSelector.SelectedIndex);

            ControlKey.Text = ActiveDB.key;

        }
        private void RunAlgorithms(Database activedatabase)
        {
            long mem;
            //report started lossy
            mem = GC.GetTotalMemory(true);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Lossy lossy = new Lossy(activedatabase);
            stopwatch.Stop();
            mem = GC.GetTotalMemory(true) - mem;
            Node<string> temp = lossy.results;
            LossyHot.Text = lossy.GetResultsMost();
            LossyMem.Text = Math.Abs(mem).ToString();
            LossyTime.Text = stopwatch.Elapsed.Milliseconds.ToString();
            //report finished lossy
            //report started Boyer
            mem = GC.GetTotalMemory(true);
            stopwatch.Reset();
            stopwatch.Start();
            Boyer boyer = new Boyer(ActiveDB);
            stopwatch.Stop();
            mem = Math.Abs(GC.GetTotalMemory(true) - mem);
            BoyerHot.Text = boyer.result;
            BoyerMem.Text = boyer.mem.ToString();
            BoyerTime.Text = stopwatch.Elapsed.Milliseconds.ToString();
            //report finished Boyer
            //report started NonAdaptive
            if (RunNonadaptive)
            {

                mem = GC.GetTotalMemory(true);
                stopwatch.Reset();
                stopwatch.Start();
                NonAdaptiveGroupTesting nagt = new NonAdaptiveGroupTesting(ActiveDB, NAk,NAW, NAT);
                stopwatch.Stop();
                mem = Math.Abs(GC.GetTotalMemory(true) - mem);
                MuthuNATime.Text = stopwatch.Elapsed.Milliseconds.ToString();
                MuthuNAHot.Text = nagt.GroupTest();
                MuthuNAMem.Text = mem.ToString();
            }
            else
            {
                MuthuNAHot.Text = "N/A";
                MuthuNAMem.Text = "N/A";
                MuthuNATime.Text = "N/A";
            }
            //report finished NonAdaptive

            //Start Kowalski Algorithm
            mem = GC.GetTotalMemory(true);
            stopwatch.Reset();
            stopwatch.Start();
            Kowalski kowalski = new Kowalski(ActiveDB,phi, delta, gama,epsilon);
            stopwatch.Stop();
            mem = Math.Abs(GC.GetTotalMemory(true) - mem);
            KowalskiAllHot.Text = kowalski.GetLarger();
            KowalskiMem.Text = mem.ToString();
            KowalskiTime.Text = stopwatch.Elapsed.Milliseconds.ToString();


            //report Started Misra
            mem = GC.GetTotalMemory(true);
            stopwatch.Reset();
            stopwatch.Start();
            Misra misra = new Misra(ActiveDB, Misrak);
            misra.Algorithm2(ActiveDB);
            stopwatch.Stop();
            mem = Math.Abs(GC.GetTotalMemory(true) - mem);

            MisraHot.Text = misra.t.Results(misra.t.root);
            
            MisraMem.Text = mem.ToString();
            MisraTime.Text = stopwatch.Elapsed.Milliseconds.ToString();

            //report finished Misra
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            epsilon = Convert.ToDouble(EpsilonInput.Value);
            delta = Convert.ToInt32(DeltaInput.Value);
            phi = Convert.ToInt32(PhiInput.Value);
            gama = epsilon / Convert.ToDouble(GamaInput.Value);
            Misrak = Convert.ToInt32(MisrakInput.Value);
            NAk = Convert.ToDouble(NAkInput.Value);
            NAT = Convert.ToInt32(NATInput.Value);
            NAW = Convert.ToInt32(NAWInput.Value);
            RunAlgorithms(ActiveDB);
        }

    

        private void PhiInput_ValueChanged(object sender, EventArgs e)
        {
            phi = Convert.ToInt32(PhiInput.Value);
        }

        private void DeltaInput_ValueChanged(object sender, EventArgs e)
        {
            delta = Convert.ToInt32(DeltaInput.Value);
        }

        private void GamaInput_ValueChanged(object sender, EventArgs e)
        {
            gama = epsilon / Convert.ToDouble(GamaInput.Value);
        }

        private void NAkInput_ValueChanged(object sender, EventArgs e)
        {
            NAk = Convert.ToDouble(NAkInput.Value);
        }

        private void MisrakInput_ValueChanged(object sender, EventArgs e)
        {
            Misrak = Convert.ToInt32(MisrakInput.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RefreshDB();
    }

        private void button5_Click(object sender, EventArgs e)
        {
            if (DBSelector.SelectedIndex == 0)
            {
                ActiveDB = BoolDB;
            }
            else if (DBSelector.SelectedIndex == 1)
            {
                ActiveDB = Alphabet;
            }
            else if (DBSelector.SelectedIndex == 2)
            {
                ActiveDB = OneToFifty;
            }

            else if (DBSelector.SelectedIndex == 3)
            {
                ActiveDB = OneToFive;
            }
            else if (DBSelector.SelectedIndex == 4)
            {
                ActiveDB = FiftyNames;
            }
        }

        private void Run_TImes_Click(object sender, EventArgs e)
        {
            epsilon = Convert.ToDouble(EpsilonInput.Value);
            delta = Convert.ToInt32(DeltaInput.Value);
            phi = Convert.ToInt32(PhiInput.Value);
            gama = epsilon / Convert.ToDouble(GamaInput.Value);
            Misrak = Convert.ToInt32(MisrakInput.Value);
            NAk = Convert.ToDouble(NAkInput.Value);
            NAT = Convert.ToInt32(NATInput.Value);
            NAW = Convert.ToInt32(NAWInput.Value);
            LoadingBar.Maximum = Convert.ToInt32(TimesToRun.Value);
            int runTimes = Convert.ToInt32(TimesToRun.Value);
            bool runNA = false;
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbooks xlWorkBooks = xlApp.Workbooks;
            Excel.Workbook xlWorkBook = xlWorkBooks.Open($@"D:\AlgorithmApplication\WindowsFormsApp1\Properties\Report.xlsx");
            int index = 0;
            if (SetId == DataSet.Alphabet)
            { index = 1; runNA = false; }
            else if (SetId == DataSet.BoolDB)
            { index = 2; runNA = true; ; }
            else if (SetId == DataSet.FiftyNames)
            { index = 3; runNA = false; }
            else if (SetId == DataSet.OneToFive)
            { index = 4; runNA = true; }
            else
            { index = 5; runNA = true; }
            int rowIndex=2, columnIndex=1;
            Stopwatch stopwatch = new Stopwatch();
            long mem;
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Sheets[index];
            mem = GC.GetTotalMemory(true);
            for (int i = 0; i < runTimes; i++)
            {
                LoadingBar.Value = i;
                xlWorkSheet.Cells[rowIndex, columnIndex] = ActiveDB.key;
                columnIndex++;


                //run kowalski
                stopwatch.Reset();
                mem = GC.GetTotalMemory(true);
                stopwatch.Start();
                Kowalski kowalski = new Kowalski(ActiveDB, phi, delta, gama, epsilon);
                stopwatch.Stop();
                mem = Math.Abs(GC.GetTotalMemory(true) - mem);
                xlWorkSheet.Cells[rowIndex, columnIndex] = kowalski.GetLarger();
                columnIndex++;
                xlWorkSheet.Cells[rowIndex, columnIndex] = stopwatch.ElapsedMilliseconds;
                columnIndex++;
                xlWorkSheet.Cells[rowIndex, columnIndex] = mem;
                columnIndex++;
                xlWorkSheet.Cells[rowIndex, columnIndex] = phi;
                columnIndex++;
                xlWorkSheet.Cells[rowIndex, columnIndex] = epsilon;
                columnIndex++;
                xlWorkSheet.Cells[rowIndex, columnIndex] = gama;
                columnIndex++;
                xlWorkSheet.Cells[rowIndex, columnIndex] = delta;
                columnIndex++;

                //run lossy
                mem = GC.GetTotalMemory(true);
                stopwatch.Reset();
                stopwatch.Start();
                Lossy lossy = new Lossy(ActiveDB);
                stopwatch.Stop();
                mem = GC.GetTotalMemory(true) - mem;
                xlWorkSheet.Cells[rowIndex,columnIndex] = lossy.GetResultsMost();
                columnIndex++;
                xlWorkSheet.Cells[rowIndex, columnIndex] = stopwatch.ElapsedMilliseconds;
                columnIndex++;
                xlWorkSheet.Cells[rowIndex, columnIndex] = mem;
                columnIndex++;

                //run Boyer
                mem = GC.GetTotalMemory(true);
                stopwatch.Reset();
                stopwatch.Start();
                Boyer boyer = new Boyer(ActiveDB);
                stopwatch.Stop();
                mem = Math.Abs(GC.GetTotalMemory(true) - mem);
                xlWorkSheet.Cells[rowIndex,columnIndex] = boyer.result;
                columnIndex++;
                xlWorkSheet.Cells[rowIndex, columnIndex] = mem;
                columnIndex++;
                xlWorkSheet.Cells[rowIndex,columnIndex] = stopwatch.Elapsed.Milliseconds;
                columnIndex++;

                //run Muthu
                if (runNA)
                {
                    mem = GC.GetTotalMemory(true);
                    stopwatch.Reset();
                    stopwatch.Start();
                    NonAdaptiveGroupTesting nagt = new NonAdaptiveGroupTesting(ActiveDB, NAk, NAW, NAT);
                    stopwatch.Stop();
                    mem = Math.Abs(GC.GetTotalMemory(true) - mem);
                    xlWorkSheet.Cells[rowIndex, columnIndex] = nagt.GroupTest();
                    columnIndex++;
                    xlWorkSheet.Cells[rowIndex, columnIndex] = stopwatch.Elapsed.Milliseconds.ToString();
                    columnIndex++;
                    xlWorkSheet.Cells[rowIndex, columnIndex] = mem.ToString();
                    columnIndex++;
                }
                else
                {
                    xlWorkSheet.Cells[rowIndex, columnIndex] = "N/A";
                    columnIndex++;
                    xlWorkSheet.Cells[rowIndex, columnIndex] = "N/A";
                    columnIndex++;
                    xlWorkSheet.Cells[rowIndex, columnIndex] = "N/A";
                    columnIndex++;
                }

                //run Misra
                mem = GC.GetTotalMemory(true);
                stopwatch.Reset();
                stopwatch.Start();
                Misra misra = new Misra(ActiveDB, Misrak);
                misra.Algorithm2(ActiveDB);
                stopwatch.Stop();
                mem = Math.Abs(GC.GetTotalMemory(true) - mem);

                xlWorkSheet.Cells[rowIndex,columnIndex] = misra.t.Results(misra.t.root);
                columnIndex++;
                xlWorkSheet.Cells[rowIndex,columnIndex] = stopwatch.Elapsed.Milliseconds.ToString();
                columnIndex++;
                xlWorkSheet.Cells[rowIndex, columnIndex] = mem.ToString();


                columnIndex = 1;
                rowIndex++;
                RefreshDB();
            }
            LoadingBar.Value = 0;
            xlWorkBook.Close(true);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlWorkSheet);
            xlApp.Quit();
        }
        public void RefreshDB()
        {
            if (SetId == DataSet.Alphabet)
            {
                Alphabet = new Database("Alphabet", 1, 31, "A1", "Z1550");
            }
            else if (SetId == DataSet.BoolDB)
            {
                BoolDB = new Database("BoolDB", 1, 7, "A1", "A500");
            }
            else if (SetId == DataSet.FiftyNames)
            {
                FiftyNames = new Database("FiftyRandomNames", 1, 7, "A1", "A1000");
            }
            else if (SetId == DataSet.OneToFifty)
            {
                OneToFifty = new Database("onethrough50", 1, 18, "A1", "N350");
            }
            else if (SetId == DataSet.OneToFive)
            {
                OneToFive = new Database("Onethroughfive", 1, 33, "A1", "AC5820");
            }

        }

        

        private void EpsilonInput_ValueChanged(object sender, EventArgs e)
        {
            epsilon = Convert.ToDouble(EpsilonInput.Value);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NAWInput_ValueChanged(object sender, EventArgs e)
        {
            NAW = Convert.ToInt32(NAWInput.Value);
        }

        private void NATInput_ValueChanged(object sender, EventArgs e)
        {
            NAT = Convert.ToInt32(NATInput.Value);
        }
    }
}
