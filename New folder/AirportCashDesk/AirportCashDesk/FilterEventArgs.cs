using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportCashDesk
{
    public class FilterEventArgs : EventArgs
    {
        public string Destination { get; set; }
        public DateTime Date { get; set; }

        public FilterEventArgs(string destination)
        {
            Destination = destination;
            Date = DateTime.Now;  // Можна встановити поточну дату
        }
    }
}
