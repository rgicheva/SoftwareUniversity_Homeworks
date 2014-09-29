/*Problem 15. * Bits Exchange
Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. Examples:
*/

using System;

class BitsExchange
{
    static void Main()
    {
        //input
        uint[] nArray = {1140867093,255406592,4294901775,5351,2369124121};
        
        //logic
        for (int i = 0; i < nArray.Length; i++)
        {
            uint result = nArray[i];
            uint mask1 = 7 << 3;
            uint mask2 = 7 << 24;

            //take bit 3,4,5 and 24,25,26
            uint bits345 = nArray[i] & mask1;
            uint bits2456 = nArray[i] & mask2;

            //put bits in position
            bits345 <<= 21;
            bits2456 >>= 21;

            //place zeros in bits 3,4,5 and 24,25,26
            result = ~mask1 & result;
            result = ~mask2 & result;

            //place bits in position
            result |= bits345;
            result |= bits2456;

            // output
            Console.WriteLine(result);
        }
    }
}

