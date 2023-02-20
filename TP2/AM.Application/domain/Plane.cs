using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.domain
{   
    public class Plane
    {
        public int? Capacity { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public int? PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }

        public List<Flight>? Flights { get; set;}

       
        public Plane()
        {

        }

        public Plane(int? capacity, DateTime? manufactureDate, PlaneType planeType)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            PlaneType = planeType;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
public enum PlaneType
{
    Boing,
    Airbus
}
