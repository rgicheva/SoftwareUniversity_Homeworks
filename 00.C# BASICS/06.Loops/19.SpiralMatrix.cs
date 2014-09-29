/*
 * Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
 * and prints a matrix holding the numbers from
 * 1 to n*n in the form of square spiral like in the examples below.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //input and setup
        System.Console.SetWindowSize(100, 30);
        Console.WriteLine("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.Clear();
        //logic
        int[,] matrix = new int[n, n];
        int r = 0;
        int c = 0;
        int val = 1;

        if (n > 0 && n < 21)
        {
            while (val <= n * n)
            {
                while (c < matrix.GetLength(0) && matrix[c, r] == 0)
                {
                    matrix[r, c++] = val;
                    val++;
                }
                c--;
                r++;
                while (r < matrix.GetLength(1) && matrix[r, c] == 0)
                {
                    matrix[r++, c] = val;
                    val++;
                }
                r--;
                c--;
                while (c >= 0 && matrix[r, c] == 0)
                {
                    matrix[r, c--] = val;
                    val++;
                }
                c++;
                r--;
                while (r >= 0 && matrix[r, c] == 0)
                {
                    matrix[r--, c] = val;
                    val++;
                }
                c++;
                r++;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j * 5, i * 2);
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Too big to print!");
        }
    }
}

