using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class List 
    {
        public Node<string> root = new Node<string>();
        
        
        public void InsertNode(Node<string> proot, string pval, int pcount)
        {
            if (proot == null)
            {
                proot = new Node<string>();
                proot.value = pval;
            }
            else if (proot.Next == null)
            {
                proot.Next = new Node<string>();
                proot.Next.Previous = proot;
                proot.Next.value = pval;
                proot.count = pcount;
            }
            else
            {
                Node<string> temp = proot.Next;
                InsertNode(temp, pval, pcount);
            }
        }
    }
    class Node<T>
    {
        public Node<T> Next;
        public int count;
        public T value;
        public Node<T> Previous;

        public Node()
        {
            Next = null;
            Previous = null;
        }
        public Node(Node<T> previousnode)
        {
            Previous = previousnode;
        }
        public int NodeIndex()
        {
            if (Previous == null)
            {
                return 0;
            }
            else
            {
                return 1 + Previous.NodeIndex();
            }
        }
       
    }
}
