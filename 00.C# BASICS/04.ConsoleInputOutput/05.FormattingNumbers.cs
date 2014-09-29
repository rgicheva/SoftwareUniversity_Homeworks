/*Problem 5. Formatting Numbers
Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), 
a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. 
Each column should have a width of 10 characters. The number a should be printed in hexadecimal, 
left aligned; then the number a should be printed in binary form, padded with zeroes,
then the number b should be printed with 2 digits after the decimal point, right aligned; 
the number c should be printed with 3 digits after the decimal point, left aligned. Examples:
*/

using System;

class FormattingNumbers
{
static void Main()
    {
        Console.Write("Please enter a (integer value between 0 and 500):");
        int integerA;
        while (!int.TryParse(Console.ReadLine(), out integerA) || integerA < 0 || integerA > 499) 
        {   
            Console.WriteLine("Invalid input!!!");
        }
        Console.Write("Please enter b:");
        float floatingPointB;
        while (!float.TryParse(Console.ReadLine(), out floatingPointB)) 
        {
            Console.WriteLine("Invalid input!!!");
        }
        Console.Write("Please enter c:");
        float floatingPointC;
        while (!float.TryParse(Console.ReadLine(), out floatingPointC)) 
        {
            Console.WriteLine("Invalid input!!!");
        }
        Console.WriteLine();
        Console.WriteLine(("result").PadLeft(25));
        Console.WriteLine();
        string hack = String.Empty; 
        Console.WriteLine("|{0,-5:X}{1, -10}|{2,5}|{1, -10}{3:F2}|{4,5:0.000}", integerA, hack, Convert.ToString(integerA, 2).PadLeft(10, '0'), floatingPointB,floatingPointC);
        Console.WriteLine();
    }
}

        
    




