using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class NewYearChaos
    {
        class Result
        {

            //public static void minimumBribes(List<int> q)
            //{
            //    List<int> orjQueue = Enumerable.Range(1, q.Count).ToList();
            //    int num = 0;

            //    for (int i = 0; i < q.Count; i++)
            //    {

            //        if (q[i] != orjQueue[i])
            //        {
            //            if ((orjQueue.IndexOf(q[i]) - q.IndexOf(q[i])) > 2)
            //            {
            //                Console.WriteLine("Too chaotic");
            //                num = -1;
            //                break;
            //            }
            //            else
            //            {
            //                num += (orjQueue.IndexOf(q[i]) - q.IndexOf(q[i]));
            //                orjQueue.RemoveAt(orjQueue.IndexOf(q[i]));
            //                orjQueue.Insert(q.IndexOf(q[i]), q[i]);

            //            }

            //        }

            //    }

            //    if (num != -1)
            //        Console.WriteLine(num);

            //}

            public static bool IsOrdered(List<int> q)
            {
                for (int i = 0; i < q.Count - 1; i++)
                {
                    if (q[i] > q[i + 1])
                        return false;
                }
                return true;
            }

            public static void minimumBribes(List<int> q)
            {
                int minBribes = 0;
                List<int> nChanges = new List<int>(new int[q.Count]);

                while (!IsOrdered(q))
                {
                    for (int i = 0; i < q.Count - 1; i++)
                    {
                        if (q[i] > q[i + 1])
                        {
                            nChanges[q[i] - 1]++;
                            if (nChanges[q[i] - 1] > 2)
                            {
                                Console.WriteLine("Too chaotic");
                                return;
                            }
                            int temp = q[i];
                            q[i] = q[i + 1];
                            q[i + 1] = temp;
                            minBribes++;
                        }
                    }
                }

                Console.WriteLine(minBribes);
            }

        }



        public class Solution
        {
            public static void Run()
            {
                List<int> q = new List<int>() { 1, 2, 5, 3, 7, 8, 6, 4 };
                //List<int> q = new List<int>() { 5, 1, 2, 3, 7, 8, 6, 4 };

                Result.minimumBribes(q);
            }
        }
    }
}
