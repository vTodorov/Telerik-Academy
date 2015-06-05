/*
Problem 4. Binary search

Write a program, that reads from the console an array of N integers and an integer K,
sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
*/

using System;

    class BinSearch
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter value for {0} index :",i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());

         //   int index = Array.BinarySearch(arr, k);
         //   int a = 0;

            while (Array.BinarySearch(arr, k) < 0)
            {
                k--;
            }

            Console.WriteLine("largest number in the array which is <= K is"+k);
           
        }
    }


