using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public  class PermutingTwoArrays
    {
        class Result
        {

            /*
             * Complete the 'twoArrays' function below.
             *
             * The function is expected to return a STRING.
             * The function accepts following parameters:
             *  1. INTEGER k
             *  2. INTEGER_ARRAY A
             *  3. INTEGER_ARRAY B
             */

            public static string twoArrays(int k, List<int> A, List<int> B)
            {
                A.Sort();
                B.Sort();
                B.Reverse();

                for (int i = 0; i < A.Count; i++)
                {
                    if (A[i] + B[i] >= k)
                        continue;

                    return "NO";

                }

                return "YES";
            }

        }

        public class Solution
        {
            public static void Run()
            {

               
                    int k = 13;

                    List<int> A = new List<int>(){4,12,11,4,9,4,7,1,10,12,10,3,7,13,12,10,4,4,4,3,6,11,13,2,3,7,9,11,8,7,3,9,2,9,8,11,5,1,5,6,9,6,13,3,6,9,2,5,7,1,10,8,13,4,3,9,3,8,11,13,5,3,4,8,4,12,1};

                      List<int> B = new List<int>() {20,12,13,5,8,15,3,15,4,16,11,16,0,18,6,17,6,4,11,22,12,16,7,16,12,13,4,16,18,13,13,5,16,3,6,13,6,16,12,9,8,10,11,19,3,10,14,21,9,15,9,18,10,8,11,11,5,7,15,16,14,15,4,12,14,11,13};

                      string result = Result.twoArrays(k, A, B);

                    Console.WriteLine(result);
                


            }
        }

    }
}
