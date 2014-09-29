/*Problem 10. Fibonacci Numbers
Write a program that reads a number n and prints on the console the first n members
of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
Note that you may need to learn how to use loops. Examples:
 */

using System;
using System.Numerics;

class FibonacciNumbers
{
static void Main()
    {
        Console.Write("Length of Fibonacci sequence: ");
        int n = int.Parse(Console.ReadLine());
	    if(n==1) 
        Console.WriteLine(0);
        else
        {
        BigInteger first = 0;
        BigInteger second = 1;
        Console.Write("{0} ", first);
        Console.Write("{0} ", second);
        BigInteger third = 0;
        for (int i = 2; i < n; i++)
        {
            third = first + second;
            Console.Write(third + " ");
            first = second;
            second = third;
        }
        }
    }
}

