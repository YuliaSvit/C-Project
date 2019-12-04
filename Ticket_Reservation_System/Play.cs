using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket_Reservation_System
{
    class Play:Ticket_Reservation
    {
        string gameType;

        public Play(int numPeople, int rowN, int seatN, string sec,double price, DateTime date, string eType, string loc, string game):base(numPeople, rowN, seatN, sec, price, date, eType, loc)
        {
            gameType = game;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nGame: " + gameType;
        }
    }
}
