using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    class Problem10_PrintElementsInDecreasingFrequency
    {
        static void Main10(string[] args)
        {
            //int[] arr = { 2, 5, 2, 8, 5, 6, 8, 8 };
            int[] arr = { 2, 5, 2, 6, -1, 9999999, 5, 8, 8, 8 };

            printElementsPerFreq(arr);

        }
        static void printElementsPerFreq(int[] A)
        {
            int n = A.Length;
            Dictionary<int, int> myDictionary = new Dictionary<int, int>();

            for (int i = 0; i<n; i++)
            {
                if (myDictionary.ContainsKey(A[i]))
                {
                    myDictionary[A[i]] = myDictionary[A[i]] + 1;
                }
                else
                {
                    myDictionary.Add(A[i], 1);
                }
            }

            var sortedDictionary = myDictionary.OrderByDescending(item => item.Value);

            Console.Write("Output Array: {  ");
            foreach (var item in sortedDictionary)
            {
                int i = item.Value;
                
                while (i > 0)
                {
                    Console.Write(item.Key + "  ");
                    i--;
                }
               
            }
            Console.Write("}\n\n");

        }
    }
}
