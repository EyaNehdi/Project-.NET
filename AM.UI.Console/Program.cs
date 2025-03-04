// See https://aka.ms/new-console-template for more information
using System.Numerics;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Service;
using Plane = AM.ApplicationCore.Domain.Plane;

Console.WriteLine("Hello, World!");
//Plane p1 = new Plane(12,new DateTime(2025,09,24),4,PlaneType.Boing);
Plane p1 = new Plane
{
    Capacity=12,
    ManufactureDate=new DateTime(2025,09,24),
    PlaneId=4,
    PlaneType=PlaneType.Boing,
};
Console.WriteLine(p1);
Passenger p2 = new Passenger
{
    FullName = new FullName
    {
        FirstName = "Eya",
        LastName = "Nehdi"
    }
};
Console.WriteLine("\n**********Test CheckProfile 1*******");
Console.WriteLine(p2.CheckProfile("Nehdi","Eya"));
Passenger p3 = new Passenger
{
    FullName = new FullName
    {
        FirstName = "Eya",
        LastName = "Nehdi"
    },
    EmailAddress = "eya.nehdi@esprit.tn"
};

Console.WriteLine("\n**********Test CheckProfile 2*******");

Console.WriteLine(p3.CheckProfile("Nehdi", "Eya","eya.nehdi@esprit.tn"));
p3.PassengerType();
Staff s = new Staff
{
    FullName = new FullName
    {
        FirstName = "Eya"
    }
};
Console.WriteLine("\n**********Test passengertype staff*******");
s.PassengerType();
Traveller t = new Traveller
{
    FullName = new FullName
    {
        FirstName = "Nehdi"
    }
};
Console.WriteLine("\n**********Test passengertype traveller*******");
t.PassengerType();
Console.WriteLine("\n**********Test GetFlightDates*******");
FlightMethods fm = new FlightMethods();
fm.Flights = TestData.listFlights;
foreach (var item in fm.GetFlightDates("Paris"))
{
    Console.WriteLine(item);
}
Console.WriteLine("\n**********Test GetFlights*******");

Console.WriteLine("\n**********Test ShowFlights*******");
fm.ShowFlightDetails(TestData.Airbusplane);
Console.WriteLine("\n**********Test ProgrammedFlights*******");
Console.WriteLine(fm.ProgrammedFlightNumber(new DateTime(2021, 12, 31)));
Console.WriteLine("\n**********Test Duration Average*******");
Console.WriteLine(fm.DurationAverage("Madrid"));
Console.WriteLine("\n**********Test OrderedDurationFlights*******");
foreach( var item in fm.OrderedDurationFlights())
{
    Console.WriteLine(item);
}
Console.WriteLine("\n**********Test SeniorTravellers*******");
//foreach (var item in fm.SeniorTravellers(TestData.flight1))
//{
//    Console.WriteLine(item.BirthDate);
//}
Console.WriteLine("\n**********Test DestinationGroupedFlights*******");
Console.WriteLine(fm.DestinationGroupedFlights());
p2.UpperFullName();
Console.WriteLine(p2.FullName.FirstName+" "+p2.FullName.LastName);