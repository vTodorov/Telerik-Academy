/*
Problem 12. Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p.
*/
using System;


class Extractbit
{
    static void Main()
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
        Console.WriteLine("The value of the current position is {0}", bit);
    }

}