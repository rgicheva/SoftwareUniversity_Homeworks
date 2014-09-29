//Problem 4: Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:

using System;

class Rectangles
{
    static void Main()
    {
        float[] width = new float[] { 3.0f, 2.5f, 5.0f };
        int[] height = new int[] { 4, 3, 5};
        for (int i = 0; i < 3; i++)
        {
            Console.Write("The perimeter of rectangular with width={0} and height={1} is: ", width[i], height[i]);
            Console.WriteLine((2*width[i])+(2*height[i]));
        }
        for (int i = 0; i < 3; i++)
        {
            Console.Write("The area of rectangular with width={0} and height={1} is: ", width[i], height[i]);
            Console.WriteLine(width[i]*height[i]);
        }
    }
}

