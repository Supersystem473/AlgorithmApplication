using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Lossy
    {

        private string[,] testData = new string[,] { { "1", "3", "4", "5", "2", "2", "1", "3", "3", "4" },
                                                     { "2", "4", "3", "2", "5", "3", "1", "2", "3", "1" },
                                                     { "3", "3", "2", "3", "5", "4", "4", "5", "3", "2" },
                                                     { "4", "3", "2", "5", "5", "5", "3", "4", "2", "1" },
                                                     { "2", "3", "2", "3", "4", "3", "3", "1", "1", "2" },
                                                     { "1", "4", "4", "5", "2", "1", "2", "3", "1", "3" },
                                                     { "4", "4", "3", "2", "2", "3", "1", "2", "3", "4" },
                                                     { "1", "1", "2", "3", "2", "4", "5", "2", "1", "2" },
                                                     { "4", "2", "3", "4", "3", "2", "1", "3", "4", "5" },
                                                     { "2", "3", "2", "1", "1", "4", "5", "2", "3", "3" } };


        private int N = 0;
        private int bucket_width = 0;
        private double epsilon = 0.0;
        private int cBucketId = 1;
        private bool newBuc = false;

        IDictionary<string, int[]> dataSet = new Dictionary<string, int[]>();

        public void inDataSet(string data)
        {
            int[] value = new int[2];
            if (dataSet.ContainsKey(data))
            {
                dataSet.TryGetValue(data, out value);
                value[0] += 1;
                dataSet[data] = value;
            }
            else
            {
                dataSet.Add(data, new int[] { 1, cBucketId - 1 });
            }
        }

        public void bucketNum()
        {
            newBuc = false;
            N++;
            int detBucket = N % bucket_width;
            if (detBucket == 0)
            {
                cBucketId++;
                newBuc = true;
            }
        }

        public void prune()
        {
            foreach (var pair in dataSet)
            {
                if (pair.Value[0] + pair.Value[1] <= cBucketId - 1)
                {
                    //Console.WriteLine(pair.Value[0] + ", " + pair.Value[1] + ", " + (cBucketId - 1));
                    dataSet.Remove(pair.Key);
                }
            }
        }


        public void runAlg()
        {
            epsilon = .1;
            bucket_width = (int)Math.Ceiling(1 / epsilon);
            //Console.WriteLine(bucket_width);

            foreach (string i in testData)
            {
                inDataSet(i);
                bucketNum();
                if (newBuc)
                {
                    prune();
                }
            }

            foreach (var pair in dataSet)
            {
                Console.WriteLine("{0},{1}", pair.Key, String.Join(", ", pair.Value));
            }

        }
    }
}
