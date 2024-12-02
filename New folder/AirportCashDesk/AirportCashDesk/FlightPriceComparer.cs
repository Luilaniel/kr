using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportCashDesk
{
    public class FlightPriceComparer : IComparer<Flight>
    {
        public int Compare(Flight x, Flight y)
        {
            if (x == null || y == null) return 0;
            return x.TicketPrice.CompareTo(y.TicketPrice);
        }
    }
}
