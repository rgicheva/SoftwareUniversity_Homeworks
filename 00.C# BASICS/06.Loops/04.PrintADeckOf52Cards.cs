/*
 * Write a program that generates and prints all possible cards from a standard deck of 52 cards 
 * (without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦).
 * The card faces should start from 2 to A.  * Print each card face in its four possible suits: 
 * clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintADeckOf52Cards
{
    static void Main()
    {
        //hardcoded input
        string[] cardRanks = {"2","3","4","5","6","7","8","9","10","J","D","K","A"};
        char[] cardSuits = { '\u2663', '\u2666', '\u2665', '\u2660'};
        //logic and output
        //Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 0; i < cardRanks.Length; i++)
        {
            for (int j = 0; j < cardSuits.Length; j++)
            {
                if(j== 1 || j==2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0,3}{1,-3} ", cardRanks[i], cardSuits[j]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("{0,3}{1,-3} ",cardRanks[i], cardSuits[j] );
                }
            }
            Console.WriteLine();
        }
    }
}
