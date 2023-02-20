using AM.Application.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AM.Application.Services
{
    public class ServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public Action<Plane> FlightDetailsDel;

        public Func<String, double> DurationAverageDell;

        public ServiceFlight()
        {
            FlightDetailsDel = plane =>
            {
                /*var query = from f in Flights
                            where f.plane.PlaneId == plane.PlaneId
                            select new { f.Destination, f.FlightDate };*/

                var query = Flights
                    .Where(f => f.plane.PlaneId == plane.PlaneId)
                    .Select(f => new { f.Destination, f.FlightDate });
                foreach (var f in query)
                {
                    Console.WriteLine(f.Destination + " " + f.FlightDate);
                }
            };

            DurationAverageDell = destination =>
            {
                var query = from f in Flights
                            where f.Destination.Equals(destination)
                            select f.EstimatedDuration;
                return (double)query.Average();
            };
        }


        public IEnumerable<DateTime> GetFlightDates(string destination)
        {

            /*for (int i = 0; i < Flights.Count; i++)
            {
                Flight flight = Flights[i];
                if (flight.Destination == destination)
                    yield return flight.FlightDate;
            }*/
            /*var query = from f in Flights
                        where f.Destination == destination
                        select f.FlightDate;*/

            var query = Flights
                .Where(f => f.Destination == destination)
                .Select(f => f.FlightDate);

            return (IEnumerable<DateTime>)query;
        }

        public void ShowFlightDetails(Plane plane)
        {
            /*var query = from f in Flights
                        where f.plane.PlaneId == plane.PlaneId
                        select new { f.Destination, f.FlightDate };*/

            var query = Flights
                .Where( f => f.plane.PlaneId == plane.PlaneId )
                .Select( f => new { f.Destination, f.FlightDate });
            foreach (var f in query)
            {
                Console.WriteLine(f.Destination+" "+f.FlightDate);
            }
        }

        public int ProgramedFlightNumber(DateTime startDate)
        {
            /*var query = from f in Flights
                        where DateTime.Compare((DateTime)f.FlightDate, startDate) > 0 && (f.FlightDate - startDate).TotalDays <= 7
                        select f;*/
            var query = Flights.Where(f => DateTime.Compare((DateTime)f.FlightDate, startDate) > 0 && (f.FlightDate - startDate).TotalDays <= 7. );

            return query.Count();
        }

        public double DurationAverage(string destination)
        {
            var query = from f in Flights
                        where f.Destination.Equals(destination)
                        select f.EstimatedDuration;
            return (double)query.Average();
        }

        public IList<Flight> OrderedDurationFlights()
        {
            /*var query = from f in Flights
                        orderby f.EstimatedDuration descending
                        select f;*/

            var query = Flights.OrderByDescending(f =>f.EstimatedDuration );
            return query.ToList();
        }

        public IEnumerable<Passenger> SeniorTravellers(Flight flight)
        {
            return (from p in flight.Passengers
                   where p is Traveller
                   orderby p.BirthDate
                   select p).Take(3);

        }

        public void DestinationGroupedFlights()
        {
            var query = from f in Flights
                        group f by f.Destination;
            foreach (var f in query)
            {
                Console.WriteLine("Destination: " + f.Key);
                foreach (var item in f)
                    Console.WriteLine("Decoullage: " + item.FlightDate);
                {

                }
            }
        }
    }
}
