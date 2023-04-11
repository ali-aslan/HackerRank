using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class PrimeDates
    {
        class Result
        {

            /*
             * Complete the 'gridChallenge' function below.
             *
             * The function is expected to return a STRING.
             * The function accepts STRING_ARRAY grid as parameter.
             */

            public static int dateChallenge(DateTime dateOne,DateTime dateTwo)
            {
                int ans = 0;

                while (true)
                {
                    dateOne=dateOne.AddDays(1);

                    string date = string.Concat(dateOne.ToShortDateString().Split('/'));

                    if (int.Parse(date) % 4 == 0 || int.Parse(date) % 7 == 0)
                        ans++;

                    if (dateOne.ToShortDateString() == dateTwo.ToShortDateString())
                        break;
                }

                return ans;
            }

        }

        public class Solution
        {
            public static void Run()
            {

                DateTime dateOne = new DateTime(/*2008, 3, 1, 7, 0, 0*/);
                //DateTime dateTwo = new DateTime(2024, 3, 1, 7, 0, 0);

                DateTime dateTwo = new DateTime();
                //dateTwo = DateTime.Now;

                //dateOne = DateTime.Parse( Console.ReadLine());
                //dateTwo = DateTime.Parse( Console.ReadLine());

                string input = Console.ReadLine();
                string[] divInput = input.Split(' ');

                dateOne = DateTime.Parse(divInput[0]);
                dateTwo = DateTime.Parse(divInput[1]);




                int result = Result.dateChallenge(dateOne, dateTwo);

                Console.WriteLine(result);
            }


        }
    }
}

