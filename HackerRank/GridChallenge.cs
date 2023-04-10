using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class GridChallenge
    {
        class Result
        {

            /*
             * Complete the 'gridChallenge' function below.
             *
             * The function is expected to return a STRING.
             * The function accepts STRING_ARRAY grid as parameter.
             */

            public static string gridChallenge(List<string> grid)
            {

                //// path 1 but without gap bc about that not working 
                //string alphabet = "abcdefghijklmnopqrstuvwxyz";
                //for (int k = 0; k < grid.Count; k++)
                //{

                //    for (int i = 0; i < grid[k].Length; i++)
                //    {
                //        Console.WriteLine("item: " + grid[k] + " i: " + i);
                //        if (grid[k].Contains(alphabet[i+k* grid[k].Length]))
                //        {
                //            continue;
                //        }
                //        else
                //            return "NO";

                //    }

                //}

                //return "YES";


                for (int index = 0; index < grid.Count; index++)
                {
                    var sortedStr = string.Concat(grid[index].OrderBy(c => c));
                    grid[index] = sortedStr;
                }

                for (int row = 0; row < grid.First().Length; row++)
                {
                    for (int column = 0; column < grid.Count - 1; column++)
                    {
                        if (grid[column][row] > grid[column + 1][row])
                            return "NO";
                    }
                }
                return "YES";

            }

        }

        public class Solution
        {
            public static void Run()
            {
              

                    //List<string> grid = new List<string>() { "ebacd", "fghij", "olmkn", "trpqs","xywuv" }; //yes
                    List<string> grid_2 = new List<string>() { "abc", "lmp", "qrt", "trpqs","xywuv" };
                    List<string> grid_3 = new List<string>() { "mpxz", "abcd", "olmkn", "trpqs","xywuv" };
                    List<string> grid_4 = new List<string>() { "abc", "hjk", "mpq", "rtv", "xywuv" };

                    string result = Result.gridChallenge(grid_3);

                    Console.WriteLine(result);
                }

 
            }
        }

    }

