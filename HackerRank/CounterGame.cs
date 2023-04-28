using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class CounterGame
    {
        class Result
        {

            /*
             * Complete the 'counterGame' function below.
             *
             * The function is expected to return a STRING.
             * The function accepts LONG_INTEGER n as parameter.
             */

            public static string counterGame(long n)
            {
                if (n <= 3) return "Louise";
                long turns = 0;
                double nearest = (Math.Log(n) / Math.Log(2));

                while (!(nearest == Math.Floor(nearest)))
                {
                    turns++;
                    n = n - (long)Math.Pow(2, Math.Floor(nearest));
                    nearest = (Math.Log(n) / Math.Log(2));
                }


                turns += (long)nearest;

                if (turns % 2 == 0)
                {
                    return "Richard";
                }
                return "Louise";
            }

        }


        public class Solution
        {
            public static void Run()
            {
                long n = 6;

                string result = Result.counterGame(n);

                Console.WriteLine(result);


            }
        }

    }


}

