/*
Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.
Example:

input	                              result
2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2, -1, 6, 4 
*/

using System;
class MaxSum
{
    static void Main()
    {
      
        Console.Write("Please write numbers separated by comma (like tihs: 2,3,-6,-1,2,...,n): ");
        string[] stringArray = Console.ReadLine().Split(',');
        int[] arr = new int[stringArray.Length];

        for (int i = 0; i < stringArray.Length; i++)
        {
            arr[i] = int.Parse(stringArray[i]);
        }

        int indexStart = 0;
        int indexBestStart = 0;
        int indexEnd = 0;
        int sum = 0;
        int bestSum = int.MinValue;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            if (sum<=0)
            {
                indexStart = i+1;
                sum = 0;
            }
            if (sum > bestSum)
            {
                bestSum = sum;
                indexEnd = i;
                indexBestStart = indexStart;
            }
        }
        for (int i = indexStart; i <= indexEnd; i++)
        {
            Console.Write(arr[i] + (i != indexEnd ? ", " : ""));
        }
        Console.WriteLine();
    }
}

