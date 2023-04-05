using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class FizzBuzz
    {
        class Result
        {
            public static void fizzBuzz(int n)
            {
                for (int i = 1; i <= n; i++)
                {

                    if (i % 3 == 0 && i % 5 == 0)
                        Console.WriteLine("FizzBuzz");
                    else if (i % 3 == 0)
                        Console.WriteLine("Fizz");
                    else if (i % 5 == 0)
                        Console.WriteLine("Buzz");
                    else
                        Console.WriteLine(i);

                }
            }
        }

        public class Solution
        {
            public static void Run()
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                Result.fizzBuzz(n);
            }
        }
    }
}
