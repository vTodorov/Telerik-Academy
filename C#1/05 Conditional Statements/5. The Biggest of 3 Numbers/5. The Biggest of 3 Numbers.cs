using System;

//Problem 5. The Biggest of 3 Numbers
//• Write a program that finds the biggest of three numbers.

//Examples:
//a       b       c       biggest
//5       2       2       5 
//-2      -2      1       1 
//-2      4       3       4 
//0       -2.5    5       5 
//-0.1    -0.5    -1.1    -0.1 

class The_Biggest_of_3_Numbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine("The biggest number is: " + a);
        }
        else if (b > c && b > a)
        {
            Console.WriteLine("The biggest number is: " + b);
        }
        else if (c > b && c > a)
        {
            Console.WriteLine("The biggest number is: " + c);
        }
    }
}

