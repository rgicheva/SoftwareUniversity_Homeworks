//Problem 6. Four-Digit Number
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0. Examples:

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter a 4 digit number:");
        int fourDigitNumber = int.Parse(Console.ReadLine());
        int a = (fourDigitNumber / 1000) % 10;
        int b = (fourDigitNumber / 100) % 10;
        int c = (fourDigitNumber / 10) % 10;
        int d = fourDigitNumber % 10;
        int sum = a + b + c + d;
        Console.WriteLine("Sum of the {0}+{1}+{2}+{3} is {4}", a, b, c, d, sum);
        Console.WriteLine("The number {0} in reversed order is {1}{2}{3}{4}:", fourDigitNumber, d, c, b, a);
        Console.WriteLine("If we put the last number in front of the number {0}, we will get: {1}{2}{3}{4}", fourDigitNumber, d,a,b,c);
        Console.WriteLine("If we exchanged the second and the third digits of the number {0} we will get: {1}{2}{3}{4}", fourDigitNumber,a, c, b, d );
    }
}

