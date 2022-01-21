using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Problem4_SubarrayWithGivenSum_NegativeIntegers
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 4, 20, 3, 10, 5 };
            int[] arr2 = { 10, 2, -2, -20, 10 };
            int[] arr3 = { 7, 6, -1, 4, -3, 3, -20, 10 };
            int[] arr4 = { -10, 0, 2, -2, -20, 10 };
            
            int sum1 = 33;
            int sum2 = -10;
            int sum3 = 10;
            int sum4 = 20;

            Console.WriteLine("Running for 1st Array {  1, 4, 20, 3, 10, 5 } with sum 33");
            findSubArray(arr1, sum1);

            Console.WriteLine("\nRunning for 2nd Array { 10, 2, -2, -20, 10 } with sum -10");
            findSubArray(arr2, sum2);

            Console.WriteLine("\nRunning for 3rd Array { 7, 6, -1, 4, -3, 3, -20, 10 } with sum 10");
            findSubArray(arr3, sum3);

            Console.WriteLine("\nRunning for 4th Array { -10, 0, 2, -2, -20, 10 } with sum 20");
            findSubArray(arr4, sum4);
        }

        static void findSubArray(int[] arr, int sum)
        {
            int n = arr.Length;
            int curr_sum = 0;
            int start = 0;
            int end = -1;

            Dictionary<int, int> myDictionary = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                curr_sum = curr_sum + arr[i];

                if (curr_sum == sum)
                {
                    start = 0;
                    end = i;
                    Console.WriteLine("Sum found between indexes " + start + " and " + end);
                    return;
                }

                if (myDictionary.ContainsKey(curr_sum - sum))
                {
                    start = myDictionary[curr_sum - sum] + 1;
                    end = i;
                    Console.WriteLine("Sum found between indexes " + start + " and " + end);
                    return;
                }

                if (myDictionary.ContainsKey(curr_sum))
                {
                    myDictionary[curr_sum] = i;
                }
                else
                {
                    myDictionary.Add(curr_sum, i);
                }
            }

            if (end == -1)
            {
                Console.WriteLine("No subarray found");
                return;
            }
        }
    }
}




        /* Non-efficient method */

        //static void findSubArray(int[] arr, int sum)
        //{

        //    int n = arr.Length;

        //    for (int i = 0; i < n ; i++)
        //    {
        //        int j = i + 1;
        //        int curSum = arr[i];
        //        while (curSum != sum && j < n-1)
        //        {
        //            curSum = curSum + arr[j];

        //            if (curSum == sum)
        //            {
        //                Console.WriteLine("Sum found between " + "indexes " + i + " and " + j);
        //                return;
        //            }

        //            j++;

        //        }
        //    }
        //    Console.WriteLine("No subarray with given sum exists");

        //}
     


