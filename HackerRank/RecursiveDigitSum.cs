using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class RecursiveDigitSum
    {
        class Result
        {

            /*
             * Complete the 'superDigit' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. STRING n
             *  2. INTEGER k
             */

            public static int superDigit(string n, int k)
            {
                double sum = 0;
                foreach (char c in n)
                {
                    int value = int.Parse(c.ToString());
                    sum = sum + value;
                }
                sum = sum * k;
                while (sum >= 10)
                {
                    sum = superDigit(sum.ToString(), 1);
                }
                return (int)sum;


            }

        }

        public class Solution
        {
            public static void Run()
            {
                string n = "9875";

                int k = 3;

                int result = Result.superDigit(n, k);

                Console.WriteLine(result);
            }
        }

    }
}
