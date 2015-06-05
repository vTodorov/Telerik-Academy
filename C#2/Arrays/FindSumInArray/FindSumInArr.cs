/*
Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).
Example:

array	                 S    result
4, 3, 1, 4, 2, 5, 8 |	11	| 4, 2, 5 
*/


using System;
class FindSumInArr
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
        int sum = 0;
        Console.Write("Enter s: ");
        int s = int.Parse(Console.ReadLine());
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                sum += arr[j];
                if (sum == s)
                {
                    for (int k = i; k <= j; k++)
                    {
                        if (k == j)
                        {
                            Console.Write(arr[k]);
                        }
                        else
                        {
                            Console.Write(arr[k] + " ,");
                        }
                    }
                    Console.WriteLine();
                    sum = 0;
                }
            }
            sum = 0;
        }
    }
}

