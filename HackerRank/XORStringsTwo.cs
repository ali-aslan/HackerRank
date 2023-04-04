using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class XORStringsTwo
    {
        class Result
        {



            public static string Answer(string a, string b)
            {
                char[] ans = new char[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == b[i])
                        ans[i] = '0';
                    else
                        ans[i] = '1';
                }
              
                return string.Concat(ans);
           

            }

        }

        public class Solution
        {
            public static void Run()
            {

                string a  = "10101";

                string b  = "00101";

                string result = Result.Answer(a, b);

                Console.WriteLine(result);

            }
        }
    }
}
