/*
Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.
*/


using System;
class FourDigitN
{
    static void Main()
    {
        Console.WriteLine("Enter four digit number");
        int digit = int.Parse(Console.ReadLine());
        int a = (digit / 1000) % 10;
        int b = (digit / 100) % 10;
        int c = (digit / 10) % 10;
        int d = digit % 10;

        if (a != 0 && digit <= 9999 && digit >=1000)
        {
            int sum = a + b + c + d;
            Console.WriteLine("Sum of the digits is: " + sum);
            Console.WriteLine("Reversed number is: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Last digit in front: {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", a, c, b, d);
        }
        else
        {
            Console.WriteLine("The first digit can't be 0 or you try to enter different from 4 digits number");
        }




    }
}

