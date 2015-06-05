﻿using System;
using System.Numerics;

//Problem 7. Calculate N! / (K! * (N-K)!)
//• In combinatorics, the number of ways to choose  k  different members out 
//of a group of  n  different elements (also known as the number of combinations)
//is calculated by the following formula: "https://cloud.githubusercontent.com/assets/3619393/5626060/89cc780e-958e-11e4-88d2-0e1ff7229768.png"
//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck 
//of 52 cards.• Your task is to write a program that calculates  n! / (k! * (n-k)!)
//for given  n  and  k  (1 < k < n < 100). Try to use only two loops.

//Examples:
//n   k   n! / (k! * (n-k)!)
//3   2   3 
//4   2   6 
//10  6   210 
//52  5   2598960 

class Calculate 
{
    static void Main()
    {
        Console.Write("Enter n: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger nMinusK = n - k;
        BigInteger nMinusKFact = 1;
        
        if (1 < k && k < n && n < 100)
        {
            for (BigInteger i = 1, j = 1; i <= n; i++, j++)
            {
                nFact *= i;
                if (j <= k)
                {
                    kFact *= j;
                }
            }
            for (BigInteger i = 1; i <= n - k; i++)
			{
                nMinusKFact *= i;
			}
            BigInteger result = nFact / (kFact * nMinusKFact);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Wrong Input!");
        }

    }
}
