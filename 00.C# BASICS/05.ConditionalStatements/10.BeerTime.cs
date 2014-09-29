/*Problem 10. * Beer Time
A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” 
(an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or
“non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. 
Note that you may need to learn how to parse dates and times. Examples:
 */

using System;

class BeerTime
{
    static void Main()
    {
        DateTime time;
        do
        {
            Console.Write("Enter a time in format “hh:mm PM/AM: ");
        } while (!DateTime.TryParse(Console.ReadLine(), out time));
        DateTime beerTimeBegining = DateTime.ParseExact("01:00 PM", "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture);
        DateTime beerTimeEnd = DateTime.ParseExact("03:00 AM", "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture);
        //Console.WriteLine(time.Hour);
        int h = time.Hour;
        int m = time.Minute;
        if ((h >= 13 && h <= 23) || (h >= 0 && h <= 2) || (h == 3 && m == 0))
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}

