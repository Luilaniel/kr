using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportCashDesk
{
    public class DomesticFlight : Flight
    {
        public string Region { get; set; }

        // Конструктор класу-нащадка із делегуванням базовому класу
        public DomesticFlight(int flightNumber, string route, List<string> stopPoints, DateTime departureTime, List<DayOfWeek> flightDays, int availableSeats, double ticketPrice, string region)
            : base(flightNumber, route, stopPoints, departureTime, flightDays, availableSeats, ticketPrice)
        {
            Region = region;
        }

        // Конструктор за замовчуванням
        public DomesticFlight() : base()
        {
            Region = string.Empty;
        }
        public override void DisplayInfo()
        {
            MessageBox.Show($"Рейс №{FlightNumber}\nМаршрут: {Route}\nРегіон: {Region}\nЧас відправлення: {DepartureTime}\nЦіна квитка: {TicketPrice} грн",
                            "Інформація про внутрішній рейс", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
