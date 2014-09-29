/*
Problem 7. Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
Examples:
x	    y	    inside	 
0	    1	    true	
-2	    0	    true	
-1	    2	    false	
1.5	    -1	    true	
-1.5    -1.5    false	
100	    -30	    false	
0	    0	    true	
0.2	    -0.8	true	
0.9	    -1.93	false	
1	    1.655	true
*/

using System;

class PointInCircle
{
    static void Main()
    {
        double radius = 2;
        float centerX = 0;
        float centerY = 0;
        float deltaX = 0;
        float deltaY = 0;
        double centerDistance = 0;
        float[] coordinateX = new float[] {0,-2, -1, 1.5f, -1.5f, 100, 0, 0.2f, 0.9f, 1};
        float[] coordinateY = new float[] {1,0, 2, -1, -1.5f, -30, 0, -0.8f, -1.93f, 1.655f };
        for (int i = 0; i < coordinateX.Length; i++)
        {
            deltaX = centerX-coordinateX[i];
            deltaY = centerY-coordinateY[i];
            centerDistance = Math.Sqrt(Math.Pow(deltaX,2) + Math.Pow(deltaY,2));
            Console.WriteLine(centerDistance <= radius);
	    }
    }
}

    


