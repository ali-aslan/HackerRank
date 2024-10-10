using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class BetweenTwoSets
    {

        class Result
        {

            /*
             * Complete the 'getTotalX' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. INTEGER_ARRAY a
             *  2. INTEGER_ARRAY b
             */

            public static int getTotalX(List<int> a, List<int> b)
            {
                int total = 0;
                int number = a.Max();

                Enumerable.Range(number, b.Min())
                    .ToList()
                    .ForEach(n =>
                    {
                        if (a.All(e => number % e == 0 || e % number == 0)
                            && b.All(e => number % e == 0 || e % number == 0))
                            total++;

                        number++;
                    });

                return total;
            }
        }

        public class Solution
        {
            public static void Run()
            {
                List<int> arr = new List<int>() { 2, 6 };

                List<int> brr = new List<int>() { 24, 36 };

                int total = Result.getTotalX(arr, brr);

                Console.WriteLine(total);
            }
        }
    }
}
