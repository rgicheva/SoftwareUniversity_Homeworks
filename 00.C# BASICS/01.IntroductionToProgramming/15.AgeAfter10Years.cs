using System;

class AgeAfter10Years
{
    static void Main()
    {
        int currentAge = 0;
        int ageAfter10Years = 0;
        DateTime currentDate = DateTime.Now;
        DateTime birthDate;
        String tempDate;
        Console.Write("Please enter your birthday:");
        tempDate = Console.ReadLine();
        birthDate = DateTime.Parse(tempDate);

        if (currentDate.Month < birthDate.Month)
        {
            currentAge = currentDate.Year - birthDate.Year - 1;
        }
        else if (currentDate.Month > birthDate.Month)
        {
            currentAge = currentDate.Year - birthDate.Year;
        }
        else
        {
            if (currentDate.Day < birthDate.Day)
            {
                currentAge = currentDate.Year - birthDate.Year - 1;
            }
            else if (currentDate.Day > birthDate.Day)
            {
                currentAge = currentDate.Year - birthDate.Year;
            }
            else
            {
                currentAge = currentDate.Year - birthDate.Year;
            }
        }
        //Console.WriteLine("Now you are {0} years old", currentAge);
        ageAfter10Years = currentAge + 10;
        Console.WriteLine("Now you are {0} years old and after 10 years you will be {1} years old", currentAge, ageAfter10Years);
    
    }
}

