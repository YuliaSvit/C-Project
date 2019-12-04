using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket_Reservation_System
{
    abstract class Ticket_Reservation
    {
        private int numberOfPeople;
        private int rowNumber;
        private int seatNumber;
        private string section;
        private double priceOf;
        private DateTime eventDateTime;
        private string eventType;
        private string eventLocation;

        public Ticket_Reservation(int numPeople, int rowN, int seatN, string sec, double price, DateTime date, string eType,string loc)
        {
            numberOfPeople = numPeople;
            rowNumber = rowN;
            seatNumber = seatN;
            section = sec;
            priceOf = price;
            eventDateTime = date;
            eventType = eType;
            eventLocation = loc;

        }
        public override string ToString()
        {
            return eventType.ToUpper() + ":\tReservations Details:" +
                "\n\tWhere:\t" + eventLocation +
                "\n\tWhen:\t" + eventDateTime +
                "\n\tCost:\t" + priceOf.ToString("C") +
                "\n\tRow:\t" + rowNumber +
                "\n\tSeat:\t" + seatNumber +
                "\n\tSection:\t" + section +
                "\n\tNumber of People registered:\t" + numberOfPeople;
        }

    }
}
