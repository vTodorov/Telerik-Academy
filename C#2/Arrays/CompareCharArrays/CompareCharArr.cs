/*
Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).
*/

using System;

namespace CompareCharArrays
{
    class CompareCharArr
    {
        static void Main()
        {
            Console.Write("Enter series of chars in the same line: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter series of chars in the same line: ");
            string input2 = Console.ReadLine();
            int counter = 0;

            while (input1.Length != input2.Length)
            {
                Console.WriteLine("Please enter equal count of chars");
                Console.Write("Enter series of chars in the same line: ");
                input1 = Console.ReadLine();
                Console.Write("Enter series of chars in the same line: ");
                input2 = Console.ReadLine();

            }

            foreach (var item in input1)
            {
                if (item == input2[0 + counter])
                {
                    Console.WriteLine("{0} is the same like {1}", item, input2[0 + counter]);
                }
                else
                {
                    Console.WriteLine("{0} isn't the same like {1}", item, input2[0 + counter]);
                }
                counter++;
            }

        }
    }
}

