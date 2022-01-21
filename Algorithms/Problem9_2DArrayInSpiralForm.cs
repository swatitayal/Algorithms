using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Problem9_2DArrayInSpiralForm
    {
        static void Main9(string[] args)
        {
            int[,] A = {    { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 } };

            //int[,] A = {    {1, 2, 3, 4, 5, 6 },
            //                    {7, 8, 9, 10, 11, 12 },
            //                    {13, 14, 15, 16, 17, 18} };

            //int[,] A = {    { 1, 2, 3 },
            //            { 4, 5, 6 },
            //            { 7, 8, 9 },
            //            { 10, 11, 12 },
            //            { 13, 14, 15 },
            //            { 16, 17, 18} };

            //int[,] A = {    { 1, 2, 3, 4, 5 },
            //                { 6, 7, 8, 9, 10 },
            //                { 11, 12, 13, 14, 15 },
            //                { 16, 17, 18,19, 20},
            //                { 21, 22, 23, 24, 25} };

            int iStart = 0;
            int jStart = 0;
            int rowCount = A.GetLength(0);
            int colCount = A.GetLength(1);
            
            printArrayInSpiral(A, iStart, jStart, rowCount, colCount);
            Console.Write("done!!");
        }

        static void printArrayInSpiral(int[,] A, int iStart, int jStart, int rowCount, int colCount)
        {
            int i = iStart;
            int j = jStart;
            int rowLimit = rowCount - 1;
            int colLimit = colCount - 1;
            
            if (iStart > rowLimit && jStart > colLimit)
            {
                return;
            }

            else if(iStart == rowLimit && jStart == colLimit) //print only available element
            {
                Console.Write(A[i, j] + " ");
                return;
            }

            else if (iStart == rowLimit && jStart < colLimit) //print only available row left to right
            {
                while (j <= colLimit)
                {
                    Console.Write(A[i, j] + " ");
                    j++;
                }
                return;
            }

            else if (iStart < rowLimit && jStart == colLimit) //print only available column up to down
            {
                while (i <= rowLimit)
                {
                    Console.Write(A[i, j] + " ");
                    i++;
                }   
                return;
            }

            else if (iStart < rowLimit && jStart < colLimit)
            {
                Console.Write(A[i, j] + " ");
                while (i >= iStart || j >= jStart)
                {
                    if (i == iStart && j < colLimit)  //to print left to right
                    {
                        j++;
                        Console.Write(A[i, j] + " ");
                    }

                    else if (i < rowLimit && j == colLimit)  //to print up to down
                    {
                        i++;
                        Console.Write(A[i, j] + " ");
                    }

                    else if (i == rowLimit && j > jStart)   //to print right to left
                    {
                        j--;
                        Console.Write(A[i, j] + " ");
                    }

                    else if (i > iStart + 1 && j == jStart) //to print down to up
                    {
                        i--;
                        Console.Write(A[i, j] + " ");
                    }

                    else if (i == iStart + 1 && j == jStart)
                    {
                        iStart++;
                        jStart++;

                        rowCount--;
                        colCount--;
                        
                        printArrayInSpiral(A, iStart, jStart, rowCount, colCount);
                        break;
                    }
                }
            }
        }
    }
}


 
