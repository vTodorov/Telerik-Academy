/*
Problem 14.* Print the ASCII Table

Find online more information about ASCII (American Standard Code for Information Interchange) 
and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
 */



using System;
using System.Text;
class AsciiPrint
{
    static void Main()
    {
        Console.OutputEncoding = ASCIIEncoding.ASCII;
        for (int i = 30; i < 256; i++) //skipping the unreadable signs
        {
            Console.WriteLine((char)i);
        }
    }
}

