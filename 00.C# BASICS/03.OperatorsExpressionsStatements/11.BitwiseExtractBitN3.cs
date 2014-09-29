using System;

    class BitwiseExtractBitN3
    {
        static void Main()
        {
            ushort[] nNumbersArr = { 5, 0, 15, 5343, 62241 };
            int mask = 1 << 3;
            int result;
            for (int i = 0; i < nNumbersArr.Length; i++)
            {
                result = nNumbersArr[i] & mask;
                Console.WriteLine(result >> 3);
            }
        }
    }

