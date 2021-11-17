using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class NonAdaptiveGroupTesting
    {
         private int numofinsertions
         private bool check;
         private int T;
         private int W;
         private int totalvalue;


        public NonAdaptive(Database db)
        {
            database = db;
            runAlg();
            mem = process.VirtualMemorySize64;
            time = process.TotalProcessorTime.Milliseconds;
        }
        public string bit (int x,int j )
        {
           
                int val = x;
                string binary = Convert.ToString(val, 2);
                int length = binary.Length() - 1;
                return binary[lengh - j] 
            }
        public void UpdateCounters( int x, bool trans, database.GetValue())
        {
            Array data = database.DBArray();
            if (trans == true)
            {
                int d = 1;
            }
            else
            {
                d = -1;
            }
            c[0] = c[0]+d
            for (j = 1, j<totalvalue, j++)
            {
                c[j] = c[j]+bit( x, j)*d
            }
        }
            public void ProcessItem(var x, var tt,  T,  W)
        {
            if (tt == x)
            {
                numofinsertions += 1;
            }
            else
                numofinsertions -= 1;
            for (i = 1,i < T, i++)
            {
                UpdateCounters(x, tt, c[i][h(x))
            }
        }
        public string GroupTest( T, W, int k)
        {
            for (i = 1, i < T, i++)
                for (j = 0, J < W - 1, j++)
                    int r = 1; int t = (numofinsertions / (k + 1)); int x = 0;
                    if c[i][j][0] > t
                        for (l = 1, l< totalvalue, l++)
                            int p = c[i][j][l] ; q = c[i][j][0] - p
                            if (p <= t || q <= t ) && (p>t || q>t)
                                i++
                        if (p > t) {
                        x = x + r
                        r = 2 * r
                    }
                  if h(x)= j 
                    for (l = 1, l< T, l++)
                         check (c[l][h(x)][0] > t)
                    if check == true;
            return x;
            }
        }
        
        
    }

}
