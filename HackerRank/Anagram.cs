using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class Anagram
    {
        class Result
        {

            /*
             * Complete the 'anagram' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts STRING s as parameter.
             */

            public static int anagram(string s)
            {
                if (s.Length % 2 != 0)
                    return -1;

                int halfLength = s.Length / 2;
                string s1 = "";
                string s2 = "";

                for (int i = 0; i < s.Length; i++)
                {
                    if (i < halfLength)
                        s1 += s[i];
                    else
                        s2 += s[i];
                }

                for (int x = 0; x < s1.Length; x++)
                {
                    for (int y = 0; y < s2.Length; y++)
                    {
                        if (s1[x] == s2[y])
                        {
                            s2 = s2.Remove(y, 1);
                            break;
                        }

                    }
                }
                return s2.Length;
            }

        }

        public class Solution
        {
            public static void Run()
            {
                    string s = "xaxbbbxx";

                    int result = Result.anagram(s);

                    Console.WriteLine(result);
 
            }
        }
    }
}
