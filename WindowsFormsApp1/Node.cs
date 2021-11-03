using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Node<T>
    {
        public Node<T> Next;
        public int count;
        public T value;
        
        
        public Node()
        {
            Next = null;
        }
    }
}
