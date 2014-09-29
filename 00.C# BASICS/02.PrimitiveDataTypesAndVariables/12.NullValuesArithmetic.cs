using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? nullableInt = null;
            double? nullableDouble = null;
            Console.WriteLine(nullableInt);
            Console.WriteLine(nullableDouble);
            nullableInt += 5;
            Console.WriteLine(nullableInt);
            nullableDouble = nullableDouble + 1000;
            Console.WriteLine(nullableDouble);
            nullableInt += null;
            Console.WriteLine(nullableInt);
            nullableDouble += null;
            Console.WriteLine(nullableDouble);
        }
    }

