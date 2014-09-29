﻿//Problem 3. Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 
//2 digits after the decimal point. Examples:

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter radius of a circle: r=");
        double radius;
        while (!double.TryParse(Console.ReadLine(), out radius))
        {
            Console.Write("Invalid value! Please try again:");
        }
        double perimeter = 2 * (Math.PI) * radius;
        double area = Math.PI * (radius * radius);
        Console.WriteLine("The perimeter of the circle is: {0}", Math.Round(perimeter, 2));
        Console.WriteLine("The area of the circle is: {0}", Math.Round(area, 2));
    }
}

