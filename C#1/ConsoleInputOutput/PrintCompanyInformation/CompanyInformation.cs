/*
Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
*/


using System;
class CompanyInformation
{
    static void Main()
    {
        //input
        Console.Write("Enter Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter Phone number:");
        string phoneNumber = (Console.ReadLine());
        Console.Write("Enter Fax number(press Enter to skip):");
        string faxNumberString = Console.ReadLine();
        int faxNumberInt;
        Console.Write("Enter Web site:");
        string webSite = Console.ReadLine();
        Console.Write("Enter manager first name:");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager last name:");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter manager age:");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Enter manager phone number:");
        string managerPhoneNumber = (Console.ReadLine());

        // output
        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Addres: " + companyAddress);
        Console.WriteLine("Tel: " + phoneNumber);
        if (int.TryParse(faxNumberString, out faxNumberInt))
        {
            Console.WriteLine("Fax: " + faxNumberInt);
        }
        else
        {
            Console.WriteLine("Fax : (no fax)");
        }
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhoneNumber);








    }
}

