using AirportCashDesk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class Flight : ICustomFlightInfo
{
    private int flightNumber;
    private string route;
    private List<string> stopPoints;
    private DateTime departureTime;
    private List<DayOfWeek> flightDays;
    private int availableSeats;
    private double ticketPrice;

    public int FlightNumber { get => flightNumber; set => flightNumber = value; }
    public string Route { get => route; set => route = value; }
    public List<string> StopPoints { get => stopPoints; set => stopPoints = value; }
    public DateTime DepartureTime { get => departureTime; set => departureTime = value; }
    public List<DayOfWeek> FlightDays { get => flightDays; set => flightDays = value; }
    public int AvailableSeats { get => availableSeats; set => availableSeats = value; }
    public double TicketPrice { get => ticketPrice; set => ticketPrice = value; }

    public string StopPointsString => StopPoints != null ? string.Join(", ", StopPoints) : "";

    // Реалізація методу інтерфейсу
    public string GetDetailedInfo()
    {
        return $"Рейс №{FlightNumber}\nМаршрут: {Route}\nЗупинки: {StopPointsString}\nЧас відправлення: {DepartureTime}\nДні рейсів: {FlightDaysString}\nДоступні місця: {AvailableSeats}\nЦіна квитка: {TicketPrice} грн";
    }

    public virtual void DisplayInfo()
    {
        MessageBox.Show(
            $"Рейс №{FlightNumber}\nМаршрут: {Route}\nЧас відправлення: {DepartureTime}\nЦіна квитка: {TicketPrice} грн",
            "Інформація про рейс",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    public string FlightDaysString => FlightDays != null
        ? string.Join(", ", FlightDays.Select(day => GetUkrainianDayOfWeek(day)))
        : "";

    public Flight() : this(0, string.Empty, new List<string>(), DateTime.Now, new List<DayOfWeek>(), 0, 0.0)
    {
    }

    public Flight(int flightNumber, string route, List<string> stopPoints, DateTime departureTime, List<DayOfWeek> flightDays, int availableSeats, double ticketPrice)
    {
        FlightNumber = flightNumber;
        Route = route;
        StopPoints = stopPoints;
        DepartureTime = departureTime;
        FlightDays = flightDays;
        AvailableSeats = availableSeats;
        TicketPrice = ticketPrice;
    }

    private string GetUkrainianDayOfWeek(DayOfWeek day)
    {
        return day switch
        {
            DayOfWeek.Monday => "Понеділок",
            DayOfWeek.Tuesday => "Вівторок",
            DayOfWeek.Wednesday => "Середа",
            DayOfWeek.Thursday => "Четвер",
            DayOfWeek.Friday => "П'ятниця",
            DayOfWeek.Saturday => "Субота",
            DayOfWeek.Sunday => "Неділя",
            _ => ""
        };
    }

    public bool IsFlightAvailableOnDay(DayOfWeek day)
    {
        return FlightDays != null && FlightDays.Contains(day);
    }

    public double GetTotalTicketRevenue()
    {
        return AvailableSeats * TicketPrice;
    }

    public double GetTicketPrice(bool extraLuggage)
    {
        return extraLuggage ? TicketPrice + 200 : TicketPrice;
    }

    public class FlightPriceComparer : IComparer<Flight>
    {
        public int Compare(Flight x, Flight y)
        {
            if (x == null || y == null) return 0;
            return x.TicketPrice.CompareTo(y.TicketPrice);
        }
    }

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
