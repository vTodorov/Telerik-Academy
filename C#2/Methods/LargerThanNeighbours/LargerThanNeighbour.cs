/*
Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
*/
using System;
class LargerThanNeighbour
{
    static void Main()
    {
        Console.Write("Enter the lenght of the array: ");
        int arrLenght = int.Parse(Console.ReadLine());

        int[] arr = new int[arrLenght];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter value for index {0} : ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter position of the element: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("The element of the chosen position is larger than his neighbours: " + IsLargerThanNeighbours(arr, p));
    }
    static bool IsLargerThanNeighbours(int[] arr, int p)
    {
        while (p == 0 || p == arr.Length - 1 || p > arr.Length-1 || p <0)
        {
            Console.Write("At least one neighbourd does not exist or you enter invalid position. Enter another position: ");
            p = int.Parse(Console.ReadLine());
        }

        if (arr[p] > arr[p - 1] && arr[p] > arr[p + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
