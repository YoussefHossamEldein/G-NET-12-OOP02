using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class Cinema
    {
        private Ticket[] _ticket = new Ticket[20];

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < _ticket.Length; i++)
            {
                if (_ticket[i] == null)
                {
                    _ticket[i] = t;
                    return true;
                }
            }
            return false;
        }
        public Ticket this[int index]
        {
            get
            {
                if (index >= 0 && index < _ticket.Length)
                {
                    return _ticket[index];
                }
                return null;
            }
            set
            {
                if (index >= 0 && index < _ticket.Length)
                {
                    _ticket[index] = value;
                }
            }
        }
        public Ticket this[string moviename]
        {
            get
            {
                foreach (var movie in _ticket)
                {
                    if (movie.MovieName == moviename)
                    {
                        return movie;
                    }
                }
                return null;
            }

        }
    }
}
