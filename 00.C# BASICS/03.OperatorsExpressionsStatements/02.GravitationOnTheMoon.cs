//Problem 2: Gravitation on the Moon
//The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates 
//the weight of a man on the moon by a given weight on the Earth. Examples:

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        float[] weight = new float[] { 86.0f, 74.6f, 53.7f };
        for (int i = 0; i < 3; i++)
        {
           Console.WriteLine("{0:0.000}", (weight[i] * 0.17f)); 
        }
        
    }
}

