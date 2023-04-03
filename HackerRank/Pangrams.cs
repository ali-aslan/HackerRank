using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
   public static class Pangrams
    {
        class Result
        {
            public static string pangrams(string s)
            {
                char[] alp = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

                foreach (var item in alp)
                {
                    if (s.ToUpper().Contains(item))
                        continue;

                    return "not pangram";
                }

                return "pangram";
            }
        }

        public class Solution
        {

         
            public static void Run()
            {
                string np = "We promptly judged antique ivory buckles for the prize";  //not pangram
                string pn = "We promptly judged antique ivory buckles for the next prize"; //pangram

                string result = Result.pangrams(pn);

                Console.WriteLine(result);
            }
        }
    }
}
