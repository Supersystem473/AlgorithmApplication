using System.Diagnostics;

namespace WindowsFormsApp1
{
    class Boyer
    {
        public string result;
        int count = 0;
        public double mem;
        public double time;
        public Boyer(Database db)
        {
            for (int i = 0; i < db.DBArray.GetLength(0); i++)
            {
                for (int j = 0; j < db.DBArray.GetLength(1); j++)
                {
                    if (count == 0)
                    {
                        result = db.DBArray.GetValue(i + 1, j + 1).ToString();
                    }
                    else if (result == db.DBArray.GetValue(i + 1, j + 1).ToString())
                    {
                        count++;
                    }
                    else if (result != db.DBArray.GetValue(i + 1, j + 1).ToString())
                    {
                        count--;
                    }
                }
            }
        }
    }
}
