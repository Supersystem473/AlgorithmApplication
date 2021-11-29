using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace WindowsFormsApp1
{
    class Misra
    {
        private Database database;
        public Misra(Database db, int k)
        {
            database = db;
            this.k = k;
        }
        public AVLTree t = new AVLTree();
        public List<string> T = new List<string>();
        public int k = 5, d = 0;
        public void Algorithm2(Database pdb)

        {
            database = pdb;
            for(int i = 0; i < database.DBArray.GetLength(0); i++)
            {
                for(int j = 0; j < database.DBArray.GetLength(1); j++)
                {

                    if (t.root == null)
                    {
                        t.root = t.insert(t.root, database.DBArray.GetValue(i + 1, j + 1).ToString());
                    }
                    else if (t.Increment(t.root, database.DBArray.GetValue(i + 1, j + 1).ToString()))
                    { 
                    }
                    else
                    {
                        t.insert(t.root, database.DBArray.GetValue(i + 1, j + 1).ToString());
                        
                    }
                    if(t.Size() >= k)
                    {
                        t.DecrementAll(t.root);
                    }
                }
            }
           
            
            
        }
    }


}



//int j = 0, i = 0, f;
//database = pdb;
//int n = pdb.DBArray.GetLength(0), m = pdb.DBArray.GetLength(1);
//List<string> remove = new List<string>();
//int d = 0;
//while (i != n)
//{
//    while (j != m)
//    {
//        if (T.Count == 0)
//        {
//            T.Add(database.DBArray.GetValue(i + 1, j + 1).ToString());
//            d++;
//        }
//        else
//        {
//            if (!T.Contains(database.DBArray.GetValue(i + 1, j + 1).ToString()))
//            {
//                d++;
//            }
//            T.Add(database.DBArray.GetValue(i + 1, j + 1).ToString());

//        }
//        if (d >= k)
//        {
//            remove = new List<string>();
//            f = 0;
//            foreach (string l in T)
//            {
//                if (!remove.Contains(l))
//                {
//                    remove.Add(l);
//                    f++;
//                }
//                if (f == k)
//                {
//                    break;
//                }
//            }

//            foreach (string l in remove)
//            {
//                T.Remove(l);
//            }
//            d = 0;
//        }
//        j++;

//    }
//    j = 0;
//    i++;
////}