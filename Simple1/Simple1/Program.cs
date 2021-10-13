using System;
using System.Collections.Generic;

namespace Simple1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> helper = PlayerDataCapture.CaptureHelper();

            bool isRunning = true;
            int checkTicket;

            Player[] players;
            players = PlayerDataCapture.Capture();

            StandardMessage.WelcomeMessage();
            foreach (var player in players)
            {
                Console.WriteLine(player.name);
            }

            while (isRunning)
            {
                checkTicket = PlayerDataCapture.CaptureRandom();
                StandardMessage.PrintTicketMessage(checkTicket);
                foreach (var j in helper)
                {
                    if (players[j].price >= players[j].ticketList.Count)
                    {
                        if (players[j].ticketList.Contains(checkTicket))
                        {
                            players[j].checker = true;
                        }

                        players[j].price = players[j].price - players[j].ticketList.Count;

                        if (players[j].price < players[j].ticketList.Count)
                        {
                            StandardMessage.PrintWalletIsEmpty(players[j].name);
                        }
                    }

                    if (players[j].checker)
                    {
                        isRunning = false;
                    }
                }
            }
            foreach (var i in helper)
            {
                if (players[i].checker)
                {
                    StandardMessage.PrintWinnerMessage(players[i].name);
                }
            }
        }
    }
}
