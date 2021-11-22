using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Kowalski
    {
        private Database database;
        public double gama = .25;
        public double epsilon = .49;
        public int delta = 1;
        string x;
        private AVLTree C = new AVLTree();
        Disperser G;
        public enum operation
        {
            insert, delete
        }
        public Kowalski(operation op, Database db)
        {
            database = db;
            CreateDisperser();
        }
        public void CreateDisperser()
        {
            G = new Disperser(database,epsilon,gama,delta);
        }
        public void CreateBalancedTree()
        {
            for (int i = 0; i < database.DBArray.GetLength(0); i++)
            {
                for (int j = 0; j < database.DBArray.GetLength(1); j++)
                {
                    x = database.DBArray.GetValue(i, j).ToString();
                    if (C.Check(x) != null)
                    {
                        C.Increment(C.root, x);
                    }
                    int gmin = 0;
                    //calculate gmin
                    for(int f = 0; f < G.GroupCounterSet.Count; f++)
                    {
                        if(gmin > G.GroupCounterSet.ElementAt(f).Value.Count)
                        {
                            // Disperser >> Directory >> Goes to index 'f' >> Gets List at f >> gets count of values in list
                            gmin = G.GroupCounterSet.ElementAt(f).Value.Count;
                        }
                    }
                    if(gmin < gama*G.GroupCounterSet.Count)
                    {
                        if(C.Size() == delta / (epsilon * gama))
                        {
                            C.remove_small(G.GroupCounterSet.Count*gama);
                        }
                        C.insert(C.root, x);
                    }

                }
            }
        }
        public void HandleOp(operation op, string x)
        {

        }
    }
    
}


