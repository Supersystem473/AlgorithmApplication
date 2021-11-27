using System;


namespace WindowsFormsApp1
{
    class NonAdaptiveGroupTesting
    {
        private int numofinsertions;
        private double frequency;
        private bool check;

        private int totalvalue;
        double δ = .1;
        double k = 1;
        int W, T;
        int P = 8546423;
        int[] a, b;
        Database database;
        int[,,] c;
        // call in array 
        public NonAdaptiveGroupTesting(Database db, double k)
        {
            this.k = k;
            
            database = db;
            k = 0.01 * database.DBArray.Length;
            W = Convert.ToInt32(2/(1/(2*k)));
            T = 2 ;
            totalvalue = Convert.ToInt32(Math.Log(database.DBArray.Length) + 1);
            frequency = (database.DBArray.Length) * .05;
            Initialize();
            for (int i = 0; i < database.DBArray.GetLength(0); i++)
            {
                for (int f = 0; f < database.DBArray.GetLength(1); f++)
                {
                    ProcessItem(Convert.ToInt32(database.DBArray.GetValue(i + 1, f + 1)), true);
                }
            }
        }
        private void Initialize()
        {
            c = new int[T + 1, W, totalvalue + 1];
            a = new int[T + 1];
            b = new int[T + 1];
            int n = 1;
            Random rand = new Random();
            for (int i = 1; i <= T; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    for (int l = 0; l < totalvalue; l++)
                    {
                        c[i, j, l] = 0;
                    }
                }
                a[i] = rand.Next(0, P - 1);
                b[i] = rand.Next(0, P - 1);
            }
        }
        public int bit(int x, int j)
        {

            int val = x;
            string binary = Convert.ToString(val, 2);
            int length = binary.Length - 1;
            if (binary.Length - j < 0)
                return 0;
            int b = binary[binary.Length - j];
            if (b == 49)
            {
                b = 1;
            }
            else if (b == 48)
                b = 0;
            return b;
        }
        public void UpdateCounters(int x, bool trans, int i, int hx)
        {
            int d = 1;
            double[] q = new double[totalvalue];
            if (trans == true)
            {
                //true == insertion
                d = 1;
            }
            else
            {
                //false == deletion
                d = -1;
            }
            c[i, hx, 0] = c[i, hx, 0] + d;
            for (int j = 1; j < totalvalue; j++)
            {

                c[i, hx, j] = c[i, hx, j] + bit(x, j) * d;
            }
        }
        public void ProcessItem(int x, bool tt)
        {
            if (tt == true)
            {
                numofinsertions += 1;
            }
            else
                numofinsertions -= 1;
            for (int i = 1; i < T; i++)
            {
                int hx = ((a[i] * x + b[i]) % P) % W;
                UpdateCounters(x, tt, i, hx);
            }
        }
        public string GroupTest()
        {
            string results = "";
            for (int i = 1; i < T; i++)
                for (int j = 0; j < W - 1; j++)
                {


                    int r = 1;
                    int t = Convert.ToInt32(numofinsertions / (k + 1));
                    int x = 0;
                    if (c[i, j, 0] > t)
                    {


                        for (int l = 1; l < totalvalue; l++)
                        {


                            int p = c[i, j, l];
                            int q = c[i, j, 0] - p;
                            if ((p <= t || q <= t) && (p > t || q > t))
                                i++;
                            if (p > t)
                            {
                                x = x + r;

                            }
                            r = 2 * r;
                        }
                        int hi = ((a[i] * x + b[i]) % P) % W;
                        if (hi == j)
                        {


                            for (int l = 1; l <= T; l++)
                            {
                                int hl = ((a[l] * x + b[l]) % P) % W;

                                if (c[l, hl, 0] > t)
                                {
                                    results = results + x.ToString();
                                }
                            }
                        }
                    }
                }
            return results;
        }
    }
}




