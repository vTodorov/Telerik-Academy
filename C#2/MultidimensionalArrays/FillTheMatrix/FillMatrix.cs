/*
Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:
Example for n=4:

a)			
1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16
 * 
b)
1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13
 * 
c)
7	11	14	16
4	8	12	15
2	5	9	13
1	3	6	10
 
d)
1	12	11	10
2	13	16	9
3	14	15	8
4	5	6	7
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n:");
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];
            int beggin = 1;
            Console.WriteLine("a)");
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    arr[row, col] = beggin;
                    beggin++;
                }

            }

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write("{0,3} ", arr[col, row]);
                }
                Console.WriteLine();
            }
           Console.WriteLine();
            //B
           Console.WriteLine("b)");
                  int odd = n * 2;
            int even = 1;

            for (int col = 0; col < arr.GetLength(0); col++)
            {
                if (col % 2 != 0)
                {
                    for (int row = 0; row < arr.GetLength(1); row++)
                    {
                        arr[row, col] = odd;
                        odd--;
                    }
                    odd = even + n * 2 - 1;
                }
                if (col % 2 == 0)
                {
                    for (int row = 0; row < arr.GetLength(1); row++)
                    {
                        arr[row, col] = even;
                        even++;
                    }
                    even += n;
                }
            }
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write("{0,3} ", arr[row, col]);
                }
                Console.WriteLine();
            }
            //c
            Console.WriteLine("c)");
            int tempC = 1;

            for (int row = n - 1; row >= 0; row--)
            {
                for (int col = 0; col <= n - row - 1; col++)
                {
                    if (col > 0)
                    {
                        arr[row + col, col] = tempC;
                        tempC++;
                    }
                    else
                    {
                        arr[row, col] = tempC;
                        tempC++;
                    }
                }
            }
            for (int col = 1; col < n; col++)
            {
                for (int row = 0; row < n - col; row++)
                {
                    if (row > 0)
                    {
                        arr[row, col + row] = tempC;
                        tempC++;
                    }
                    else
                    {
                        arr[row, col] = tempC;
                        tempC++;
                    }
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,3} ", arr[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}

