using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class TheBombermanGame
    {
        class Result
        {

            /*
             * Complete the 'bomberMan' function below.
             *
             * The function is expected to return a STRING_ARRAY.
             * The function accepts following parameters:
             *  1. INTEGER n
             *  2. STRING_ARRAY grid
             */

            //public static List<string> bomberMan(int n, List<string> grid)
            //{
            //    List<string> NewGrid = new List<string>();

            //    Console.WriteLine(String.Join("\n", grid));

            //    Console.WriteLine("***********");


            //    if (n < 2)
            //    {
            //        return grid;
            //    }
            //    else if (n % 2 == 0)
            //    {
            //        for (int i = 0; i < grid.Count; i++)
            //        {
            //            string str = "";
            //            for (int a = 0; a < grid[i].Length; a++)
            //            {

            //                str += "O";

            //            }

            //            NewGrid.Add(str);
            //        }

            //        return NewGrid;
            //    }
            //    else
            //    {

            //        char[][] ch = new char[grid.Count][];
            //        for (int i = 0; i < grid.Count; i++)
            //            ch[i] = new char[grid[i].Length];


            //        for (int i = 0; i < grid.Count; i++)
            //        {

            //            for (int a = 0; a < grid[i].Length; a++)
            //            {

            //                if (grid[i][a] == 'O')
            //                {
            //                    if (grid[i][a] == 'O' && i == 0)
            //                        continue;

            //                    if (grid[i][a] == 'O' && a != 0)
            //                        ch[i][a - 1] = '.';

            //                    ch[i - 1][a] = '.';
            //                    ch[i][a] = '.';

            //                    if (i < grid.Count - 1)
            //                        ch[i + 1][a] = '.';




            //                    if (a < grid[i].Length - 1)
            //                    {
            //                        if (grid[i][a] == 'O' && grid[i][a + 1] != 'O')
            //                        {
            //                            ch[i][a + 1] = '.';
            //                            a++;
            //                        }

            //                    }

            //                }
            //                else
            //                {
            //                    if (ch[i][a] != '.')
            //                        ch[i][a] = 'O';
            //                }
            //            }
            //        }
            //        for (int i = 0; i < grid.Count; i++)
            //        {
            //            string str = new string(ch[i]);
            //            NewGrid.Add(str);
            //        }
            //    }

            //    return NewGrid;
            //}


            public static List<string> BomberMan(int n, List<string> grid)
            {
                if (n < 2) return grid;

                string fullRow = new string('O', grid[0].Length);
                List<string> fullGrid = Enumerable.Range(0, grid.Count).Select(i => fullRow).ToList();
                grid = DoBoom(fullGrid, grid);
                List<string> grid2 = DoBoom(fullGrid, grid);

                return n % 2 == 0 ? fullGrid : n % 4 == 1 ? grid2 : grid;
            }

            private static List<string> DoBoom(List<string> fullGrid, List<string> grid)
            {
                int length = grid[0].Length;
                int height = grid.Count;

                List<StringBuilder> builders = fullGrid.Select(s => new StringBuilder(s)).ToList();

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (grid[i][j] == 'O')
                        {
                            builders[i][j] = '.';
                            if (j != 0) builders[i][j - 1] = '.';
                            if (j < length - 1) builders[i][j + 1] = '.';
                            if (i != 0) builders[i - 1][j] = '.';
                            if (i < height - 1) builders[i + 1][j] = '.';
                        }
                    }
                }

                return builders.Select(sb => sb.ToString()).ToList();
            }



        }



        public class Solution
        {
            public static void Run()
            {

                int n = 3;

                List<string> grid = new List<string>() { ".......", "...O...", "....O..", ".......", "OO.....", "OO....." };

                List<string> result = Result.BomberMan(n, grid);

                Console.WriteLine(String.Join("\n", result));


            }
        }

    }
}
