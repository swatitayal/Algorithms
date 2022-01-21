using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Problem7_FindLEADERSInAnArray
    {
        static void Main7(string[] args)
        {
            int[] Arr1 = { 16, 17, 4, 3, 5, 2 };
            //int[] Arr1 = { 3, 2, 0, -9, -5, -2, -6 };
                        
            findLeaders(Arr1);
        }

        static void findLeaders(int[] Arr)
        {
            int n = Arr.Length;
            List<int> leaders = new List<int>();
            int max = Arr[n - 1];
            leaders.Add(Arr[n - 1]);

            for (int i = (n - 2); i >= 0; i--)
            {
                if (Arr[i] > Arr[i + 1] && Arr[i] > max)
                {
                    max = Arr[i];
                    leaders.Add(Arr[i]);
                }
            }

            for (int i=leaders.Count-1; i>=0; i--)
            {
                Console.Write(leaders[i] + " ");
            }
        }
    }
  }