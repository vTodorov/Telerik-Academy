using System;
using System.Linq;

//Problem 3. Min, Max, Sum and Average of N Numbers
//• Write a program that reads from the console a sequence of  n  integer numbers and returns 
//the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//• The input starts by the number  n  (alone in a line) followed by  n  lines, each holding an integer number.
//• The output is like in the examples below.

//Example 1:
//input       output
//3           min = 1 
//2           max = 5 
//5           sum = 8 
//1           avg = 2.67 

//Example 2:
//input       output
//2           min = -1 
//-1          max = 4 
//4           sum = 3 
//            avg = 1.50 

class Min_Max_Sum_and_Average_of_N_Numbers
{
    static void Main()
    {
        Console.Write("How many numbers you will enter? ");
        int numbers = int.Parse(Console.ReadLine());
        int maxValue = 0;
        int minValue = 0;
        double sum = 0;
        double avg = 0;
        int[] arr = new int[numbers];

        for (int i = 0; i < numbers; i++)
        {
            Console.Write("Pleace enter numer:");
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }

        avg = (double)sum / numbers;
        maxValue = arr.Max();
        minValue = arr.Min();

        Console.WriteLine("Max Value = " + maxValue);
        Console.WriteLine("Min Value = " + minValue);
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("avg = {0:F2} ", avg);
    }
}
