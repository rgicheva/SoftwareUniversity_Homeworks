/*
 * Using loops write a program that converts a binary integer number to its decimal form. The input
 * is entered as string. The output should be a   * variable of type long. Do not use the built-in
 * .NET functionality
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToDecimalNumber
{
    static void Main()
    {
        //input
        string binaryString;
        Console.Write("Please enter a valid integer in binary format:");
        binaryString = Console.ReadLine();
      
        //logic and output
        long result = 0;
        for (int i = binaryString.Length-1; i >= 0; i--)
        {
            if (binaryString[i] == '1')
            {
                result += (long) Math.Pow(2,binaryString.Length - i -1);
            }
        }
        Console.WriteLine(result);
        Console.WriteLine();
    }
}

