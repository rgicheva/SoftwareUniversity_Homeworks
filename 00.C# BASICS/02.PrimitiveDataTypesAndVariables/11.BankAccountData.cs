using System;
using System.Globalization;
using System.Text;
using System.Threading;

    class BankAccountData
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //setting the culture info for en us. It could be any
            //country and currency
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            string name = "Ivan";
            string middle = "Ivanov";
            string lastName = "Ivanov";
            float balance = 125.25f;
            string bankName = "My bank";
            string iban = "GB82 WEST 1234 5698 7654 32";
            //cc numbers can be stored in long but they are never
            //used in arithmetical operations so string is ok too
            string creditcard1 = "1234 5678 1234 5678";
            string creditcard2 = "9876 9876 6543 6543";
            string creditcard3 = "1234 7890 1234 7890";
            Console.WriteLine("Name:{0} ", name);
            Console.WriteLine("Middle name:{0} ", middle);
            Console.WriteLine("Last name:{0} ",lastName);
            Console.WriteLine("Balance:{0:c} ", balance);
            Console.WriteLine("Bank name:{0} ", bankName);
            Console.WriteLine("IBAN:{0} ", iban);
            Console.WriteLine("First credit card:{0} ", creditcard1);
            Console.WriteLine("Second credit card:{0} ", creditcard2);
            Console.WriteLine("Third credit card:{0} ", creditcard3);
        }
    }

