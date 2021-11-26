using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

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
            }
            else if (DBSelector.SelectedIndex == 1)
            {
                ActiveDB = Alphabet;
                RunNonadaptive = false;
            }
            else if (DBSelector.SelectedIndex == 2)
            {
                ActiveDB = OneToFifty;
                RunNonadaptive = true;
            }

            else if (DBSelector.SelectedIndex == 3)
            {
                ActiveDB = OneToFive;
                RunNonadaptive = true;
            }
            else if (DBSelector.SelectedIndex == 4)
            {
                ActiveDB = FiftyNames;
                RunNonadaptive = false;
            }
            NAk = ActiveDB.Distinct.Count;
            Misrak = ActiveDB.Distinct.Count;
            
                
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
            LossyMem.Text = mem.ToString();
            LossyTime.Text = stopwatch.Elapsed.Milliseconds.ToString();
            //report finished lossy
            //report started Boyer
            mem = GC.GetTotalMemory(true);
            stopwatch.Reset();
            stopwatch.Start();
            Boyer boyer = new Boyer(ActiveDB);
            stopwatch.Stop();
            mem = GC.GetTotalMemory(true) - mem;
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
                NonAdaptiveGroupTesting nagt = new NonAdaptiveGroupTesting(ActiveDB, NAk);
                stopwatch.Stop();
                mem = GC.GetTotalMemory(true) - mem;
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
            Kowalski kowalski = new Kowalski(ActiveDB, percentage, phi, delta, gama);
            stopwatch.Stop();
            mem = GC.GetTotalMemory(true) - mem;
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
            mem = GC.GetTotalMemory(true) - mem;

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
            NAk = Convert.ToInt32(NAkInput.Value);
            RunAlgorithms(ActiveDB);
        }

        private void Percentage_ValueChanged(object sender, EventArgs e)
        {
           
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
            NAk = Convert.ToInt32(NAkInput.Value);
        }

        private void MisrakInput_ValueChanged(object sender, EventArgs e)
        {
            Misrak = Convert.ToInt32(MisrakInput.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
        BoolDB = new Database("BoolDB", 1, 7, "A1", "A500");
        OneToFifty = new Database("onethrough50", 1, 18, "A1", "N350");
        Alphabet = new Database("Alphabet", 1, 31, "A1", "Z1550");
        OneToFive = new Database("Onethroughfive", 1, 33, "A1", "AC5820");
        FiftyNames = new Database("FiftyRandomNames", 1, 7, "A1", "A1000");
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
    }
}
