using System;

class EmployeeData
{
    static void Main()
    {
        //No imput check. Please input valid values
        Console.Write("Please enter your first name:");
        string firstName = Console.ReadLine();
        Console.Write("Please enter your last name:");
        string lastName = Console.ReadLine();
        Console.Write("Please enter your age:");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Please enter your gender (m/f):");
        char gender = char.Parse(Console.ReadLine());
        Console.Write("Please enter your personal ID number (e.g. 8306112507):");
        int idNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter your unique employee number (e.g. 27560000):");
        int uniqueEmployeeNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("\nFirst name: {0}\nLast name: {1}\nAge: {2}\nGender: {3} \nID Number: {4} \nUnique Employee Number: {5}", firstName, lastName, age, gender,idNumber,uniqueEmployeeNumber);
    }
}

