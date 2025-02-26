using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interface;

namespace AM.ApplicationCore.Service
{
    public class FlightMethods:IFlightMethods
    {
        public List<Flight> Flights = new List<Flight> ();

        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates = new List<DateTime> ();
            
            //for(int i = 0; i < Flights.Count; i++)
            //foreach (Flight i in Flights) 
            //{
            //    if (i.Destination == destination)
            //        dates.Add(i.FlightDate);
            //}
            //return dates;
            //------------------------------------------------------------------------------
           

            //***********LINQ
            //var query = from f in Flights
            //            where f.Destination == destination
            //            select f.FlightDate;
            //return query.ToList();



            //------------------------------------------------------------------------------------------
            //************Lambda Expression
            return Flights.Where(f => f.Destination == destination).Select(f => f.FlightDate).ToList();
            
        }

        public void GetFlights(string filterType, string filterValue)
        {
            List<Flight> result = new List<Flight>();
            foreach (Flight i in Flights)
            {
                switch (filterType)
                {
                    case "Departure":
                        if (i.Departure == filterValue)
                            Console.WriteLine(i);
                        break;
                    case "Destination":
                        if (i.Destination == filterValue)
                            Console.WriteLine(i);
                        break;
                    case "EffectiveArrival":
                        if (i.EffectiveArrival == DateTime.Parse(filterValue))
                            Console.WriteLine(i);
                        break;
                    case "EstimatedDuration":
                        if (i.EstimatedDuration == int.Parse(filterValue))
                            Console.WriteLine(i);
                        break;
                    case "FlightDate":
                        if (i.FlightDate == DateTime.Parse(filterValue))
                            Console.WriteLine(i);
                        break;
                    default:
                        Console.WriteLine("Default");
                        break;
                }
            }
           
        }
        public void ShowFlightDetails(Plane plane)
        {
            //******LINQ
            //var query = from f in Flights
            //            where f.Plane == plane
            //            select new { f.FlightDate, f.Destination };
            //foreach(var q in query)
            //{ Console.WriteLine(q.ToString()); };
            //*****Lambda
            var req = Flights.Where(f => f.Plane == plane).Select(f => new { f.FlightDate, f.Destination });
            foreach (var q in req)
            {
                Console.WriteLine(q.ToString());
            }
        }
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var query = from f in Flights
                        where DateTime.Compare(startDate, f.FlightDate) <= 0
                        && (f.FlightDate - startDate).TotalDays <= 7
                        select f;
            return query.Count();
        }

        public double DurationAverage(string destination)
        {
            //*******LINQ
            //var query = from f in Flights
            //             where f.Destination == destination
            //             select f.EstimatedDuration;
            //return query.Average();
            //*******Lambda
            return Flights.Where(f => f.Destination == destination).Select(f => f.EstimatedDuration).Average();
        }

        public IEnumerable<Flight> OrderedDurationFlights()
        {
            //*****LINQ
            //var query = (from f in Flights
            //             orderby f.EstimatedDuration descending
            //             select f);
            //return query;
            //************Lambda
            return Flights.OrderByDescending(f => f.EstimatedDuration);
        }

        //public IEnumerable<Traveller> SeniorTravellers(Flight flight)
       // {
            //**********LINQ
            //var query = from f in flight.Passengers.OfType<Traveller>()
            //             orderby f.BirthDate ascending
            //             select f;
            //return query.Take(3);
            //*****Lambda
           // return flight.Passengers.OfType<Traveller>().OrderBy(t => t.BirthDate).Take(3);
      //  }

        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights()
        {
            var query = from f in Flights
                        group f by f.Destination;
                foreach(var item in query)
            {
                Console.WriteLine(item.Key);
                foreach(var val in item)
                    Console.WriteLine(val); 
                
                
            }
            return query;
            
        }
    }
}
