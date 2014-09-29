using System;

class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001;
        float a1 = 5.3f;
        float b1 = 6.1f;
        Console.WriteLine(Math.Abs(a1-b1)<eps);
        //double[] aArray = new double[] { 5.00000001, 5.00000005, -0.0000007, -4.999999, 4.999999};
        //double[] bArray = new double[] { 5.00000003, 5.00000001, 0.00000007, -4.999998, 4.999998 };
        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine(Math.Abs(aArray[i]-bArray[i]) < eps);
        //}
        double a2 = 5.00000001;
        double b2 = 5.00000003;
        Console.WriteLine(Math.Abs(a2 - b2) < eps);
        double a3 = 5.00000005;
        double b3 = 5.00000001;
        Console.WriteLine(Math.Abs(a3 - b3) < eps);
        double a4 = -0.0000007;
        double b4 = 0.00000007;
        Console.WriteLine(Math.Abs(a4 - b4) < eps);
        double a5 = -4.999999;
        double b5 = -4.999998;
        Console.WriteLine(Math.Abs(a5 - b5) < eps);
        double a6 = 4.999999;
        double b6 = 4.999998;
        Console.WriteLine(Math.Abs(a6 - b6) < eps);
    }
}

