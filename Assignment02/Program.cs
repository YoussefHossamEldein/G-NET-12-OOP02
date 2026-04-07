using MovieTicketBooking;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            /* a) First problem : public fields so anyone from outside can access and change it directly */
            /* second problem: no validation inside the methods on these fields */
            // b) 
            /* making private fields and use setters and getters with validation or use properties */
            //example 
            // internal class BankAccount
            //    {

            //private string owner;
            //private double _balance;
            //public double GetBalance()
            //{
            //    return _balance;
            //}
            //public void SetBalance (double amount)
            //{
            //    if(amount < 0)
            //    {
            //        Console.WriteLine("Balance can not be negative");
            //        return;
            //    }
            //    _balance = amount;
            //}
            //// Using properties 
            //    public double Balance
            //       {
            //          get;
            //             set;
            //       }
            // C) because missuse is expected from user and unlogical use as well without validation of encapsulation



            //}
            #endregion

            #region Question02
            /* Fields or attributes are variables to store data inside classes */
            /* properties are a controlled way to get or set fields to encounter and violate 
             * encapsulation */
            //read only property that return a calculated value 
            /* public int Balance => balance > 0 ; */
            #endregion

            #region Question03
            /* this[int index] is called indexer and it the third way to violate the encapsulation 
             * but it gives us the chance to treat objects from this class like a collection */
            /* IndexOutOfRange Exception and i can handle to avoid this exception by validating 
             * the input inside the indexer like if(index >= 0 && index < names.Length) so now 
             * we can add our name */
            #endregion

            #region Question04
            /* static keyword has made TotalOrders to be a class member not an instance(object) member */
            //No — static methods belong to the class, not an object. There's no instance to read the field from. You'd get a compile error.
            #endregion

            #region Question05
            bool isParsed;
            TicketType tType;
            char seatRow;
            int seatNum;
            double tPrice;
            Cinema c = new Cinema();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Please enter ticket {i} details : ");
                Ticket t = new Ticket();
                Console.Write("Enter Movie Name : ");
                t.MovieName = Console.ReadLine();
                do
                {
                    Console.Write("Enter Ticket Type : ");
                    isParsed = Enum.TryParse<TicketType>(Console.ReadLine(), true, out tType);

                } while (!isParsed || !(Enum.IsDefined(typeof(TicketType), tType)));
                t.Type = tType;
                do
                {
                    Console.Write("Enter Seat Row : ");
                    isParsed = char.TryParse(Console.ReadLine(), out seatRow);
                } while (!isParsed);
                do
                {
                    Console.Write("Enter Seat number : ");
                    isParsed = int.TryParse(Console.ReadLine(), out seatNum);
                } while (!isParsed);
                t.Seat = new Seat(seatRow, seatNum);
                do
                {
                    Console.Write("Enter ticket price : ");
                    isParsed = double.TryParse(Console.ReadLine(), out tPrice);
                } while (!isParsed);
                t.Price = tPrice;

                c.AddTicket(t);
            }
            Console.WriteLine("========= All Tickets =========");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Ticket #{i} | {c[i].MovieName} | {c[i].Type} | {c[i].Seat} | {c[i].Price} | After Tax : {c[i].PriceAfterTax}");
            }
            Console.WriteLine("========= Search by Movie =======");
            Console.Write("Enter movie name to search :  ");
            string? movieName = Console.ReadLine();
            Ticket FoundMovie = c[movieName];
            Console.WriteLine($"Found Ticket {FoundMovie.TicketId} | {FoundMovie.MovieName} | {FoundMovie.Type} | {FoundMovie.Seat} | {FoundMovie.Price}");

            #endregion

        }
    }
}
