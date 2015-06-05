/*
 Problem 8. Isosceles Triangle

Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©
 */

using System;
using System.Text;
class Triangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyright = '\u00A9';
        Console.WriteLine("    {0}",copyright);
        Console.WriteLine();
        Console.WriteLine("   {0} {0}", copyright);
        Console.WriteLine();
        Console.WriteLine("  {0}   {0}", copyright);
        Console.WriteLine();
        Console.WriteLine(" {0} {0} {0} {0}", copyright);
    }
}

