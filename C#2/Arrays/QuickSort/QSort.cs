﻿﻿using System;
using System.Linq;
using System.Collections;
//Problem 14. Quick sort

//Write a program that sorts an array of strings using the Quick sort algorithm.

class QSort
{

    public static void quicksort(int[] input, int low, int high)
    {
        int pivot_loc = 0;

        if (low < high)
        {
            pivot_loc = partition(input, low, high);
            quicksort(input, low, pivot_loc - 1);
            quicksort(input, pivot_loc + 1, high);
        }

    }

    private static int partition(int[] input, int low, int high)
    {
        int pivot = input[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (input[j] <= pivot)
            {
                i++;
                swap(input, i, j);
            }
        }
        swap(input, i + 1, high);
        return i + 1;
    }



    private static void swap(int[] ar, int a, int b)
    {
        int temp;
        temp = ar[a];
        ar[a] = ar[b];
        ar[b] = temp;
    }


    static void Main()
    {
        // demo array
        //int[] demoArr = Enumerable.Range(-10, 20).ToArray();
        int[] demoArr = new int[15];

        // initialize 
        for (int i = 0; i < 15; i++)
        {
            if ((i & 1) == 0)
            {
                demoArr[i] = i;
            }
            else
            {
                demoArr[i] = -i;
            }
        }

        foreach (int number in demoArr)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine(" - Unsorted array\nSorted: ");

        quicksort(demoArr, 0, 14);

        foreach (int number in demoArr)
        {
            Console.Write(number + " ");
        }

    }
}