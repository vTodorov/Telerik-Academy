/*
 Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
 */

using System;

class AgeAfterYears
{
    static void Main()
    {

        Console.Write("Please enter a birth date like 28.11.2000:\t");
        var bday = DateTime.Parse(Console.ReadLine());
        int age = DateTime.Today.Year - bday.Year;
        Console.WriteLine("You are now {0} years old, you will be {1} years old in 10 years.", age, age + 10);

    }
}

