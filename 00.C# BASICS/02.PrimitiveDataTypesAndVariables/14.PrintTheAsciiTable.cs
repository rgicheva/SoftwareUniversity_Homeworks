using System;

class PrintTheAsciiTable
{
    static void Main()
    {
        char c;
        //printing the main and extended ASCII table
        for (int i = 0; i <= 254; i++)
        {
            c = Convert.ToChar(i);
            Console.WriteLine("{0} = {1}", i, c);
        }
    }
}


