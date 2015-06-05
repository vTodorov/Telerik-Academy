/*
Problem 9. Frequent number

Write a program that finds the most frequent number in an array.
Example:

input	                                        result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3  |	 4 (5 times)
*/

using System;
class FrequentNum
{
    static void Main()
    {
        Console.Write("Please write numbers separated by comma (like tihs: 2, 3, -6, -1, 2,...,n): ");
        string[] stringArray = Console.ReadLine().Split(',');
        int[] arr = new int[stringArray.Length];

        for (int i = 0; i < stringArray.Length; i++)
        {
            arr[i] = int.Parse(stringArray[i]);
        }
        int counter = 0;
        int bestCount = 0;
        int bestCountNumber = int.MinValue;

        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[i]==arr[j])
                {
                    counter++;
                }
                if (counter>bestCount)
                {
                    bestCount = counter;
                    bestCountNumber = arr[i];
                }
            }
            counter = 0;
        }
        Console.WriteLine("Number:{0} ({1} times)",bestCountNumber,bestCount);
    }
}

