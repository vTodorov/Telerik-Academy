/*
Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
*/

using System;
class BinSearch
    {
        static void Main()
        {
            Console.Write("Enter sorted numbers separated by comma: ");
            string[] stringArr = Console.ReadLine().Split(',');
            int[] intArr = new int[stringArr.Length];
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = int.Parse(stringArr[i]);
            }

            Array.Sort(intArr);

            Console.Write("Enter number to search: ");
            int number = int.Parse(Console.ReadLine());

            int leftIndex = 0, rightIndex = intArr[intArr.Length - 1], midIndex = 0;

            while (true)
            {
                midIndex = (leftIndex + rightIndex) / 2;

                if (intArr[midIndex] == number)
                {
                    Console.Write(" Number: {0} is on index {1}", number, midIndex);
                    Console.WriteLine();
                    break;
                }
                else if (number > intArr[midIndex])
                {
                    leftIndex = midIndex + 1;

                }
                else if (number < intArr[midIndex])
                {
                    rightIndex = midIndex - 1;
                }
            }
        }
    }

