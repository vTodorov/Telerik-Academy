﻿using System;

//Problem 14. Decimal to Binary Number
//• Using loops write a program that converts an integer number to its binary
//representation.
//• The input is entered as long. The output should be a variable of type string.
//• Do not use the built-in .NET functionality.

//Examples:
//decimal     binary
//0           0 
//3           11 
//43691       1010101010101011 
//236476736   1110000110000101100101000000 

class Decimal_to_Binary_Number
{
    static void Main()
    {
        Console.Write("Number = ");
        long n = long.Parse(Console.ReadLine());
        string counter = "";

        while (n >= 1)
        {
            counter = (n % 2) + counter;
            n = n / 2;
        }
        
        Console.WriteLine("Number in binary is : " + counter);
    }
}
