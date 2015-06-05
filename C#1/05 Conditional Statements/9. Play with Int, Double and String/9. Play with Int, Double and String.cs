using System;

//Problem 9. Play with Int, Double and String
//• Write a program that, depending on the user’s choice, inputs an  int ,  double
//or  string  variable. ◦ If the variable is  int  or  double , the program increases it by one.
//◦ If the variable is a  string , the program appends  *  at the end.
//• Print the result at the console. Use switch statement.

//Example 1:
//program                         user
//Please choose a type:  
//1 --> int  
//2 --> double                    3 
//3 --> string  

//Please enter a string:          hello 
//hello*  

//Example 2:
//program                         user
//Please choose a type:  
//1 --> int  
//2 --> double                    2 
//3 --> string  

//Please enter a double:          1.5 
//2.5 

class Play_with_Int_Double_and_String
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("");
        Console.WriteLine("Press 1 for int.");
        Console.WriteLine("Press 2 for double.");
        Console.WriteLine("Press 3 for string.");
        Console.WriteLine("");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.Write("Pleace enter int: ");
                int choiceOne = int.Parse(Console.ReadLine());
                Console.WriteLine(choiceOne + 1); break;
            case 2: Console.Write("Pleace enter double: ");
                double choiceTwo = double.Parse(Console.ReadLine());
                Console.WriteLine(choiceTwo + 1); break;
            case 3: Console.Write("Pleace enter your string: ");
                string choiceThree = Console.ReadLine();
                Console.WriteLine(choiceThree + "*"); break;

            default: Console.WriteLine("Wrong choice!");
                break;
        }
    }
}

