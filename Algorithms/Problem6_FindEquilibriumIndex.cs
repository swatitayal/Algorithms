using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Problem6_FindEquilibriumIndex
    {
        static void Main6(string[] args)
        {
            int[] A = { -7, 1, 5, 2, -4, 3, 0 };
            int[] B = { 2, 4, 5 };
            int[] C = { 2, 7, 5, 4, 5 };

            Console.WriteLine("Running for array { -7, 1, 5, 2, -4, 3, 0 }");
            printResponse(findEquilibrium(A));

            Console.WriteLine("Running for array { 2, 4, 5 }");
            printResponse(findEquilibrium(B));

            Console.WriteLine("Running for array { 2, 7, 5, 4, 5 }");
            printResponse(findEquilibrium(C));

        }

        static int findEquilibrium(int[] A)
        {
            int hi_sum = 0;
            int li_sum = 0;
            int n = A.Length;

            for (int i = 0; i<n; i++)
            {
                hi_sum = hi_sum + A[i];
            }
            
            for (int i = 0; i < n; i++)
            {
                hi_sum = hi_sum - A[i];
                    
                if (li_sum == hi_sum)
                {
                   return i;
                }

                li_sum = li_sum + A[i];

            }

            return -1;

        }

        static void printResponse(int response)
        {
            if (response == -1)
            {
                Console.WriteLine("This array does NOT contain an Equilibrium Index\n");
            }
            else
            {
                Console.WriteLine("This array contains an Equilibrium Index at: " + response + "\n");
            }
        }

    }
}
