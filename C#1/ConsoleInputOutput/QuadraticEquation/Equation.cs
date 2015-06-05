/*
 
*/

using System;
class Equation
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double d = Math.Pow(b, 2) - (4 * a * c);

        if (d > 0)
        {
            double x1 = ((-b) - Math.Sqrt(d)) / (2 * a);
            double x2 = ((-b) + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1 = {0} x2 = {1}", x1, x2);
        }
        else if (d == 0)
        {
            double x = (-b) / (2 * a);
            Console.WriteLine("x1 = x2 = " + x);
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}

