using System;

//Problem 16. Decimal to Hexadecimal Number
//• Using loops write a program that converts an integer number to its
//hexadecimal representation.
//• The input is entered as long. The output should be a variable of type string.
//• Do not use the built-in .NET functionality.

//Examples:
//decimal         hexadecimal
//254             FE 
//6883            1AE3 
//338583669684    4ED528CBB4 

class Decimal_to_Hexadecimal_Number
{
    static void Main()
    {
        Console.Write("Enter number in decimal");
        long decNumber = long.Parse(Console.ReadLine());
        string hexNumber = "";
        if (decNumber == 0)
        {
            hexNumber = "0";
        }
        else
        {
            while (decNumber > 0)
            {
                long remain = decNumber % 16;
                decNumber /= 16;
                switch (remain)
                {
                    case 10: hexNumber = "A" + hexNumber; break;
                    case 11: hexNumber = "B" + hexNumber; break;
                    case 12: hexNumber = "C" + hexNumber; break;
                    case 13: hexNumber = "D" + hexNumber; break;
                    case 14: hexNumber = "E" + hexNumber; break;
                    case 15: hexNumber = "F" + hexNumber; break;
                    default: hexNumber = remain + hexNumber; break;
                }
            }
        }
        Console.WriteLine("hexadecimal number is : " + hexNumber);
    }
}
