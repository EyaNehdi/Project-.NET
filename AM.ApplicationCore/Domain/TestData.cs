using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static Plane BoingPlane = new Plane { PlaneType = PlaneType.Boing, Capacity = 150, ManufactureDate = new DateTime(2015, 02, 03) };
        public static Plane Airbusplane = new Plane { PlaneType = PlaneType.Airbus, Capacity = 250, ManufactureDate = new DateTime(2020, 11, 11) };
        // Staffs
        public static Staff captain = new Staff { FirstName = "captain", LastName = "captain", EmailAddress = "captain.captain@gmail.com", BirthDate = new DateTime(1965, 01, 01), EmployementDate = new DateTime(1999, 01, 01), Salary = 99999 };
        public static Staff hostess1 = new Staff { FirstName = "hostess1", LastName = "hostess1", EmailAddress = "hostess1.hostess1@gmail.com", BirthDate = new DateTime(1995, 01, 01), EmployementDate = new DateTime(2020, 01, 01), Salary = 999,PassportNumber="3" };
        public static Staff hostess2 = new Staff { FirstName = "hostess2", LastName = "hostess2", EmailAddress = "hostess2.hostess2@gmail.com", BirthDate = new DateTime(1996, 01, 01), EmployementDate = new DateTime(2020, 01, 01), Salary = 999 };
        // Travellers
        public static Traveller traveller1 = new Traveller { FirstName = "traveller1", LastName = "traveller1", EmailAddress = "traveller1.traveller1@gmail.com", BirthDate = new DateTime(1980, 01, 01), HealthInformation = "no troubles", Nationality = "American" };
        public static Traveller traveller2 = new Traveller { FirstName = "traveller2", LastName = "traveller2", EmailAddress = "traveller2.traveller2@gmail.com", BirthDate = new DateTime(1981, 01, 01), HealthInformation = "Some troubles", Nationality = "French" };
        public static Traveller traveller3 = new Traveller { FirstName = "traveller3", LastName = "traveller3", EmailAddress = "traveller3.traveller3@gmail.com", BirthDate = new DateTime(1982, 01, 01), HealthInformation = "no troubles", Nationality = "Tunisian" };
        public static Traveller traveller4 = new Traveller { FirstName = "traveller4", LastName = "traveller4", EmailAddress = "traveller4.traveller4@gmail.com", BirthDate = new DateTime(1983, 01, 01), HealthInformation = "Some troubles", Nationality = "American" };
        public static Traveller traveller5 = new Traveller { FirstName = "traveller5", LastName = "traveller5", EmailAddress = "traveller5.traveller5@gmail.com", BirthDate = new DateTime(1984, 01, 01), HealthInformation = "Some troubles", Nationality = "Spanish" };
        //// Flights
        // Affect all passengers to flight1
        public static Flight flight1 = new Flight
        {
            FlightDate = new DateTime(2022, 01, 01, 15, 10, 10),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 01, 01, 17, 10, 10),
            EstimatedDuration = 110
       // Passengers = new List<Passenger> { captain, hostess1, hostess2, traveller1, traveller2, traveller3, traveller4, traveller5 }
       ,
            Plane = Airbusplane
        };
        public static Flight flight2 = new Flight { FlightDate = new DateTime(2022, 02, 01, 21, 10, 10), Destination = "Paris", EffectiveArrival = new DateTime(2022, 02, 01, 23, 10, 10), EstimatedDuration = 105, Plane = BoingPlane };
        public static Flight flight3 = new Flight { FlightDate = new DateTime(2022, 03, 01, 5, 10, 10), Destination = "Paris", EffectiveArrival = new DateTime(2022, 03, 01, 6, 40, 10), EstimatedDuration = 100, Plane = BoingPlane };
        public static Flight flight4 = new Flight { FlightDate = new DateTime(2022, 04, 01, 6, 10, 10), Destination = "Madrid", EffectiveArrival = new DateTime(2022, 04, 01, 8, 10, 10), EstimatedDuration = 130, Plane = BoingPlane };
        public static Flight flight5 = new Flight { FlightDate = new DateTime(2022, 05, 01, 17, 10, 10), Destination = "Madrid", EffectiveArrival = new DateTime(2022, 05, 01, 18, 50, 10), EstimatedDuration = 105, Plane = BoingPlane };
        public static Flight flight6 = new Flight { FlightDate = new DateTime(2022, 06, 01, 20, 10, 10), Destination = "Lisbonne", EffectiveArrival = new DateTime(2022, 06, 01, 22, 30, 10), EstimatedDuration = 200, Plane = Airbusplane };

        //test list
        public static List<Flight> listFlights = new List<Flight> { flight1, flight2, flight3, flight4, flight5, flight6 };
    }

}
