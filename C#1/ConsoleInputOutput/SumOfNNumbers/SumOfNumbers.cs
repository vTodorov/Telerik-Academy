﻿/*
Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
*/

using System;
class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers you will enter: ");
        double numberOfNumbers = double.Parse(Console.ReadLine());

        double counter = 0;
        double a = 0;

        for (
            int i = 0; i < numberOfNumbers; i++)
        {
            a = double.Parse(Console.ReadLine());
            counter = counter + a;

        }
        Console.WriteLine(counter);
    }
}