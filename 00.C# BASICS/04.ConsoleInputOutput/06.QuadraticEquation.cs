//Problem 6. Quadratic Equation
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it 
//(prints its real roots). Examples:
using System;

class QuadraticEquation
{
    static void Main()
    {
        float a;
        float b;
        float c;
        double discriminant = 0;
        double x1;
        double x2;
        Console.Write("Please enter the value of a:");
        while (!float.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Invalid value! Please try again:");
        }

        Console.Write("Please enter the value of b:");
        while (!float.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Invalid value! Please try again:");
        }
        Console.Write("Please enter the value of c:");
        while (!float.TryParse(Console.ReadLine(), out c))
        {
            Console.Write("Invalid value! Please try again:");
        }
            discriminant = Math.Sqrt((Math.Pow(b, 2) - (4 * a * c)));
            Console.WriteLine();
            x1 = (-b - discriminant) / (2 * a);
            x2 = (-b + discriminant) / (2 * a);
            Console.WriteLine("In one quadratic equation if a={0}, b={1} and c={2}, then x1={3} and x2={4}",a,b, c, x1, x2);
            Console.WriteLine();
    }
}

