/*
Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
*/

using System;
class CirelePerimeterArea
{
    static void Main()
    {
        Console.Write("Enter radius of the cirele: ");
        double radius = double.Parse(Console.ReadLine());

        double p = 2 * Math.PI * radius;
        double s = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("The perimeter of the cirele is: {0:F2}. The  area of the cirele is: {1:F2}", p, s);

    }
}

