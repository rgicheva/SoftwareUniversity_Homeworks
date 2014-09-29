using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int temp;
        Console.WriteLine("The original value of a is {0}", a);
        Console.WriteLine("The original value of b is {0}", b);
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("The exchanged value of a is {0}", a);
        Console.WriteLine("The exchanged value of b is {0}", b);
    }
}

