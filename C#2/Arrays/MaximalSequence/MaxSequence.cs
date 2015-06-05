/*
Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
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
            if (inputInt[i] == inputInt[i + 1])
            {
                counter++;
                bestCountNumber = inputInt[i];
            }
            else
            {
                counter = 0;
            }
            if (counter > bestCount)
            {
                bestCount = counter;
            }
        }
        bestCount++;
     //   bestCountNumber = bestCountNumber - '0';

       
        for (int i = 0; i < bestCount; i++)
        {
            if (i==bestCount)
            {
                Console.Write("{0}", bestCountNumber);
            }
            else
            {
                Console.Write("{0}, ", bestCountNumber);
            }
           
           
        }
        
    }
}

