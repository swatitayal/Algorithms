using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Problem1_LargestSumContiguousArray
    {
        static void Main1(string[] args)
        {
            int[] A = { -2, -3, 4, -1, -2, 1, 5, -3 };
            int[] B = { -3, 1, -8, 12, 0, -3, 5, -9, 4 };
            int[] C = { 2, 3, -8, -1, 2, 4, -2, -3 };
            int[] D = { 2, 3, -8, -1, 2, 4, -2, -3, -15, 10 };

            Console.WriteLine("\nRunning for Array: { -2, -3, 4, -1, -2, 1, 5, -3 }\n");
            maxSubarraySum(A);

            Console.WriteLine("\nRunning for Array: { -3, 1, -8, 12, 0, -3, 5, -9, 4 }\n");
            maxSubarraySum(B);

            Console.WriteLine("\nRunning for Array: { 2, 3, -8, -1, 2, 4, -2, -3 }\n");
            maxSubarraySum(C);

            Console.WriteLine("\nRunning for Array: { 2, 3, -8, -1, 2, 4, -2, -3, -15, 10 }\n");
            maxSubarraySum(D);

        }

        static void maxSubarraySum(int[] A)
        {
            int n = A.Length;
            int local_max = A[0];
            int global_max = A[0];
            int start = 0;
            int global_start = 0;
            int global_end = 0;

            for (int i = 1; i < n; i++)
            {
                if (A[i] > (A[i] + local_max))
                {
                    local_max = A[i];
                    start = i;
                }
                else
                {
                    local_max = A[i] + local_max;
                    
                }

                if (local_max > global_max)
                {
                    global_start = start;
                    global_max = local_max;
                    global_end = i;
                }
            }

            Console.Write("The maximum sum of the contiguous Array { " + A[global_start]);
            for (int i = global_start+1; i <= global_end; i++)
            {
                Console.Write(", " + A[i]);
            }
            Console.Write(" } is:: " + global_max + "\n\n\n");
        }

    } 
}
