using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {

        [Display(Name = "Date of Birth"),DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }
        [EmailAddress]
        public String EmailAddress { get; set; }
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Name should be between 3 and 25 characters.")]
        public String FirstName { get; set; }
        //public int Id { get; set; }
        public String LastName { get; set; }
        [Key,StringLength(7)]
        public String PassportNumber { get; set; }
        [RegularExpression("^[0,9]{8}$")]
        public int TelNumber { get; set; }
        //prop de navigation
        public IList<Flight> Flights { get; set; }
        //methode toString()
        public override string ToString()
        {
            return "Birthdate : "+BirthDate+"\n EmailAddress : "+EmailAddress+"\n FirstName : "+FirstName+
                "\n "+"\n LastName : "+LastName+"\n PassportNumber : "+PassportNumber+"\n TelNumber : "+TelNumber;
        }
        //Polymorphisme
        public bool CheckProfile(String nom,String prenom)
        {
            return nom == LastName && prenom == FirstName;
        }
        public bool CheckProfile(String nom, String prenom,String email)
        {
            return nom == LastName && prenom == FirstName && email.Equals(EmailAddress);
        }
        public bool CheckProfile1(String nom, String prenom, String email=null)
        { 
        if (email==null)
                return nom == LastName && prenom == FirstName;
            return nom == LastName && prenom == FirstName && email.Equals(EmailAddress);
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I'm passenger");
        }
    }
}
