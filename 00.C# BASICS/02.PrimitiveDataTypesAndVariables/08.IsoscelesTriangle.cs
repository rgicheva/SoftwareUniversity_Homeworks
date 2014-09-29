using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        //if you dont see copyright sign please change your 
        //console font
        //http://www.wikihow.com/Customize-the-Font-in-Windows-Command-Prompt
        //point 14
        Console.OutputEncoding = Encoding.UTF8;
        char c = '\u00A9';       
        Console.WriteLine("   " + c);
        Console.WriteLine();
        Console.WriteLine("  "+c+" "+c);
        Console.WriteLine();
        Console.WriteLine(" "+c+ "   "+c);
        Console.WriteLine();
        Console.WriteLine(c+" "+c+" "+c+" "+c);
    }
}

