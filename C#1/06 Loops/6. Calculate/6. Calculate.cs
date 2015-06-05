using System;

//Problem 6. Calculate N! / K!
//• Write a program that calculates  n! / k!  for given  n  and  k  (1 < k < n < 100).
//• Use only one loop.

//Examples:
//n       k       n! / k!
//5       2       60 
//6       5       6 
//8       3       6720 

class Calculate
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        int nFact = 1;
        int kFact = 1;

        if (1 < k && k < n && n < 100)
        {
            for (int i = 1, j = 1; i <= n; i++, j++)
            {
                nFact *= i;
                if (j <= k)
                {
                    kFact *= j;
                }
            }
            int sum = 0;
            sum = nFact / kFact;
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("Wrong Input!");
        }

    }
}
