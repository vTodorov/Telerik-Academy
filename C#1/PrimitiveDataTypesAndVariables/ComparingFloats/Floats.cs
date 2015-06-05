/*
Problem 13.* Comparing Floats

Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly
by a == b because of the nature of the floating-point arithmetic.
Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
 */

using System;
class Floats
{
    static void Main()
    {

        Console.WriteLine("Enter the first number");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("a= " + firstNumber);
        Console.WriteLine("Enter the second number");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("b= " + secondNumber);
        double eps = 0.000001;
        double difference = Math.Abs(firstNumber - secondNumber);
        if (difference > eps)
        {
            Console.WriteLine("The difference is too big! The numbers isn`n eual.");
        }
        else
        {
            Console.WriteLine("Nubers are equal");
        }




    }
}

