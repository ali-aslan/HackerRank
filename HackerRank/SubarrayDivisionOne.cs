using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class SubarrayDivisionOne
    {
        class Result
        {

            /*
             * Complete the 'birthday' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. INTEGER_ARRAY s
             *  2. INTEGER d
             *  3. INTEGER m
             */

            public static int birthday(List<int> s, int d, int m)
            {
                int div = 0;
                // way 1;
                //List<int> z = new List<int>();

                //for (int k = 0; k < s.Count; k++)
                //{
                //    z = s.Skip(k).Take(m).ToList();
                //    if (z.Count != m) continue;
                //    else if (z.Sum() == d) div++;

                //}

                //way 2
                int sum = 0;
                for (int i = 0; i <= s.Count-m; i++)
                {
                    sum = 0;
                    for (int k = i; k < m+i; k++)
                    {
                        Console.WriteLine("i:" + i + "k:" + k);
                        sum += s[k];

                    }
                    if (sum == d) div++;

                }

                return div;

            }

        }

        public class Solution
        {
            public static void Run()
            {

                //List<int> s = new List<int>() { 2, 2, 1, 3, 2 };

                //int d = 4;

                //int m = 2;

                List<int> s = new List<int>() {4};

                int d = 4;

                int m = 1;

                int result = Result.birthday(s, d, m);

                Console.WriteLine(result);

            }
        }
    }
}
