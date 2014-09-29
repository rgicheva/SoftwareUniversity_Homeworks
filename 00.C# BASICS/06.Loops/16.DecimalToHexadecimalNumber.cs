/*
 * Using loops write a program that converts an integer number to its hexadecimal representation.
 * The input is entered as long. The output should be a variable of type string. 
 * Do not use the built-in .NET functionality. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long n;
        do
        {
            Console.Write("Please enter a valid integer:");
        } while (!long.TryParse(Console.ReadLine(), out n));
        //logic and output
        string result = "";
        char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        while (n > 0)
        {
            result += digits[n % 16];
            n /= 16;
        }
        //output very stuped way. no time
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[result.Length-i-1]);
        }
        Console.WriteLine();
    }
}

