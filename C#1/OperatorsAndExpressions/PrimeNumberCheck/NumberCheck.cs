/*
Problem 8. Prime Number Check

Write an expression that checks if given positive integer number n (n = 100) is prime
(i.e. it is divisible without remainder only to itself and 1). 
*/
using System;
class NumberCheck
{
    static void Main()
    {
         Console.WriteLine("Enter your integer number");
        int number = int.Parse(Console.ReadLine());
        if (number <= 1 || number > 100)
            Console.WriteLine(false);
        else
        {
            if ((number == 2 || number == 3 || number == 5 || number == 7) ||
                (number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


    }
}

