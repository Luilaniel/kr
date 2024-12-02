using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportCashDesk
{
    public class AirportCashier
    {
        private List<Flight> flights;

        public AirportCashier()
        {
            flights = new List<Flight>();
        }

        // Додавання нового рейсу
        public void AddFlight(Flight flight)
        {
            flights.Add(flight);
        }

        // Пошук найближчого рейсу до заданого пункту
        public Flight FindNearestFlight(string destination, DateTime currentTime)
        {
            return flights
                .Where(f => f.Route.Contains(destination) && f.AvailableSeats > 0)
                .Where(f => f.FlightDays.Contains(currentTime.DayOfWeek) && f.DepartureTime > currentTime)
                .OrderBy(f => f.DepartureTime)
                .FirstOrDefault();
        }

        // Оформлення квитків
        public bool BookTickets(int flightNumber, int ticketsToBook)
        {
            var flight = flights.FirstOrDefault(f => f.FlightNumber == flightNumber);

            if (flight == null || flight.AvailableSeats < ticketsToBook)
            {
                return false; // Недостатньо місць
            }

            flight.AvailableSeats -= ticketsToBook;
            return true; // Квитки успішно оформлені
        }

        // Формування посадкової відомості
        public string GenerateBoardingList(int flightNumber)
        {
            var flight = flights.FirstOrDefault(f => f.FlightNumber == flightNumber);
            if (flight == null)
            {
                return "Рейс не знайдено.";
            }

            return $"Посадкова відомість для рейсу {flight.FlightNumber}:\n" +
                   $"Маршрут: {flight.Route}\n" +
                   $"Час відправлення: {flight.DepartureTime}\n" +
                   $"Кількість вільних місць: {flight.AvailableSeats}";
        }
    }
}
