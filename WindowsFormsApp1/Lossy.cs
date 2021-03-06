using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace WindowsFormsApp1
{
    class Lossy
    {
        private Database database;
        public Node<string> results = new Node<string>();
        public IDictionary<string, int[]> dataSet = new Dictionary<string, int[]>();
        private int N = 0;
        private int bucket_width = 0;
        private double epsilon = 0.0001; //user
        private int cBucketId = 1;
        private bool newBuc = false;
       
        private Process process;
        public double s = .039; //user
        public double time;
        public double mem;
        public Lossy(Database db)
        {
            database = db;
            runAlg();
            
           
        }


        public void inDataSet(string data)
        {
            int[] value = new int[2];
            if (dataSet.ContainsKey(data))
            {
                dataSet.TryGetValue(data, out value);
                value[0] += 1;
                dataSet[data] = value;

                // Array[~2][1] += 1;
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
            foreach (var pair in dataSet.ToList())
            {
                if (pair.Value[0] + pair.Value[1] <= cBucketId - 1)
                {
                    //Console.WriteLine(pair.Value[0] + ", " + pair.Value[1] + ", " + (cBucketId - 1));
                    dataSet.Remove(pair.Key);
                }
            }
        }

        public string GetResults()
        {
            string results = "";
            foreach (var pair in dataSet)
            {
                if (pair.Value[0] >= (s - epsilon) * N)
                {
                    results = results + pair.Key + " ";
                }
            }
            return results;
        }
        public string GetResultsMost()
        {
            int highest = 0;
            string result = "";
            foreach (var pair in dataSet)
            {
                if (pair.Value[0] > highest)
                {
                    highest = pair.Value[0];
                    result = pair.Key;
                }
            }
            return result;
        }
        public void runAlg()
        {
           
            epsilon = .01; //change to user input
            bucket_width = (int)Math.Ceiling(1 / epsilon);
            //Console.WriteLine(bucket_width);

            for (int i = 0; i < database.DBArray.GetLength(0); i++)
            {
                for (int j = 0; j < database.DBArray.GetLength(1); j++)
                {
                    inDataSet(database.DBArray.GetValue(i + 1, j + 1).ToString());
                    bucketNum();
                    if (newBuc)
                    {
                        prune();
                    }
                }
            }


        }
    }
}
