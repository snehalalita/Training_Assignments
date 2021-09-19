using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyHighAirlines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FlyHigh Airlines");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ticket Booking");
            bookETicket bt = new bookETicket();
            bt.book();
            Console.WriteLine("Ticket booked successfully");
          
           
            Console.ReadLine();
        }
    }
}
