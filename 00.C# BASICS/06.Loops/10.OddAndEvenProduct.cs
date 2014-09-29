/*
 * You are given n integers (given in a single line, separated by a space). Write a program that 
 * checks whether the product of the odd elements is equal to the product of the even elements. 
 * Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddAndEvenProduct
{
    static void Main()
    {
        //input
        Console.Write("please enter a few space seprated valid integers:");
        string numbersString = Console.ReadLine();
        string[] numbersArray = numbersString.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        //logic output
        int oddProduct = 1;
        int evenProduct = 1;
        for (int i = 0; i < numbersArray.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddProduct *= int.Parse(numbersArray[i]);
            }
            else
            {
                evenProduct *= int.Parse(numbersArray[i]);    
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("product = {0}",evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
    }
}

