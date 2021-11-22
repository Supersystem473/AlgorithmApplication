using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Disperser
    {
        int degree;
        int phi;
        int LengthOfW, LengthOfG;
        private Database database;
        public IDictionary<int, List<string>> GroupCounterSet = new Dictionary<int, List<string>>();
        private List<string> V = new List<string>();

        public Disperser(Database db, double epsilon, double gama, int delta)
        {
            
            database = db;
            // all parameters are converted to int as to not have a decimal for a number of elements
            // degree represents the left-side degree (d)
            int degree = Convert.ToInt32(database.DBArray.Length * .05);
            int phi = Convert.ToInt32(database.DBArray.Length * .08);
            int LengthOfW = Convert.ToInt32(phi * (degree / (2 * epsilon * gama)));
            // length of G represents the set size we will use for our group counters
            int LengthOfG = Convert.ToInt32((1 / epsilon) * LengthOfW);
            Random rand = new Random();
            for (int i = 0; i < database.DBArray.GetLength(0); i++)
            {
                for (int j = 0; j < database.DBArray.GetLength(1); j++)
                {
                    rand.Next(0, LengthOfG);
                    if (GroupCounterSet.ContainsKey(LengthOfG))
                    {
                        // index is +1 because the array is 1 based indexing
                        GroupCounterSet[LengthOfG].Add(database.DBArray.GetValue(i + 1, j + 1).ToString());
                        
                    }
                    else
                    {
                        GroupCounterSet.Add(LengthOfG, new List<string> { database.DBArray.GetValue(i + 1, j + 1).ToString() });
                    }

                }
            
            }
        }
     
       

    }

}

