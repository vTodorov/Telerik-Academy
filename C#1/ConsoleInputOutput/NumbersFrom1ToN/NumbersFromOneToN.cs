/*
Problem 8. Numbers from 1 to n

Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
 */

using System;
class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Enter number:");

        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(i + 1);
        }

    }
}

