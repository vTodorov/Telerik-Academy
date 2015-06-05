using System;

//Problem 6. The Biggest of Five Numbers
//• Write a program that finds the biggest of five numbers by using only five if statements.

//Examples:
//a       b       c       d       e       biggest
//5       2       2       4       1       5 
//-2      -22     1       0       0       1 
//-2      4       3       2       0       4 
//0       -2.5    0       5       5       5 
//-3      -0.5    -1.1    -2      -0.1    -0.1 

class The_Biggest_of_Five_Numbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        double e = double.Parse(Console.ReadLine());

        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine("The biggest number is: " + a);
        }
        else if (b >= c && b >= a && b >= d && b >= e)
        {
            Console.WriteLine("The biggest number is: " + b);
        }
        else if (c >= b && c >= a && c >= d && c >= e)
        {
            Console.WriteLine("The biggest number is: " + c);
        }
        else if (d >= a && d >= b && d >= c && d >= e)
        {
            Console.WriteLine("The biggest number is: " + d);
        }
        else if (e >= a && e >= b && e >= c && e >= d)
        {
            Console.WriteLine("The biggest number is: " + e);
        }
    }
}

