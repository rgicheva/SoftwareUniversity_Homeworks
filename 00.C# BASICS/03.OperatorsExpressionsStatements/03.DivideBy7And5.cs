//Problem 3: Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided 
//(without remainder) by 7 and 5 in the same time. Examples:

using System;

class DivideBy7And5
{
    static void Main()
    {
        int[] numbersArray = new int[] { 3, 0, 5, 7, 35, 140 };
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(((numbersArray[i] % 7) == 0) && ((numbersArray[i] % 5) == 0));
        }
    }
}

