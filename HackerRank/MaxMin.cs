using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class MaxMin //226691
    {
        class Result
        {

            /*
             * Complete the 'maxMin' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. INTEGER k
             *  2. INTEGER_ARRAY arr
             */

            public static int maxMin(int k, List<int> arr)
            {
            
                arr.Sort();

                int minUnfairness = Int32.MaxValue;
                int unfairness;
                for (int i = 0; i < arr.Count - k + 1; i++)
                {
                    unfairness = arr[i + k - 1] - arr[i];
                    if (unfairness < minUnfairness)
                    {
                        minUnfairness = unfairness;
                    }
                }

                return minUnfairness;






            }

        }

        public class Solution
        {
            public static void Run()
            {
                int k = 8;

                //List<int> arr = new List<int>() { 1, 2, 3, 4, 10, 20, 30, 40, 100, 200 };
                List<int> arr = new List<int>() { 6327,571,6599,479,7897,9322,4518,571,6677,7432,815,6920,4329,4104,7775,5708,7991,5802,8619,6053,7539,7454,9000,
                            3267,6343,7165,4095,439,5621,4095,153,1948,1018,6752,8779,5267,2426,9649,2190,9103,7081,3006,2376,7762,3462,151,3471,1453,2305,8442, };

                int result = Result.maxMin(k, arr);

                Console.WriteLine(result);
            }
        }
    }
}
