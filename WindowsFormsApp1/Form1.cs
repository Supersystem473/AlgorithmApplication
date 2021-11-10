using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                ActiveDB = BoolDB;
            else if (DBSelector.SelectedIndex == 1)
                ActiveDB = Alphabet;
            else if (DBSelector.SelectedIndex == 2)
                ActiveDB = OneToFifty;
            else if (DBSelector.SelectedIndex == 3)
                ActiveDB = OneToFive;
            else if (DBSelector.SelectedIndex == 4)
                ActiveDB = FiftyNames;
            ControlKey.Text = ActiveDB.key;
        }
        private void RunAlgorithms(Database activedatabase)
        {
            //report started lossy
            Lossy lossy = new Lossy(activedatabase);
            if(lossy.results == null)
            {
                LossyHot.Text = "Inconclusive";
            }
            else {
                LossyHot.Text = "";
                while (lossy.results != null)
                {
                    LossyHot.Text = LossyHot.Text + " " + lossy.results.value;
                }
            }
            LossyMem.Text = lossy.mem.ToString();
            LossyTime.Text = lossy.time.ToString();
            //report finished lossy
            //report started PageRanks
            PageRank pr = new PageRank(ActiveDB.DBArray);
            if (pr.results == null)
            {
                PRankHot.Text = "Inconclusive";
            }
            else
            {
                PRankHot.Text = "";
                for(int f = 0; f < pr.results.Length; f++)
                {
                    PRankHot.Text = PRankHot + " " + pr.results[f];
                }
            }
            PRankMem.Text = pr.mem.ToString();
            PRankTime.Text = pr.time.ToString();
            //report finished PageRanks
            //report started NonAdaptive
            //report finished NonAdaptive
            //report started Muthu
            //report finished Muthu
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RunAlgorithms(ActiveDB);
        }
    }
}
