using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class SherlockandArray
    {
        class Result
        {

            public static string balancedSums(List<int> arr)
            {
                var totalSum = 0;
                var runningSum = 0;
                for (var i = 0; i < arr.Count; i++)
                {
                    totalSum += arr[i];
                }

                for (var i = 0; i < arr.Count; i++)
                {
                    if (runningSum == totalSum - runningSum - arr[i])
                        return "YES";
                    runningSum += arr[i];
                }
                return "NO";




            }

        }

        public class Solution
        {
            public static void Run()
            {




                List<int> arr = new List<int>() { 1, 2, 3, 3 };

                string result = Result.balancedSums(arr);

                Console.WriteLine(result);


            }
        }

    }
}
