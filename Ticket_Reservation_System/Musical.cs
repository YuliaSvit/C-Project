using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket_Reservation_System
{
    class Musical:Ticket_Reservation
    {
        private string instrument;

        public Musical(int numPeople, int rowN, int seatN, string sec, string instr, double price, DateTime date, string eType, string loc) :base(numPeople,rowN,seatN,sec,price,date,eType,loc)
        {
            instrument = instr;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nInstrument: " + instrument;
        }
    }
}
