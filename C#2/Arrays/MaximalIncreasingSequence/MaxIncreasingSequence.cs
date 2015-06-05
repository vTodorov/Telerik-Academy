/*
Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
*/

using System;
class MaxSequence
{
    static void Main()
    {
        Console.WriteLine("Enter sequence like this \"1, 2, 3....n\"");
        string inputString = Console.ReadLine();
        string[] arr = inputString.Split(',');
        int[] inputInt = new int[arr.Length];
        int counter = 0;
        int bestCount = 0;
        int bestCountNumber = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            inputInt[i] = int.Parse(arr[i]);
        }
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (inputInt[i] + 1 == inputInt[i + 1])
            {
                counter++;
            }
            else
            {
                counter = 0;
            }
            if (counter > bestCount)
            {
                bestCount = counter;
                bestCountNumber = inputInt[i+1];
            }
        }
        int q = bestCountNumber - bestCount;
        
        bestCount++;

        for (int i = 0; i < bestCount; i++)
        {
            if (i == bestCount)
            {
                Console.Write("{0}", q);
            }
            else
            {
                Console.Write("{0}, ", q);
            }
            q++;
        }

    }
}

