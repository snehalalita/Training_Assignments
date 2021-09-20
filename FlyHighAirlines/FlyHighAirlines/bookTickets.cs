using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyHighAirlines
{
    class bookTickets
    {
        string ps;
        string[] name = { "Delhi", "Mumbai", "Bangalore", "Chennai" };
        public string pickSource()
        {
            
            Console.WriteLine("Source:");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + name[i]);
            }
            int pick = Convert.ToInt32(Console.ReadLine());
            ps = name[pick - 1];
            return (name[pick - 1]);
        }

        public string pickDest()
        {
            
            Console.WriteLine("Destination:");
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] != ps)
                {
                    Console.WriteLine((i + 1) + " " + name[i]);
                }
            }
            int pick = Convert.ToInt32(Console.ReadLine());
            return (name[pick - 1]);
        }
        public int price(int cl)
        {
            int[] p = { 6000, 4000, 2000 };
            return p[cl - 1];
        }
    }
}
