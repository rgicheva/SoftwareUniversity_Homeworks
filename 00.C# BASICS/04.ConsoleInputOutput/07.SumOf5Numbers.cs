/*Problem 07. Sum of 5 Numbers
Write a program that enters 5 numbers (given in a single line, separated by a space), 
calculates and prints their sum. Examples:
 */

using System;

class SumOf5Numbers
{
    static void Main()
    {
        float[] nArray = new float[5];
        float sum=0;
        bool flag = false;
        float n;
        //input with validation
        do
        {
            Console.Write("Please enter 5 numbers space separated (example 1 2 3 4 5):");
            string numbersString = Console.ReadLine();
            string[] nStringArray = numbersString.Split(' ');
            for (int i = 0; i < 5; i++)
            {
                if (float.TryParse(nStringArray[i], out n))
                {
                    sum += n;
                    flag = false;
                }
                else
                {
                    flag = true;
                    break;
                }
            }
        } while (flag);
        //output
        Console.WriteLine("The sum of the numbers is: {0}", sum);
    }
}

