using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public struct Seat
    {
        public char Row { get; set; }
        public int Number { get; set; }

        public Seat(char row, int num)
        {
            Row = row;
            Number = num;
        }
        public override string ToString()
        {
            return $"{Row}{Number}";
        }
    }
}
