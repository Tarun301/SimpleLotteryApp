using System;
using System.Collections.Generic;
using System.Text;

namespace Simple1
{
    public class PlayerDataCapture
    {
        public static Player[] Capture()
        {
            List<int> ticketsl = new List<int> { 3, 33, 17, 46, 47, 27 };
            List<int> tickets2 = new List<int> { 7, 19, 22, 23 };
            List<int> tickets3 = new List<int> { 33, 13 };

            Player[] players;
            players = new Player[3];
            players[0] = new Player("Tama", ticketsl, 50, false);
            players[1] = new Player("Bob", tickets2, 8, false);
            players[2] = new Player("Caesar", tickets3, 35, false);

            return players;
        }

        public static List<int> CaptureHelper()
        {
            List<int> helper = new List<int> { 0, 1, 2 };
            return helper;
        }

        public static int CaptureRandom()
        {
            Random var1 = new Random();
            int num;
            num = var1.Next(1, 49);
            return num;
        }

    }
}
