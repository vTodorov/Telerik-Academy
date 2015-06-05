/*
Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using 
appropriate primitive data types. Use descriptive names. Print the data at the console.
*/
using System;
class Employee
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        byte age = 50;
        char gender = 'm';
        long personalIdNumber = 8306112507;
        int uniqueEmployeeNumber = 27569999;
        Console.WriteLine("Employee Data:\n First Name: {0}\n Last Name: {1}\n Age: {2}\n Gender: {3}\n Personal ID Number: {4}\n Unique Employee Number: {5}\n", firstName, lastName, age, gender, personalIdNumber, uniqueEmployeeNumber);

    }
}
