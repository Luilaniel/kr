using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportCashDesk
{
    public class FlightClosestCityComparer : IComparer<Flight>
    {
        private string referenceCity;

        public FlightClosestCityComparer(string referenceCity)
        {
            this.referenceCity = referenceCity;
        }

        public int Compare(Flight x, Flight y)
        {
            if (x == null || y == null) return 0;

            bool xContains = x.StopPoints.Contains(referenceCity);
            bool yContains = y.StopPoints.Contains(referenceCity);

            if (xContains && !yContains) return -1;
            if (!xContains && yContains) return 1;

            return x.FlightNumber.CompareTo(y.FlightNumber);
        }
    }
}
