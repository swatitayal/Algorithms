using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Problem2_MissingIntegerInList
    {
        static void Main2(string[] args)
        {
            int[] Arr = { 2, 4, 5, 3 };
            //int[] Arr = { 3, 9, 8, 2, 5, 1, 10, 4, 7, 11 };

            findMissingElement(Arr);
        }

        static void findMissingElement(int[] Arr)
        {
            int n = Arr.Length + 1;              
            int total = n * (n + 1) / 2;
            int sum = 0;
            int missingElement;

            for (int i = 0; i< n-1; i++)
            {
                sum = sum + Arr[i];
            }

            missingElement = total - sum;
            Console.WriteLine("The missing element from this array is: " + missingElement);
        }
    }
}
