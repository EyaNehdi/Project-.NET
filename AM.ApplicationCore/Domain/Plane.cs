using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    //public enum PlaneType
    //{
    //    Boing,Airbus
    //}
    public class Plane
    {
        //public Plane(int capacity, DateTime manufactureDate, int planeId, PlaneType planeType)
        //{
        //    Capacity = capacity;
        //    ManufactureDate = manufactureDate;
        //    PlaneId = planeId;
        //    PlaneType = planeType;
        //}

        // #region exemple java
        // private int capacity;
        //  public int getCapacity() { return capacity; }
        // public void setCapacity(int capacity) { this.capacity = capacity; }
        // #endregion
        ////Light version using prop + 2 tab
        // public int Capacity { get; set; }

        // //Secure version using propg + 2 tab --> Pour ne pas faire de set
        // public int Capacity1 { get; private set; }

        // //Full version using propfull --> Pour initialisation
        // private int myVar;

        // public int MyProperty
        // {
        //     get { return myVar; }
        //     set { myVar = value; }
        // }
        [Range(0, int.MaxValue)]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        //prop de navigation
        public IList<Flight> Flights { get; set; }
        //méthode toString()
        public override string ToString()
        {
            return "Capacity : "+Capacity+"\n ManufactureDate : "+ManufactureDate+"\n PlaneType :"+PlaneType;
        }
        

    }
}
