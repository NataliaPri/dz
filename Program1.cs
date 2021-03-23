using System;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            void BucketSort(int[] A)
            {
                int k = 0;
                int n = A.Length;
                int[][] B = new int[n][];

                for (int i = 0; i < n; i++)
                    //нужно вставить А[i] в масcив B
                    for (int a = 0; a < n; a++)
                        Array.Sort(B[a]);

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < B[i].Length; j++)
                        A[k++] = B[i][j++];
            }
        }
    }
}
