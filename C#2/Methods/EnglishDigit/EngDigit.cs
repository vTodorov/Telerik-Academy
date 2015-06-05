/*
Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.
Examples:

input	output
512	    two
1024	four
12309	nine
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class EngDigit
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            PrintLastDigit();
            Console.Write(LastDigitWord(input));
            Console.WriteLine();
        }
        static string LastDigitWord(string a)
        {
            int numberInt = int.Parse(a);
            while (numberInt > 9 || numberInt < -9)
            {
                numberInt = numberInt % 10;
            }
            switch (Math.Abs(numberInt))
            {
                case 0: return "zero"; break;
                case 1: return "one"; break;
                case 2: return "two"; break;
                case 3: return "three"; break;
                case 4: return "four"; break;
                case 5: return "five"; break;
                case 6: return "six"; break;
                case 7: return "seven"; break;
                case 8: return "eight"; break;
                case 9: return "nine"; break;
                default: return "not valid digit";
                    break;
            }
        }
        static void PrintLastDigit()
        {
            Console.Write("Last digit is: ");

        }
    }
