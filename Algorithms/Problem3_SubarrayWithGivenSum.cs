using System;

namespace Algorithms
{
    class Problem3_SubarrayWithGivenSum
    {
        static void Main3(string[] args)
        {
            int[] arr1 = { 1, 4, 20, 3, 10, 5 };
            int[] arr2 = { 1, 4, 0, 0, 3, 10, 5 };
            int[] arr3 = { 1, 4, 0 };
            int[] arr4 = { 2, 5, 8, 9, 1 };

            int sum1 = 33;
            int sum2 = 7;
            int sum3 = 0;
            int sum4 = 10;

            Console.WriteLine("Running for 1st Array { 1, 4, 20, 10, 3, 5, 2 } with sum 33");
            findSubArray(arr1, sum1);

            Console.WriteLine("\nRunning for 2nd Array { 1, 4, 0, 0, 3, 10, 5 } with sum 7");
            findSubArray(arr2, sum2);

            Console.WriteLine("\nRunning for 3rd Array { 1, 4 } with sum 0");
            findSubArray(arr3, sum3);

            Console.WriteLine("\nRunning for 4th Array { 2, 5, 8, 9, 1 } with sum 10");
            findSubArray(arr4, sum4);

        }
        static void findSubArray(int[] arr, int sum)
        {
            int head = 0;
            int curr_sum = 0;
            int n = arr.Length;
            
            for (int i = 0; i<n; i++)
            {
                curr_sum = curr_sum + arr[i];

                while (curr_sum > sum && head < i)
                {
                    curr_sum = curr_sum - arr[head];
                    head++;
                }

                if (curr_sum == sum)
                {
                    Console.WriteLine("Sum found between indexes " + head + " and " + i);
                    return;
                }

            }
            
            Console.WriteLine("No subarray found");
            return;
                
            }
        }
}
