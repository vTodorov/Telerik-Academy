using System;

//Problem 8. Digit as Word
//• Write a program that asks for a digit (0-9), and depending on the input, shows
//the digit as a word (in English). ◦ Print  “not a digit”  in case of invalid input.
//◦ Use a switch statement.
//Examples:
//d       result
//2       two 
//1       one 
//0       zero 
//5       five 
//-0.1    not a digit 
//hi      not a digit 
//9       nine 
//10      not a digit 

class Digit_as_Word
{
    static void Main()
    {
        Console.Write("Enter a digit: ");
        string digit = (Console.ReadLine());
        switch (digit)
        {
            case "0": Console.WriteLine("ZERO"); break;
            case "1": Console.WriteLine("ONE"); break;
            case "2": Console.WriteLine("TWO"); break;
            case "3": Console.WriteLine("THREE"); break;
            case "4": Console.WriteLine("FOUR"); break;
            case "5": Console.WriteLine("FIVE"); break;
            case "6": Console.WriteLine("SIX"); break;
            case "7": Console.WriteLine("SEVEN"); break;
            case "8": Console.WriteLine("EIGHT"); break;
            case "9": Console.WriteLine("NINE"); break;
            default: Console.WriteLine("not a digit");
                break;
        }
    }
}

