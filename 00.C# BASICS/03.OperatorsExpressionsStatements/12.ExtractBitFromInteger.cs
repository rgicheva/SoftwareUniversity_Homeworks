//Problem 12. Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p. Examples:

using System;

class ExtractBitFromInteger
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
            Console.WriteLine(result >> pArray[i]);

        }
    }
}

