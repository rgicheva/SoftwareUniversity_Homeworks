//Problem 5. Third Digit is 7?
//Write an expression that checks for given integer if 
//its third digit from right-to-left is 7. Examples:
using System;

class ThirdDigitIs7
{
    static void Main()
    {
        int[] digit7Arr = new int[] {5, 701, 9703, 877, 777877, 9999799};
        int result = 0;
        for (int i = 0; i < digit7Arr.Length; i++)
			{
                result = digit7Arr[i] / 100;
                result = result % 10;
                Console.WriteLine(result == 7);
			}
    }
}

