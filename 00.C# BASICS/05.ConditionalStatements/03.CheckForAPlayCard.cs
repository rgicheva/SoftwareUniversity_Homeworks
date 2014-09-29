using System;

    class CheckForAPlayCard
    {
        static void Main()
        {
            string[] cardsArr = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K","A"};
            string userCard = Console.ReadLine();
            bool flag = false;
            for (int i = 0; i < cardsArr.Length; i++)       
            {
                if (userCard == cardsArr[i])
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }

