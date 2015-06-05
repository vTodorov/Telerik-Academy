/*
Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name),
available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account 
using the appropriate data types and descriptive names.
*/
using System;
class BankAccData
{
    static void Main()
    {
        string firstName = "Ivan" ;
        string middleName = "Ivanov";
        string lastName ="Ivanov";
        string clientNames = firstName + " " + middleName + " " + lastName;
        decimal accBalance = 444444444m;
        string bankName = "First Investment Bank";
        string iban = "BG80 BNBG 9661 1020 3456 78";
        long creditCardNumber1 = 5555555555554444;
        long creditCardNumber2 = 5555555555554445;
        long creditCardNumber3 = 5555555555554446;
        Console.WriteLine("Client Names: {0} \n Account balance: {1}\n Bank: {2}\n IBAN: {3}\n Credit card numer: {4}\n Credit card numer: {5}\n Credit card numer: {6}", clientNames, accBalance, bankName, iban, creditCardNumber1, creditCardNumber2, creditCardNumber3);        
    }
}

