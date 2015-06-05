/*
Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
*/


using System;
class CompereNumber
{
    static void Main()
    {
        Console.Write("Enter first number : ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number : ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("The bigger number is: " +(firstNumber > secondNumber ? firstNumber : secondNumber));
    }
}


