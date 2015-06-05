/*
Problem 9. Exchange Variable Values

Declare two integer variables a and b and assign them with 5 and 10 and after that
exchange their values by using some programming logic.
Print the variable values before and after the exchange.
 */

using System;
class VariableExchange
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Nubmers before exchange: \n a={0} \n b={1}\n", a, b);
        a = 10;
        b = 20;
        Console.WriteLine("Nubmers after exchange: \n a={0} \n b={1}\n", a, b);
    }
}

