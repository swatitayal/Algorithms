using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Problem5_SortAnArrayOf0s_1s_2s
    {
        static void Main5(string[] args)
        {
            int[] A = { 0, 1, 2, 0, 1, 2 };
            int[] B = { 0, 1, 1, 0, 1, 2, 1, 3, 0, 0, 0, 1 };

            Console.WriteLine("Running for 1st Array { 0, 1, 2, 0, 1, 2 }");
            sortAsc(A);

            Console.WriteLine("Running for 2nd Array { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 }");
            sortAsc(B);
        }

        static void sortAsc (int[] A)
        {
            int n = A.Length;
            int count0s = 0;
            int count1s = 0;
            int count2s = 0;

            for (int i = 0; i<n; i++)           //Counting # of 0s, 1s & 2s
            {
                if (A[i] == 0)
                {
                    count0s++;
                }
                else if (A[i] == 1)
                {
                    count1s++;
                }
                else if (A[i] == 2)
                {
                    count2s++;
                }
                else
                {
                    Console.WriteLine("Invalid Array!!");
                    return;
                }
            }


            for (int i = 0; i< count0s; i++)        //Updating the array
            {
                A[i] = 0;
            }
            for (int i = count0s; i < (count0s+ count1s); i++)
            {
                A[i] = 1;
            }
            for (int i = (count0s + count1s); i < n; i++)
            {
                A[i] = 2;
            }


            Console.Write("The sorted array is: { ");     //Printing the array
            Console.Write(A[0]);
            for (int i = 1; i < n; i++)
            {
                Console.Write(", " + A[i]);
            }
            Console.Write("}\n\n");
        }
    }
}
