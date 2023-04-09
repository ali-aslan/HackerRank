using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class CaesarCipher
    {
        class Result
        {

            /*
             * Complete the 'caesarCipher' function below.
             *
             * The function is expected to return a STRING.
             * The function accepts following parameters:
             *  1. STRING s
             *  2. INTEGER k
             */

            public static string caesarCipher(string s, int k)
            {
                k = k % 26;
                string alphabet =    "abcdefghijklmnopqrstuvwxyz";
                string alphabetOrj = "abcdefghijklmnopqrstuvwxyz";
                string res = "";
                alphabet += alphabet.Substring(0, k);
                alphabet = alphabet.Substring(k);

                int upperCaseIndex = 0;

                for (int i = 0; i < s.Length; i++)
                {

                    if (alphabetOrj.IndexOf(s[i]) != -1 || char.IsUpper(s[i]) == true )
                    {
                        if (char.IsUpper(s[i]) == true)
                        {
                            upperCaseIndex = s.IndexOf(s[i]);
                            res += char.ToUpper(alphabet[alphabetOrj.IndexOf(char.ToLower(s[i]))]);

                        }
                        else
                        {
                            res += alphabet[alphabetOrj.IndexOf(s[i])];
                        }

                    }  
                    else
                    {
               
                        res += s[i];
                    }
                }
                return res;
            }

        }

        public class Solution
        {
            public static void Run()
            {
                string s = "middle-Outz";

                int k = 2;

                string result = Result.caesarCipher(s, k);

                Console.WriteLine(result);

              
            }
        }

    }
}
