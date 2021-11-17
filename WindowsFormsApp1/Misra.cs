using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    class Misra
    {
        private string algorithm1Val;
        private Database database;
        private Process process;
        public Misra(Database db)
        {
            database = db;
        }
        private AVLTree t = new AVLTree();
        public ArrayList A2Results;
        public double mem, time;
        private string[] Algorithm1(Database pdb)
        {
            int k = 2;
            int i = 0;
            int s = 0;
            int n = pdb.DBArray.Length;
            List t = new List();
            Node<string> ptemp = t.root;
            t.root.count = 0;
            while (i != n)
            {
                while (ptemp != null)
                {
                    if (ptemp.NodeIndex() == 0 && s + k <= i + 1)
                    {
                        s += k;
                    }
                    else if (ptemp.NodeIndex() == 0 && s + k > i + 1)
                    {
                        t.InsertNode(t.root, pdb.DBArray.GetValue(i).ToString(), s + k);

                    }
                    else if (ptemp.NodeIndex() != 0)
                    {
                        ptemp.count += k;
                    }
                }
                i++;
                ptemp = t.root;
                //Delete all pairs where cj = i
                while (ptemp != null)
                {
                    if(ptemp.count == i)
                    {
                        if (ptemp.Previous == null)
                        {
                            t.root = t.root.Next;
                        }
                        else if (ptemp.Next == null)
                        {
                            ptemp.Previous.Next = null;
                        }
                        else
                        {
                            ptemp.Previous.Next = ptemp.Next;
                            ptemp.Next.Previous = ptemp.Previous;
                        }
                    }
                }
            }
            ptemp = t.root;
            int index = 0;
            string[] z;
            if (t.root == null)
            {
                return new string[1]{ "no values over n/k"};
            }
            else if (t.root.count == 0)
            {
                return new string[1] { "no values over n/k" };
            }
            else
            {
                while(ptemp != null)
                {
                    index++;
                    ptemp = ptemp.Next;
                }
                z = new string[index];
                ptemp = t.root;
                i = 0;
                while(i != index)
                {
                    z[i] = ptemp.value;
                    ptemp = ptemp.Next;
                    i++;
                }
                return z;
            }
        }
        //Algorithm 2
        public void Algorithm2 (Database pdb)
        
        {
            
            int j=0, i = 0,k=0;
            bool go = true;
            database = pdb;
            int n = pdb.DBArray.GetLength(0), m = pdb.DBArray.GetLength(1);
            ArrayList t = new ArrayList();
            string[] remove = new string[2];
            int d = 0;
            Process start = Process.Start(@"C:\Users\jdste\source\repos\AlgorithmApplication\WindowsFormsApp1\Properties\Info.txt");
            while (i != n)
            {
                while (j != m)
                {  
                    if(t.Count == 0 || t == null) 
                    {
                        t.Insert(0,database.DBArray.GetValue(i+1,j+1).ToString());
                        d++;
                    }
                    else
                    {
                        if (!t.Contains(database.DBArray.GetValue(i+1, j+1).ToString()))
                        {
                            d++;
                        }
                        t.Insert(t.Count,database.DBArray.GetValue(i+1,j+1).ToString());

                    }
                    if(d == 2)
                    {
                      remove[0] = t[t.Count-1].ToString();
                      t.RemoveAt(t.Count-1);
                      k=1;
                        for (int g = 0; g < t.Count; g++) 
                        {
                            if(t[g].ToString() != remove[0])
                            {
                                
                                t.RemoveAt(g);
                                g = t.Count;
                            }
                        }
                    }
                    j++;

                }
                j = 0;
                i++;
            }
            process = start;
            A2Results = t;
            mem = process.VirtualMemorySize64;
            time = process.TotalProcessorTime.TotalMilliseconds;

        }
       

    }
}
