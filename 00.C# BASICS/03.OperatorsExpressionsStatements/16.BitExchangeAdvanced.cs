using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        //input
        long[] nArray = { 1140867093, 4294901775, 2369124121, 987654321, 123456789, 33333333333 };
        int[] pArray = { 3, 24, 2, 2, 26, -1 };
        int[] qArray = { 24, 3, 22, 8, 0, 0 };
        int[] kArray = { 3, 3, 10, 11, 7, 33 };
        //logic
        string result;
        long originalN;
        for (int i = 0; i < nArray.Length; i++)
        {
            result = "";
            if (nArray[i] <= uint.MaxValue && (pArray[i] + kArray[i]) < 32)
            {
                if (Math.Abs(qArray[i] - pArray[i]) >= kArray[i])
                {
                    //putting original value to result
                    originalN = nArray[i];
                    //generating mask1
                    int mask1 = 0;
                    for (int j = pArray[i]; j < pArray[i] + kArray[i]; j++)
                    {
                        mask1 <<= 1;
                        mask1 |= (1 << pArray[i]);
                    }
                    //generating mask2
                    int mask2 = 0;
                    for (int j = qArray[i]; j < qArray[i] + kArray[i]; j++)
                    {
                        mask2 <<= 1;
                        mask2 |= (1 << qArray[i]);
                    }
                    //getting the two sets of bits
                    long firstSetOfBits = nArray[i] & mask1;
                    long secondSetOfBits = nArray[i] & mask2;
                    //moving the bits
                    if (pArray[i] < qArray[i])
                    {
                        firstSetOfBits <<= qArray[i] - pArray[i];
                        secondSetOfBits >>= qArray[i] - pArray[i];
                    }
                    else
                    {
                        firstSetOfBits >>= pArray[i] - qArray[i];
                        secondSetOfBits <<= pArray[i] - qArray[i];
                    }
                    //zeroing the slots
                    originalN &= ~mask1;
                    originalN &= ~mask2;
                    //putting the replaced bits
                    originalN |= firstSetOfBits;
                    originalN |= secondSetOfBits;
                    result = Convert.ToString(originalN);
                }
                else
                {
                    result = "overlaping";
                }
            }
            else
            {
                result = "out of range";
            }
            //output
            Console.WriteLine(result);
        }
    }
}

