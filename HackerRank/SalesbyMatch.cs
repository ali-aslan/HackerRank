using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class SalesbyMatch
    {
        class Result
        {

            /*
             * Complete the 'sockMerchant' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. INTEGER n
             *  2. INTEGER_ARRAY ar
             */

            public static int sockMerchant(int n, List<int> ar)
            {
                List<int> counted = new List<int>();
                int tp=0;

                for (int i = 0; i < n; i++)
                {
                    if (!counted.Contains(ar[i]))
                    {
                        tp += (ar.Count(a => a == ar[i]) / 2);
                        counted.Add(ar[i]);
                    }

                }

                return tp;
            }

        }

        public class Solution
        {
            public static void Run()
            {


                int n = 9;

                List<int> ar = new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

                int result = Result.sockMerchant(n, ar);

                Console.WriteLine(result);

            }
        }
    }
}
