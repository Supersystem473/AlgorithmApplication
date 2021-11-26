using System;
using System.Linq;

namespace WindowsFormsApp1
{
    class Kowalski
    {
        private Database database;
        public double gama;
        public double epsilon = .49;
        int phi;
        public int delta = 1;
        int t = 0;
        public double phiPercentage = .08;
        private Red_BlackTree C = new Red_BlackTree();
        Disperser Disperser;
        public enum operation
        {
            insert, delete
        }
        public Kowalski(Database db, double percentage, int phi, int delta, double gama)
        {
            string s;
            database = db;
            this.gama = gama;
            this.phiPercentage = percentage;
            this.delta = delta;
            this.phi = phi;
            CreateDisperser();
            for (int i = 0; i < database.DBArray.GetLength(0); i++)
            {
                for (int j = 0; j < database.DBArray.GetLength(1); j++)
                {
                    s = database.DBArray.GetValue(i+1, j+1).ToString();
                    HandleOp(operation.insert, s);//Run HandleOp on whole data stream

                }
            }

        }
        public Kowalski(operation op, string x, Database db)
        {
            database = db;
            CreateDisperser();
            HandleOp(op, x);
        }
        public void CreateDisperser()
        {
            //Add Phi as a arguement
            Disperser = new Disperser(database, epsilon, gama, delta, phi);
        }
        public void HandleOp(operation op, string x)
        {
            t++;
                if (op == operation.insert)
                {
                    Disperser.Insert(x);
                }
                else
                {
                Disperser.Decrease(x);
                }
            if (C.Check(x) != null)
            {
                if (op == operation.insert)
                {
                    C.Increment(x);
                }
                else
                {
                    C.Decrement(x);
                }
            }
            else
            {
                int gmin =  Disperser.W[Disperser.G[x].ElementAt(1)]; //set gmin to first counter of x
                //take minimum group counters of x
                for (int z = 1; z < Disperser.G[x].Count; z++)//go through each group counter in G
                {
                    if (Disperser.W[Disperser.G[x].ElementAt(z)] < gmin)//compare the current value of gmin to the counter in W
                        gmin = Disperser.W[Disperser.G[x].ElementAt(z)];//change gmin to new counter if smaller
                }
                if (gmin >= gama * t)
                {
                    if (C.Size >= delta / (epsilon * gama))
                    {
                        C.remove_small(Convert.ToInt32(t * gama), C.root);
                    }
                    C.Add(x, gmin);
                }
            }

        }
        public string GetLarger()
        {
            double s = gama * t;
            string result = "";
            result = C.get_larger_than(s, C.root);
            return result;
        }

    }
}


