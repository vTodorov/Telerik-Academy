﻿/*
Problem 6. First larger than neighbours
Write a method that returns the index of the first element
in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.
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

        Console.WriteLine("The first element larger than it`s neighbours is : " + IsLargerThanNeighbours(arr));
    }
    static int IsLargerThanNeighbours(int[] arr)
    {
        for (int i = 1; i < arr.Length - 1; i++)
        {


            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                return i;
            }
        }
        return -1;
    }
}