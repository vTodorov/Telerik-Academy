/*
Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.
*/

using System;
class CompareArr
{
    static void Main()
    {
        Console.Write("Pleace enter lenght of the first array: ");
        int firstArrLenght = int.Parse(Console.ReadLine());
        int[] firstArr = new int[firstArrLenght];

        Console.Write("Pleace enter lenght of the second array: ");
        int secondArrLenght = int.Parse(Console.ReadLine());
        int[] secondArr = new int[secondArrLenght];

        if (firstArr.Length > secondArr.Length || secondArr.Length > firstArr.Length)
        {
            Console.WriteLine("Wrong input! The two arrays have a different lenght. Try again.");
            Main();
        }
        else
        {
            Console.Clear();
            for (int i = 0; i < firstArr.Length; i++)
            {
                Console.Write("Enter value for first array: ");
                firstArr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < secondArr.Length; i++)
            {
                Console.Write("Enter value for second array: ");
                secondArr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] > secondArr[i])
                {
                    Console.WriteLine("{0} > {1}", firstArr[i], secondArr[i]);
                }
                else if (firstArr[i] < secondArr[i])
                {
                    Console.WriteLine("{0} > {1}", secondArr[i], firstArr[i]);
                }
                else if (firstArr[i] == secondArr[i])
                {
                    Console.WriteLine("{0} = {1}", secondArr[i], firstArr[i]);
                }
            }
        }
    }
}
