using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class PalindromeIndex
    {
        class Result
        {

            /*
             * Complete the 'palindromeIndex' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts STRING s as parameter.
             */

            public static int palindromeIndex(string s)
            {
                int max_index = s.Length / 2;

                for (int i = 0; i < max_index; i++)
                {
                    if (s[i] != s[s.Length - 1 - i])
                    {
                        if (s.Substring(i + 1, 2) == Rev(s.Substring((s.Length - 1 - i) - 1, 2)))
                            return i;
                        else
                            return (s.Length - 1 - i);

                        return i;
                    }

                    
                }

                return -1;
            }

            static string Rev(string str)
            {
                string reverse = "";
                int length = 0;
                length = str.Length - 1;
                while (length >= 0)
                {
                    reverse = reverse += str[length];
                    length--;
                }
                return reverse;

            }

        }

        public class Solution
        {
            public static void Run()
            {
                string s = "aaaaaaa";//bcbc

                int result = Result.palindromeIndex(s);

                Console.WriteLine(result);
            }
        }
    }
}
