using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyHighAirlines
{
    class luggage
    {
        
        public static double checkweight(double lgwt,int cl)

        {
            double count = 0;
            if (cl == 1)
            {
                if (lgwt > 50)
                {
                    count = count + (lgwt - 50);
                }
            }
            else if (cl == 2)
            {
                if (lgwt > 40)
                {
                    count = count + (lgwt - 40);
                }
            }
            else
            {
                if (lgwt > 20)
                {
                    count = count + (lgwt - 20);
                }
            }


            double addcost = 2 * count;
            Console.WriteLine("Additional Cost to be paid is Rs." + addcost);
            return addcost;
        }
    }
}
