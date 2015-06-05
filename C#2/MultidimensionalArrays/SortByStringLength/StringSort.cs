/*
Problem 5. Sort by string length

You are given an array of strings.
Write a method that sorts the array by the length of its elements (the number of characters composing them). 
*/

using System;
class StringSort
{
    static void Main()
    {

        Console.Write("How many strings you will compare? ");
        int arrCount = int.Parse(Console.ReadLine());

        if (arrCount <= 0)
        {
            Console.WriteLine("invalid value. Try again.");
            Main();
        }
        else
        {
            string[] arr = new string[arrCount];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter string: ");
                arr[i] = Console.ReadLine();
            }

            Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
            Console.Clear();
            int place = 1;
            Console.WriteLine("Sorted strings:");
            foreach (string item in arr)
            {
                Console.Write("{0}: ", place);
                Console.WriteLine(item);
                place++;
            }
        }
    }

}

