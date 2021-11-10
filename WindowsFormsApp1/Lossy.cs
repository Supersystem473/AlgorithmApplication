﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    class Lossy
    {
        private Database database;
        public Node<string> results = new Node<string>();
        IDictionary<string, int[]> dataSet = new Dictionary<string, int[]>();
        private int N = 0;
        private int bucket_width = 0;
        private double epsilon = 0.0;
        private int cBucketId = 1;
        private bool newBuc = false;
        private ProcessStartInfo startInfo;
        private Process process;
        public double time;
        public double mem;
        public Lossy(Database db)
        {
            database = db;
            runAlg();
            mem = process.VirtualMemorySize64;
            time = process.TotalProcessorTime.Milliseconds;
        }


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
            Process start = Process.Start(startInfo);
            
            epsilon = .1;
            bucket_width = (int)Math.Ceiling(1 / epsilon);
            //Console.WriteLine(bucket_width);

            foreach (string i in database.DBArray)
            {
                inDataSet(i);
                bucketNum();
                if (newBuc)
                {
                    prune();
                }
            }
            Node<string> ptemp = results;
           
            foreach (var pair in dataSet)
            {
                
                ptemp.value =  pair.Key + "," + String.Join(", ", pair.Value);
                //Console.WriteLine("{0},{1}", pair.Key, String.Join(", ", pair.Value));
                ptemp = ptemp.Next;
            }
            process = start;
        }
    }
}
