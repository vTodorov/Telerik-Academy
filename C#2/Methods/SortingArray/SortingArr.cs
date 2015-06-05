/*
Problem 9. Sorting array

Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    class SortingArr
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the lenght of the array: ");
            int arrLenght = int.Parse(Console.ReadLine());

            int[] arr = new int[arrLenght];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter value for index {0} : ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter start index: ");
            int beginIndex = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Max value in the array is : " + MaxValueInArr(arr, beginIndex));

            SortedArr(arr);
            Console.Write("Sorted array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();
            DescendingOrderSort(arr);
            Console.Write("Reversed:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();
        }
        static int MaxValueInArr(int[] arr, int beginIndex)
        {
            int maxValue = 0;
            for (int i = beginIndex; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }
            return maxValue;
        }
        static void SortedArr(int[] arr)
        {
            int tmp = 0;
            int indexOfBiggesValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                indexOfBiggesValue = Array.IndexOf(arr, MaxValueInArr(arr, i));
                tmp = arr[i];
                arr[i] = arr[indexOfBiggesValue];
                arr[indexOfBiggesValue] = tmp;
            }
        }
        static void DescendingOrderSort(int[] arr)
        {
            SortedArr(arr);
            Array.Reverse(arr);
        }

    }
}