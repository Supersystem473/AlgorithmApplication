using System;
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
        public double epsilom = .49;
        public int delta = 1;
        string x;
        private AVLTree C = new AVLTree();
        public enum operation
        {
            insert,delete
        }
        public Kowalski(operation op,Database db)
        {
            database = db;
            for(int i = 0; i < database.DBArray.GetLength(0); i++)
            {
                for (int f = 0; f< database.DBArray.GetLength(1); f++)
                {
                    C.insert(C.root, database.DBArray.GetValue(i + 1, f + 1).ToString());
                }
            }
            
            //create G(x)
            
            //foreach(int g in G)
            //{
            //    if(op == operation.insert)
            //        g++;
            //    else
            //        g--;
            //}
            
            //if(C.Check(x) != null)
            //{
            //    if(op == operation.insert)
            //    {
            //        C.Increment(C.root, x);
            //    }
            //    else
            //    {
            //        C.Decrement(C.root, x);
            //    }
            //}
            //else
            //{
            //    int gmin = G.Min;
            //    if(gmin >= (gama * G.Count))
            //    {
            //        if(C.Size() >= (delta / (epsilom * gama)))
            //        {
            //            //C.remove_small(G.Count*gama);
            //        }
            //        C.insert(x, gmin);
            //    }
            //}
            

        }


    }

}
