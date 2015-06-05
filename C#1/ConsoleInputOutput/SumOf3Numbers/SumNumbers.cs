/*
Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.

*/

using System;
class SumNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("The sum of numbers is " + (firstNumber + secondNumber + thirdNumber));

    }
}

