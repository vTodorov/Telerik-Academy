/*
Problem 4. Triangle surface

Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("\t\tMenu");
        Console.WriteLine();
        Console.WriteLine("Calculate the surface of a triangle by given:");
        Console.WriteLine();
        Console.WriteLine("Press 1 for Side and an altitude to it");
        Console.WriteLine("Press 2 for Three sides");
        Console.WriteLine("Presa 3 for Two sides and an angle between them");
        Console.WriteLine();
        string menuChoise = Console.ReadLine();

        Console.Clear();

        if (menuChoise=="1")
        {
            Console.Write("Enter side: ");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Enter an altitude to it");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("Surface= "+SurfaceBySideH(side,h));
        }
        else if (menuChoise=="2")
        {
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter side c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Surface= "+SurfaceByThreeSides(a,b,c));
        }
        else if (menuChoise == "3")
        {
            Console.Write("Enter side : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter angle between them: ");
            double angle = double.Parse(Console.ReadLine());

            Console.WriteLine("Surface= " + SurfaceBySidesAndAngle(a, b, angle));
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid choise! Try again.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Main();
        }
    }
    static double SurfaceBySideH(double side, double h)
    {
        double surface = (side * h) / 2;
        return surface;
    }
    static double SurfaceByThreeSides(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return s;
    }
    static double SurfaceBySidesAndAngle(double a , double b, double angle)
    {
        angle = angle * Math.PI / 180.0;
        double s = ((a * b) * Math.Sin(angle)) / 2.0;
        return s;
    }


}

