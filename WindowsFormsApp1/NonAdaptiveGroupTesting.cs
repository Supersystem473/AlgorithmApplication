using System;


namespace WindowsFormsApp1
{
    class NonAdaptiveGroupTesting
    {
        private int numofinsertions;
        private double frequency;
        private bool check;
        int n;
        private int totalvalue;
        double δ = .1;
        double k = 1;
        int W, T;
        int P = 8546423;
        int[] a, b;
        Database database;
        int[,,] c;
        // call in array 
        public NonAdaptiveGroupTesting(Database db, double k, int W, int T)
        {
            this.k = k;
            
            database = db;
            this.W = W;
            this.T = T;
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
            numofinsertions = 0;
            Random rand = new Random();
            for (int i = 0; i <= T; i++)
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
            int bi =0;
            int val = x;
            char[] binaryArray;
            string binary = Convert.ToString(val, 2);
            binaryArray = binary.ToCharArray();
            Array.Reverse(binaryArray);
            //int length = binary.Length - 1;
            if (binaryArray.Length - j < 0)
                return 0;
            char b = binaryArray[j-1];
            return (int)Char.GetNumericValue(b);
            //if (b == '1')
            //{
            //    bi = 1;
            //}
            //else if (b == '0')
            //    bi = 0;
            //return bi;
        }
        public void UpdateCounters(int x, bool trans, int i, int hx)
        {
            int d = 0;
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
            //bool endLoop = false;
            string results = "";
            for (int i = 1; i <= T; i++)
                for (int j = 0; j < W - 1; j++)
                {

                    //endLoop = false;
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
                            {
                                //endLoop = true;
                                //break;
                                
                            }
                            else if (p > t)
                            {
                                x = x + r;
                                
                            }
                            r = 2 * r;
                        }
                        //if (endLoop)
                        //{
                        //    break;
                        //}
                        
                            int hi = ((a[i] * x + b[i]) % P) % W;
                            if (hi == j)
                            {

                                for (int l = 1; l <= T; l++)
                                {
                                    int hl = ((a[l] * x + b[l]) % P) % W;

                                    if (c[l, hl, 0] > t)
                                    {
                                        results = results + " " + x.ToString();
                                    }
                                }
                            }
                        
                    }
                }
            return results;
        }
    }
}




