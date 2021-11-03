using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Misra
    {
        private Node<string> t = new Node<string>();
        private Database database;
        public Misra(Database db)
        {
            database = db;

        }
        private void CreateT()
        {
            Node<string> tempdb = database.DBList;
            Node<string> tempt = t;
            bool IsNotInList = false ;
            while (tempdb != null)
            {
                if (tempt == null)
                {
                    tempt.value = tempdb.value;
                    tempt.count++;
                }
                else
                {
                    while (tempt != null & IsNotInList)
                    {
                        if(tempt.value == tempdb.value)
                        {
                            tempt.count++;
                            IsNotInList = false;
                        }
                        else if (tempt.Next == null)
                        {
                            tempt = tempt.Next;
                            tempt.value = tempdb.value;
                            IsNotInList = false;
                        }
                        
                    }
                }
            }
        }

    }
}
