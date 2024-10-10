using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class ClimbingtheLeaderboard
    {
        class Result
        {

            /*
             * Complete the 'climbingLeaderboard' function below.
             *
             * The function is expected to return an INTEGER_ARRAY.
             * The function accepts following parameters:
             *  1. INTEGER_ARRAY ranked
             *  2. INTEGER_ARRAY player
             */

            public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
            {
                //List<int> playerRank = new List<int>();
                //List<int> ranks = new List<int>() {1};
                //int rank = 1;

                //for (int i = 0; i < ranked.Count - 1; i++)
                //{
                //    if (ranked[i] == ranked[i + 1]) 
                //    {
                //        ranks.Add(rank);
                //    }
                //    else if (ranked[i] > ranked[i + 1])
                //    {
                //        rank++;
                //        ranks.Add(rank);
                //    }
                //}

                //for (int i = 0; i < player.Count; i++)
                //{

                //    for (int k = 0; k < ranked.Count; k++)
                //    {
                //        if (player[i] > ranked[k])
                //        {
                //            playerRank.Add(ranks[k]);
                //            break;
                //        }
                //        else if (player[i] == ranked[k])
                //        {
                //            playerRank.Add(ranks[k]);
                //            break;
                //        }

                //        if(k == ranked.Count-1)
                //        {
                //            playerRank.Add(ranks[k]+1);
                //            break;
                //        }

                //    }

                //}
                //return playerRank;




                List<int> playerRank = new List<int>();

                ranked = ranked.Distinct().ToList();

                int rank = ranked.Count - 1;
                for (int i = 0; i < player.Count; i++)
                {
                    while (rank > 0 && player[i] > ranked[rank])
                    {
                        rank--;
                    }
                
                    if (player[i] >= ranked[rank])
                    {
                        playerRank.Add(rank + 1);
                    }
                    else
                    {
                        playerRank.Add(rank + 2);
                    }
                }
                return playerRank;


            }

        }

        public class Solution
        {
            public static void Run()
            {

                //List<int> ranked = new List<int>() { 100, 100, 50, 40, 40, 20, 10 }; // 1 1 2 3 3 4 5

                //List<int> player = new List<int>() { 5, 25, 50, 120 };            
                
                List<int> ranked = new List<int>() { 100, 90, 90, 80, 75, 60 }; // 1 1 2 3 3 4 5

                List<int> player = new List<int>() { 50, 65, 77, 90, 102 };

                List<int> result = Result.climbingLeaderboard(ranked, player);

                Console.WriteLine(String.Join("\n", result));


            }
        }
    }
}
