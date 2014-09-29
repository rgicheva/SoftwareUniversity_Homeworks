//Problem 13. Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position p 
//(counting from 0, starting from the right) in given integer number n has value of 1. Examples:

using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        ushort[] nNumbersArr = {5,0,15,5343,62241};
        int[] pArray = {2,9,1,7,11};
        int result;
        int mask;
        for (int i = 0; i < nNumbersArr.Length; i++)
        {
        mask = 1 << pArray[i];
        result = nNumbersArr[i] & mask;
        Console.WriteLine((result >> pArray[i]) == 1);
        }
    }
}
