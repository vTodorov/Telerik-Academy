using System;
using System.Numerics;

//Problem 8. Catalan Numbers•
//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula 
//• Write a program to calculate the  nth  Catalan number by given  n  (1 < n < 100). 

//Examples:
//n   Catalan(n)
//0   1 
//5   42 
//10  16796 
//15  9694845 

class Catalan_Numbers
{
    static void Main()
    {
        Console.Write("Enter Number: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        BigInteger nFact = 1;
        BigInteger nX2Fact = 1;
        BigInteger nNa2 = n * n;
        BigInteger nPlus1 = n + 1;
        BigInteger nPlus1Fact = 1;

        if (n >= 0 && n <= 100)
        {

            for (int i = 1; i <= n; i++)
            {
                nFact *= i;
            }

            for (int i = 1; i <= n * 2; i++)
            {
                nX2Fact *= i;
            }

            for (int i = 1; i <= n + 1; i++)
            {
                nPlus1Fact *= i;
            }

            BigInteger result = nX2Fact / (nPlus1Fact * nFact);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Wrong input!");
        }
    }
}
