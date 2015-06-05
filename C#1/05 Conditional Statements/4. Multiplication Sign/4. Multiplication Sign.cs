using System;

//Problem 4. Multiplication Sign
//• Write a program that shows the sign (+, - or 0) of the product of three real numbers,
//without calculating it. ◦ Use a sequence of  if  operators.

//Examples:
//a       b       c       result
//5       2       2       + 
//-2      -2      1       + 
//-2      4       3       - 
//0       -2.5    4       0 
//-1      -0.5    -5.1    - 

class Multiplication_Sign
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        if ((a * b) * c > 0)
        {
            Console.WriteLine("+");
        }
        else if ((a * b) * c < 0)
        {
            Console.WriteLine("-");
        }
        else if ((a * b) * c == 0)
        {
            Console.WriteLine("0");

        }

    }
}

