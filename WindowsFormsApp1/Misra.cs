using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Misra
    {
        private string algorithm1Val;
        private Database database;
        public Misra(Database db)
        {
            database = db;
        }
        private AVLTree t = new AVLTree();
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
                        t.InsertNode(t.root, pdb.DBArray[i], s + k);

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
       

    }
}
