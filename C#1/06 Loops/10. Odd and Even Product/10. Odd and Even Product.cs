using System;

//Problem 10. Odd and Even Product
//• You are given  n  integers (given in a single line, separated by a space).
//• Write a program that checks whether the product of the odd elements is equal
//to the product of the even elements.
//• Elements are counted from  1  to  n , so the first element is odd, the second 
//is even, etc.

//Examples:
//numbers             result
//2 1 1 6 3           yes 
//product = 6  

//3 10 4 6 5 1        yes 
//product = 60  

//4 3 2 5 2           no 
//odd_product = 16  
//even_product = 15 

class Odd_and_Even_Product
{
    static void Main()
    {
        Console.Write("Please enter n numbers separeted by space: ");
        string stringNumbers = "1 " + Console.ReadLine();
        string[] numbers = stringNumbers.Split(' ');
        int productOdd = 1, productEven = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                productOdd *= int.Parse(numbers[i]);
            }
            else
            {
                productEven *= int.Parse(numbers[i]);
            }
        }

        if (productOdd == productEven)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
