using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class DrawingBook
    {
        class Result
        {

            /*
             * Complete the 'pageCount' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. INTEGER n : the number of pages in the book
             *  2. INTEGER p : the page number to turn to
             */

            public static int pageCount(int n, int p)
            {
                //int pageturn = 0; // path 1 

                //if (n - p <= p - 1)//end to page
                //{
                //    for (int i = n; i >= p; i--)
                //    {
                //        if (i == p) return pageturn;

                //        if (i % 2 == 0)
                //            pageturn++;
                //    }

                //}
                //else //beginning to page
                //{

                //    for (int i = 1; i <= p; i++)
                //    {
                //        if (i == p) return pageturn;

                //        if (i % 2 == 1)
                //            pageturn++;
                //    }

                //}



                //return 1111;

                if (n % 2 == 0)
                    return Math.Min(p / 2, (n - p + 1) / 2);
                else
                    return Math.Min(p / 2, (n - p) / 2);


            }

        }

        public class Solution
        {
            public static void Run()
            {


                int n = 6; //59867

                int p = 5; //35733

                int result = Result.pageCount(n, p);

                Console.WriteLine(result);


            }
        }
    }
}
