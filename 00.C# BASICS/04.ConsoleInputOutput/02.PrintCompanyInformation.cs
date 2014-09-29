//Problem 2. Print Company Information
//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name:");
        string companyName = Console.ReadLine();
        Console.Write("Company Address:");
        string companyAddress = Console.ReadLine();
        Console.Write("Company phone number:");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Company Fax number:");
        string companyFax = Console.ReadLine();
        Console.Write("Company Website:");
        string companySite = Console.ReadLine();
        Console.Write("Manager first name:");
        string managerName = Console.ReadLine();
        Console.Write("Manager last name:");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager Age:");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone number:");
        string managerPhoneNumber = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine(new string('*', 52));
        Console.WriteLine("*{0,25}{1,-25}*", "Company Name:", companyName);
        Console.WriteLine("*{0,25}{1,-25}*", "Company Address:", companyAddress);
        Console.WriteLine("*{0,25}{1,-25}*", "Company phone number:", companyPhoneNumber);
        Console.WriteLine("*{0,25}{1,-25}*","Company fax number:", companyFax);
        Console.WriteLine("*{0,25}{1,-25}*", "Company Website:", companySite);
        Console.WriteLine("*{0,25}{1,-25}*", "Manager first name:", managerName);
        Console.WriteLine("*{0,25}{1,-25}*", "Manager last name:", managerLastName);
        Console.WriteLine("*{0,25}{1,-25}*", "Manager Age:", managerAge);
        Console.WriteLine("*{0,25}{1,-25}*", "Manager phone number:", managerPhoneNumber);
        Console.WriteLine(new string('*', 52));
        Console.WriteLine();
    }
}

