/* Problem 01. Exchange If Greater
Write an if-statement that takes two integer variables a and b and exchanges their values if the first 
one is greater than the second one. As a result print the values a and b, separated by a space. Examples:
 */

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        float[] firstArr = {5,2,5.5f};
        float[] secondArr = {2,4,4.5f};
        for (int i = 0; i < firstArr.Length; i++)
		{
			if (firstArr[i] > secondArr[i])
	        {
            firstArr[i] = firstArr[i] + secondArr[i];
            secondArr[i] = firstArr[i] - secondArr[i];
            firstArr[i] = firstArr[i] - secondArr[i];
            Console.WriteLine("{0} {1}", firstArr[i], secondArr[i]);
	        }
		}
        
    }
}
