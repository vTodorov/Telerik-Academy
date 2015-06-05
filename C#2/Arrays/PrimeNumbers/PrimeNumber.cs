//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;

class PrimeNumber
{
    static void Main()
    {
        bool[] prime = new bool[100000];// Try with more if you want, but its slow.
        for (int i = 2; i < prime.Length; i++)
        {
            prime[i] = true;
        }

        for (int i = 2; i < prime.Length; i++)
        {
            if (prime[i])
            {
                for (int j = i + 1; j < prime.Length; j++)
                {
                    if (j % i == 0)
                    {
                        prime[j] = false;
                    }
                }
            }
        }

        for (int i = 1; i < prime.Length; i++)
        {
            if (prime[i])
                Console.WriteLine(i);
        }
    }
}