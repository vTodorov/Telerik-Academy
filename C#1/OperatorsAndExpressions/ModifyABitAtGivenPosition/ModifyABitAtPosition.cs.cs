/*
Problem 14. Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p
from the binary representation of n while preserving all other bits in n.
*/
using System;
class ModifyABitAtPosition
{
    static void Main()
    {
        Console.WriteLine("Enter your number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit 0 or 1");
        int bitValue = int.Parse(Console.ReadLine());

        while (bitValue != 0 && bitValue != 1)
        {
            Console.WriteLine("Enter bit 0 or 1");
            bitValue = int.Parse(Console.ReadLine());
        }

        int bitAtPosition = (number >> position) & 1;

        if (bitAtPosition != bitValue)
        {
            number ^= 1 << position;
        }

        Console.WriteLine("The result is " + number);

    }
}

