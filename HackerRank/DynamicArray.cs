using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class DynamicArray
    {
        class Result
        {

            /*
             * Complete the 'dynamicArray' function below.
             *
             * The function is expected to return an INTEGER_ARRAY.
             * The function accepts following parameters:
             *  1. INTEGER n
             *  2. 2D_INTEGER_ARRAY queries
             */

            public static List<int> dynamicArray(int n, List<List<int>> queries)
            {
                /// path 1 
                //List<int> listValue = new List<int>();
                //List<List<int>> twoDList = new List<List<int>>();
                //for (int i = 0; i < n; i++)
                //{
                //    twoDList.Add(new List<int>());
                //}

                //foreach (List<int> listItem in queries)
                //{
                //    int x = listItem[1];
                //    int lastvalue = listValue.Count == 0 ? 0 : listValue[listValue.Count - 1];
                //    int index = (x ^ lastvalue) % n;
                //    if (listItem[0] == 1)
                //    {
                //        twoDList[index].Add(listItem[2]);
                //    }
                //    else
                //    {
                //        listValue.Add(twoDList[index][listItem[2] % twoDList[index].Count]);
                //    }
                //}
                //return listValue;

                List<int> ans = new List<int>();
                List<List<int>> seq = new List<List<int>>();
                int lastAns = 0;

                for (int i = 0; i < n; i++)
                {
                    seq.Add(new List<int>());
                }

                foreach (var item in queries)
                {
                    int index = ((item[1] ^ lastAns) % n);

                    if (item[0] == 1)
                    {
                        seq[index].Add(item[2]);

                    }
                    else
                    {
                        int y = item[2];
                        int size = seq[index].Count;

                        lastAns = seq[index][y % size];
                        ans.Add(lastAns);
                    }

                }

                return ans;

            }

        }

        public class Solution
        {
            public static void Run()
            {



                int n = 2;



                List<List<int>> queries = new List<List<int>>();

                queries.Add(new List<int>() { 1, 0, 5 });
                queries.Add(new List<int>() { 1, 1, 7 });
                queries.Add(new List<int>() { 1, 0, 3 });
                queries.Add(new List<int>() { 2, 1, 0 });
                queries.Add(new List<int>() { 2, 1, 1 });



                List<int> result = Result.dynamicArray(n, queries);

                Console.WriteLine(String.Join("\n", result));

            }
        }
    }
}
