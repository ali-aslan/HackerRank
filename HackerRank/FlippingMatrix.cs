using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class FlippingMatrix
    {
        class Result
        {

            public static int flippingMatrix(List<List<int>> matrix, int zz)
            {
                int[] arrStore = new int[4];
                List<int> result = new List<int>();

                for (int i = 0; i < zz; i++)
                    for (int k = 0; k < zz; k++)
                    {
                        arrStore[0] = matrix[i][k];
                        arrStore[1] = matrix[2 * zz - 1 - i][k];
                        arrStore[2] = matrix[i][2 * zz - 1 - k];
                        arrStore[3] = matrix[2 * zz - 1 - i][2 * zz - 1 - k];

                        result.Add(Max(arrStore));

                    }
                return result.Sum();

            }

            public static int Max(int[] arr)
            {
                int a = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > a)
                        a = arr[i];
                }

                return a;
            }

        }

        public class Solution
        {
            public static void Run()
            {

                List<List<int>> matrix = new List<List<int>>();

                int q;


                int result = Result.flippingMatrix(matrix, q);

                Console.WriteLine(result);



            }


        }
    }
