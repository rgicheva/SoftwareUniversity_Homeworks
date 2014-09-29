/*Problem 09.Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */
using System;

class Trapezoids
{
    static void Main()
    {
        float[] arrA = { 5f, 2f, 8.5f, 100f, 0.222f };
        float[] arrB = { 7f, 1f, 4.3f, 200f, 0.333f };
        float[] arrH = { 12f, 33f, 2.7f, 300f, 0.555f };
        float area = 0;
        for (int i = 0; i < arrA.Length; i++)
        {
            area = ((arrA[i] + arrB[i]) / 2) * arrH[i];
            Console.WriteLine("The area of trapezoid with a={0}, b={1} and h={2} is {3}", arrA[i], arrB[i], arrH[i], area);
        }
    }
}
