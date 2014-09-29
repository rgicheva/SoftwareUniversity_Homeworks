//Problem 10. Point Inside a Circle & Outside of a Rectangle
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
//and out of the rectangle R(top=1, left=-1, width=6, height=2). Examples:

using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        //circle information
        float radius = 1.5f;
        float centerX = 1;
        float centerY = 1;
        //rectangle information
        int tLeftCornerX = -1;
        int tLeftCornerY = 1;
        int rectHeight = 2;
        int rectWidth = 6;
        bool isInTheCircle;
        bool isInTheRectangle;
        //points coordinates
        float[] arrayX = { 1, 2.5f, 0, 2.5f, 2, 4, 2.5f, 2, 1, -100 };
        float[] arrayY = {2, 2, 1, 1, 0, 0, 1.5f, 1.5f, 2.5f, -100};
        float deltaX = 0;
        float deltaY = 0;
        double deltaR = 0;
        for (int i = 0; i < arrayX.Length; i++)
        {
            //In the Circle
            deltaX = centerX - arrayX[i];
            deltaY = centerY - arrayY[i];
            deltaR = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2)); //pitagorova teorema
            isInTheCircle = deltaR <= radius;
            //Outside Rectangle
            isInTheRectangle = (arrayX[i] >= tLeftCornerX && arrayX[i]<=(tLeftCornerX+rectWidth) && arrayY[i] <= tLeftCornerY && arrayY[i] >= (tLeftCornerY-rectHeight));
            //A point in the circle and outsied of a rectangle
            if (isInTheCircle && !isInTheRectangle)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

