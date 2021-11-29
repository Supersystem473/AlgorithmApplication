using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{

    class Disperser
    {
        private Database database;
        public IDictionary<string, HashSet<int>> G = new Dictionary<string, HashSet<int>>();
        public int[] W;
        public int degree;
        int LengthOfW;
        public double phi;
        public double phiPercentage = .05;//if we want to use phi by assigning a percentage of the database
        public Disperser(Database db, double epsilon, double gama, int delta, double phi)
        {

            //V = whole database
            // all parameters are converted to int as to not have a decimal for a number of elements
            // degree represents the left-side degree (d)
            degree = Convert.ToInt32(delta / gama);

            //test different Phi and delta values
            this.phi = phi;
            LengthOfW = Convert.ToInt32(phi * (degree / (2 * epsilon * gama)));
            W = new int[LengthOfW];//initialize W
            Random rand = new Random();
        }
        public void Insert(string x)
        {
            if (G.ContainsKey(x))
            {
                foreach (int g in G[x])
                {
                    W[g]++;
                }
            }
            else
            {
                G.Add(x, new HashSet<int>());//Add x as a new key/element in G
                Random rand = new Random();
                for (int i = 0; i < degree; i++)//add a new index degree times
                {
                    int r = rand.Next(0, LengthOfW - 1);//it starts at 0 and is LengthOfW-1 because the index is zero based
                    //while (G[x].Contains(r))//if the index is already in G get a new one.
                    //    r = rand.Next(0, LengthOfW - 1);
                    G[x].Add(r);//add r as a new index in W
                    W[r]++;//increase counter
                }
            }
        }
        public void Decrease(string x)
        {
            foreach(int g in G[x])
            {
                if(W[g]-1 == 0)
                {
                    G.Remove(x);
                    //if a counter for x falls below zero, remove the group counter for x
                    return;
                    //ends the method
                }
                else
                {
                    W[g]--;
                }
            }
        }

    }
}



