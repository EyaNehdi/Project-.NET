using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public string Classe { get; set; }
        public string Destination { get; set; }
        public int Id { get; set; }

        //Associations
        public IList<ReservationTicket> ReservationTickets { get; set; }
    }
}
