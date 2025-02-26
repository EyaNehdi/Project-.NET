using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public String Departure { get; set; }
        public String Destination { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public String AirlineLogo { get; set; }
        //[ForeignKey("Plane")]
        public int PlaneFk { get; set; }
        //Proprieté de navigation
        public Plane Plane { get; set; }
        
        public ICollection<Passenger> Passengers { get; set; }
        //methode toString()
        public override string ToString()
        {
            return "Departure : "+Departure+"\n Destination : "+Destination+"\n EffectiveArrival : "+EffectiveArrival +
                "\n EstimatedDuration : "+EstimatedDuration+ "\n FlightDate : "+ FlightDate +"\n FlightId : "+FlightId;
        }
    }
}
