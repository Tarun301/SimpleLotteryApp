using System;
using System.Collections.Generic;
using System.Text;

namespace Simple1
{
    public class StandardMessage
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("****** Welcome to the simple Lotto ******");
        }

        public static void PrintTicketMessage(int checkTicket)
        {
            Console.WriteLine("Announcing this week's winning ticket.... the number is " + checkTicket);
        }

        public static void PrintWinnerMessage(string name)
        {
            Console.WriteLine("****** WINNER ******");
            Console.WriteLine("Congratulations " + name);
            Console.WriteLine("You have won");
        }

        public static void PrintWalletIsEmpty(string name)
        {
            Console.WriteLine(name + " has run out of money, so he no longer plays the lottery.");
        }
    }
}
