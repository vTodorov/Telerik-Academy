﻿/*
Problem 3. Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder)
by 7 and 5 at the same time.
 */

using System;
class Divide
{
    static void Main()
    {
        Console.WriteLine("Enter your number");
        int number = int.Parse(Console.ReadLine());
        if (number % 5 == 0 && number % 7 == 0 && number != 0)
        {
            Console.WriteLine("Your number can divide by 7 and 5 at the same time");
        }
        else
        {
            Console.WriteLine("Your number can't divide by 7 and 5 at the same time");
        }
    }
}

