using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class TowerBreakers
    {
        class Result
        {

            /*
             * Complete the 'towerBreakers' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. INTEGER n
             *  2. INTEGER m
             */

            public static int towerBreakers(int n, int m)
            {
                if (m == 1 || n % 2 == 0)
                    return 2;
                if (n % 2 == 1)
                    return 1;

                return 99;
            }

        }

        class Solution
        {
            public static void Run()
            {


                int t = 2;



                int n = 2;

                int m = 6;

                int result = Result.towerBreakers(n, m);

                Console.WriteLine(result);



            }
        }
    }
}
