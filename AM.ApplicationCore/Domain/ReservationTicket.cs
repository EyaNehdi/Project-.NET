using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class ReservationTicket
    {
        public DateTime DateReservation { get; set; }
        public float Prix { get; set; }


        //foreign key config (clé étrangère des objets des associations)
        [ForeignKey("Ticket")]
        public int TicketFK { get; set; }
        [ForeignKey("Passenger")]
        public string PassengerFK { get; set; }

        //associations

        public Passenger Passenger { get; set; }
        public Ticket Ticket { get; set; }
    }
}
