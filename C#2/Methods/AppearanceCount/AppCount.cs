/*
Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly. 
*/
using System;
    class AppCount
    {
        static void Main()
        {
            Console.Write("Enter length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter value for {0} index: ",i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your number is found {0} times",NumberCounter(arr));
        }
        static int NumberCounter(int[] numbers)
        {
            Console.Write("Enter number to search for: ");
            int a = int.Parse(Console.ReadLine());
            int counter = 0;
            foreach (var number in numbers)
            {
                if (number==a)
                {
                    counter++;
                }
            }
            return counter;
        }
    }

