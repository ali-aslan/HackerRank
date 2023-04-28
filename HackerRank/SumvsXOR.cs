using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class SumvsXOR
    {
        class Result
        {

            /*
             * Complete the 'sumXor' function below.
             *
             * The function is expected to return a LONG_INTEGER.
             * The function accepts LONG_INTEGER n as parameter.
             */

            public static long sumXor(long n)
            {
                //int count=0; // easy solution but takes too much time 
                //for (int i = 0; i < n; i++)
                //{
                //    if ((n + i) == (n ^ i))
                //        count++;
                //}

                //return count;

                long result = 1;
                if (n == 0)
                {
                    return 1;
                }
                int a = Convert.ToString(n, 2).Count(s => s == '0');
                Console.WriteLine(Convert.ToString(n, 2));
                for (int t = 0; t < a; t++)
                {
                    result *= 2;
                }
                return result;

            }

        }

        public class Solution
        {
            public static void Run()
            {
                long n = 1000000000000000;

                long result = Result.sumXor(n);

                Console.WriteLine(result);

            }
        }
    }
}
