/*
 * Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomizeTheNumbers1N
{
    static void Main()
    {
        //input
        int n;
        do
        {
            Console.Write("Please enter how many numbers you need:");
        } while (!int.TryParse(Console.ReadLine(), out n));
        //logic and output
        int[] usedNumbers = new int[n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            int randNum = rand.Next(n+1);
            while(usedNumbers.Contains(randNum))
            {
                randNum = rand.Next(n+1);
            }
            usedNumbers[i] = randNum;
            Console.Write(randNum+" ");
        }
        Console.WriteLine();
    }
}

