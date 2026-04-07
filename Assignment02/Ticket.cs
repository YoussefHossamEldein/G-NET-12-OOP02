using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class Ticket
    {
        private string _moviename;
        private static int ticketCounter = 0;
        private double _price;
        public int TicketId { get; set; }
        public TicketType Type { get; set; }
        public string MovieName
        {
            get
            {
                return _moviename;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    //Console.WriteLine("can not be null or empty");
                    _moviename = value;
                }


            }
        }
        public Seat Seat { get; set; }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public double PriceAfterTax => _price * (14 / 100);
        public Ticket(string moviename, TicketType type, Seat seat, double price)
        {
            Type = type;
            MovieName = moviename;
            Price = price;
            Seat = seat;
            ticketCounter++;
            TicketId = ticketCounter;
        }
        public Ticket(string name) : this(name, TicketType.Standard, new Seat('A', 1), 50)
        {

        }
        public Ticket()
        {

        }
        public static int GetTotalTicketsSold() => ticketCounter;
        public double CalcTotal(double taxPercent)
        {
            return Price -= (Price * taxPercent / 100);
        }
        public void ApplyDiscount(double discountamount)
        {
            if (discountamount > 0 && discountamount <= Price)
            {
                Price -= discountamount;
                discountamount = 0;
            }
        }
        public void PrintTicket()
        {
            Console.WriteLine($"Movie    : {MovieName}");
            Console.WriteLine($"Type     : {Type}");
            Console.WriteLine($"Seat     : {Seat}");
            Console.WriteLine($"Price    : {Price}");
        }

    }



}
