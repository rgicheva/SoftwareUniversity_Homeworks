//Problem 8. Prime Number Check
//Write an expression that checks if given positive integer number n (n ≤ 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1). Examples:

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        bool isPrime;
        int primeNumberCandidate;
        int maxDivider;
        int[] primeArray = new int[] { 1, 2, 3, 4, 9, 97, 51, -3, 0 };
        for (int i = 0; i < primeArray.Length; i++)
        {
            isPrime = true;
            maxDivider = (int)Math.Sqrt(primeArray[i]);
            if (primeArray[i] > 1)
            {
                for (int j = 2; j <= maxDivider; j++)
                {
                    if (primeArray[i]%j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            else
            {
                isPrime = false;
            }
            Console.WriteLine(isPrime);
        }
    }
}

