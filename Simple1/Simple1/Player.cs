using System;
using System.Collections.Generic;
using System.Text;

namespace Simple1
{
    public class Player
    {
        public string name;
        public List<int> ticketList = new List<int>();
        public int price;
        public bool checker;

        public Player(string name, List<int> ticketList, int price, bool checker)
        {
            this.name = name;
            this.ticketList = ticketList;
            this.price = price;
            this.checker = checker;
        }
    }
}
