using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket_Reservation_System
{
    class Lecture:Ticket_Reservation
    {
        string showHost;

        public Lecture(int numPeople, int rowN, int seatN, string sec, double price, DateTime date, string eType, string loc, string host):base(numPeople,rowN,seatN,sec,price, date, eType, loc)
        {
            showHost = host;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nLecture Host: " + showHost;
        }
    }
}
