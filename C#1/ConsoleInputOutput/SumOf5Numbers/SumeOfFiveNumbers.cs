/*
Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
*/
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter numbers");
        string numbers = (Console.ReadLine());
        int sum = 0;

        int[] numbers2 = new int[numbers.Length];
        string[] a = numbers.Split(' ');

        for (int i = 0; i < a.Length; i++)
        {
            numbers2[i] = Int32.Parse(a[i]);
            sum += numbers2[i];
        }
        Console.WriteLine(sum);
    }
}

