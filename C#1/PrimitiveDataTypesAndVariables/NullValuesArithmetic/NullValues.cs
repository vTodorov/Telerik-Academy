/*
Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
 */
using System;
class NullValues
{
    static void Main()
    {

        double? nullDouble = null;
        int? nullInt = null;
        Console.WriteLine("Null double:" + nullDouble);
        Console.WriteLine("Null int:" + nullInt);
        nullDouble = nullDouble + 10;
        nullInt = nullInt + 10;
        Console.WriteLine("Null double + number:" + nullDouble);
        Console.WriteLine("Null int + number:" + nullInt);
        nullDouble = 10.5;
        nullInt = 5;
        Console.WriteLine("Number:" + " " + nullDouble);
        Console.WriteLine("Number:" + " " +nullInt);


    }
}

