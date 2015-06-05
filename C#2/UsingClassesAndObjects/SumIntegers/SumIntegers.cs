/*
Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
Example:

input	               output
"43 68 9 23 318"        461
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumIntegers
{
    static void Main(string[] args)
    {
        Console.Write("Enter numbers separated by space: ");
        string input = Console.ReadLine();
        string[] inputStringArr = input.Split(' ');

        int[] arr = new int[inputStringArr.Length];
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(inputStringArr[i]);
            sum += arr[i];
        }
        Console.WriteLine("Sum = "+sum);
        
        
    }
}

