/*
 * Using loops write a program that converts a hexadecimal integer number to its decimal form. 
 * The input is entered as string. The output should be a variable of type long. 
 * Do not use the built-in .NET functionality. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        //input
        string hexa;
        Console.Write("Please enter decimal number in hexa format:");
        hexa = Console.ReadLine();
        //logic and output
        long result = 0;
        char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        for (int i = 0; i < hexa.Length; i++)
        {
            result += Array.IndexOf(digits, hexa[i]) * Convert.ToInt64(Math.Pow(16,hexa.Length-i -1));
        }
        Console.WriteLine(result);
    }
}

