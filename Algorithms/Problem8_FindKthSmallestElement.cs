using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Problem8_FindKthSmallestElement
    {
        static void Main8(string[] args)
        {
            int[] A = { 7, 10, 4, 3, 20, 15 };
            int k = 1;

            int response = findKthElement(A, k);
            Console.Write("\n The " + k + "th smallest element is: " + A[response] + "\n\n");
        }

        static int findKthElement(int[] A, int k)
        {
            int end = A.Length - 1;
            int start = 0;
            int pos = 0;

            if (k > start && k <= end)
            {
                pos = partition(A, start, end);
                
            }

            while (pos != k-1)
            {
                if (pos > k-1)
                {
                    end = pos-1;
                    pos = partition(A, start, end);
                }

                else
                {
                    start = pos + 1;
                    pos = partition(A, start, end);
                }
            }

            return pos;
        }

        static int partition(int[] A, int start, int end)
        {
            int pivot = A[end];
            int i = start;
            int temp = 0;

            for (int j = start; j < end; j++)
            {
                if (A[j] < pivot)
                {
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;

                    i++;
                }
            }
            temp = A[i];
            A[i] = pivot;
            A[end] = temp;

            Console.Write("\n Resultant array: " );
            for (int l = start; l <= end; l++)
            {
                Console.Write(A[l] + " ");
            }
            Console.Write("\n Index returned: " + i + "\n\n");
            return i;
        }
        
    }
}
