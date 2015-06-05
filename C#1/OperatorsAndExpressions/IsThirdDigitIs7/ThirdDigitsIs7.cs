/*
Problem 5. Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7.
*/

using System;
class ThirdDigitsIs7
{
    static void Main()
    {
        Console.WriteLine("Pleace enter the number.");
        int number = int.Parse(Console.ReadLine());
        if (number > 100)
        {
            number /= 100;
            bool thirdDigit = (number % 10)  == 7;
            Console.WriteLine("Third digit = 7 : " + thirdDigit);
        }
        else
        {
            Console.WriteLine("Your have to enter at least 3 digit number");
        }
    }
}

