using System;
using System.Linq;

namespace common_ascending_subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine(common_ascending_subsequence(A, n));

        }

        private static int common_ascending_subsequence(int[] a, int n)
        {
            int[] DP = new int[n];
            for (int i = 0; i < n; i++)
            {
                DP[i] = 1;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (a[j] < a[i] && DP[j] >= DP[i])
                        DP[i] = DP[j] + 1;
                }
            }

            int max = DP[0];

            for (int i = 1; i < n; i++)
            {
                if (DP[i] > max)
                    max = DP[i];
            }
            return max;
        }
    }
}


