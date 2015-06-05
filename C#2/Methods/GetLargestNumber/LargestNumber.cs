/*
Problem 2. Get largest number

Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
*/
using System;
    class LargesNumber
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int z = int.Parse(Console.ReadLine());

            int result = (GetMax(x, y));
            int finalResult = GetMax(result, z);
            Console.WriteLine("The largest number is: {0} ", finalResult);
        }
        static int GetMax(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }

