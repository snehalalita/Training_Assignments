using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyHighAirlines
{
    class bookETicket:bookTickets
    {
        public void book()
        {
            
            string[] cla = { "First", "Buisness", "Economy" };
            Console.Write("\n\nName : ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            string src = pickSource();
           
            string desc = pickDest();

            Console.Write("Choose Class:\n 1. First Class \n 2. Buisness Class \n 3. Economy Class\n" );
            int cl = Convert.ToInt32(Console.ReadLine());
            int pr = price(cl);

            Console.Write("Total Weight of the luggage:");
            double lugwt = Convert.ToDouble(Console.ReadLine());
            double addcost=luggage.checkweight(lugwt,cl);
            
            Console.WriteLine("\n\n-----Booked details----");
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Source:" + src);
            Console.WriteLine("Destination:" + desc);
            Console.WriteLine("Class:" + cla[cl-1]);
            Console.WriteLine("Flight Cost:" + pr);
            Console.WriteLine("Total Cost:" + (pr + addcost));
            Console.WriteLine();
            return;   
        }
    }
}
