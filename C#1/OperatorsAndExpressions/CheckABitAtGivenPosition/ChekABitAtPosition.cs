/*
Problem 13. Check a Bit at Given Position

Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
*/

using System;
class ChekABitAtPosition
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integer number : ");
        int numberInDec = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter index : ");
        int index = int.Parse(Console.ReadLine());

        int p = index;
        int n = numberInDec;
        int mask = 1 << p;
        long nAndMask = n & mask;
        long bit = nAndMask >> p;

        if (bit == 1)
        {
            Console.WriteLine("The result is {0} :", true);
        }
        else
        {

            Console.WriteLine("The result is {0} :", false);
        }

    }
}

