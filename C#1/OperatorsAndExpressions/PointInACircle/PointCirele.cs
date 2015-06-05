/*
Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2). 
*/


using System;
class PointCirele
{
    static void Main()
    {
        Console.WriteLine("Enter x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y:");
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(2, 2);
        Console.WriteLine(isInCircle);

    }
}
