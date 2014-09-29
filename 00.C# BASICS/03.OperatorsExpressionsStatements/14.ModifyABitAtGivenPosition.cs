/*Problem 14. Modify a Bit at Given Position
We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the
value v at the position p from the binary representation of n while preserving all other bits in n. Examples:
*/
using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        ushort[] nNumbersArr = { 5, 0, 15, 5343, 62241 };
        int[] pArray = { 2, 9, 1, 7, 11 };
        int[] vArray = {0,1,1,0,0};
        int result;
        int mask;
        for (int i = 0; i < nNumbersArr.Length; i++)
        {
            mask = 1 << pArray[i];
            result = nNumbersArr[i] & mask;
            if (vArray[i] == 0)
            {
                Console.WriteLine(nNumbersArr[i] & ~mask);
            }
            else
            {
                Console.WriteLine(nNumbersArr[i] | mask);
            }
        }
    }
}

