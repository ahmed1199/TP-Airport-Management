using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.domain
{
    public static class TestData
    {

        /*public static List<Plane> Planes = new List<Plane>() 
        { 
        new Plane(){PlaneType=PlaneType.Boing, Capacity=150, ManufactureDate=new DateTime(2015,02,03)},
        new Plane(){PlaneType=PlaneType.Airbus, Capacity=250, ManufactureDate=new DateTime(2020,11,11)},
        };

        public static List<Staff> Staff = new List<Staff>()
        {

        }*/

        public static List<Plane> Planes = new List<Plane>()
        {
        new Plane(){PlaneType=PlaneType.Boing, Capacity=150, ManufactureDate=new DateTime(2015,02,03)},
        new Plane(){PlaneType=PlaneType.Airbus, Capacity=250, ManufactureDate=new DateTime(2020,11,11)},
        };
        //staff
        // Staffs
        public static List<Staff> Staff = new List<Staff>()
        {
         new Staff { FirstName = "captain", LastName = "captain", EmailAddress = "captain.captain@gmail.com", BirthDate = new DateTime(1965, 01, 01), EmployementDate = new DateTime(1999, 01, 01), Salary = 99999 },
          new Staff { FirstName = "hostess1", LastName = "hostess1", EmailAddress = "hostess1.hostess1@gmail.com", BirthDate = new DateTime(1995, 01, 01), EmployementDate = new DateTime(2020, 01, 01), Salary = 999 },
          new Staff { FirstName = "hostess2", LastName = "hostess2", EmailAddress = "hostess2.hostess2@gmail.com", BirthDate = new DateTime(1996, 01, 01), EmployementDate = new DateTime(2020, 01, 01), Salary = 999 },
        };
        // Travellers
        public static List<Traveller> Travellers = new List<Traveller>() {
         new Traveller { FirstName = "traveller1", LastName = "traveller1", EmailAddress = "traveller1.traveller1@gmail.com", BirthDate = new DateTime(1980, 01, 01), HealthInformation = "no troubles", Nationality = "American" },
         new Traveller { FirstName = "traveller2", LastName = "traveller2", EmailAddress = "traveller2.traveller2@gmail.com", BirthDate = new DateTime(1981, 01, 01), HealthInformation = "Some troubles", Nationality = "French" },
         new Traveller { FirstName = "traveller3", LastName = "traveller3", EmailAddress = "traveller3.traveller3@gmail.com", BirthDate = new DateTime(1982, 01, 01), HealthInformation = "no troubles", Nationality = "Tunisian" },
         new Traveller { FirstName = "traveller4", LastName = "traveller4", EmailAddress = "traveller4.traveller4@gmail.com", BirthDate = new DateTime(1983, 01, 01), HealthInformation = "Some troubles", Nationality = "American" },
         new Traveller { FirstName = "traveller5", LastName = "traveller5", EmailAddress = "traveller5.traveller5@gmail.com", BirthDate = new DateTime(1984, 01, 01), HealthInformation = "Some troubles", Nationality = "Spanish" },
        };

        public static List<Flight> Flights = new List<Flight>()
        {
            new Flight(){FlightDate=new DateTime(2022,01,01,15,10,10), Destination="Paris", EffectiveArrival=new DateTime(2022,01,01,17,10,10), plane=Planes[1], EstimatedDuration=110,Passengers=new List<Passenger>(Travellers)},
            new Flight(){FlightDate=new DateTime(2022,02,01,21,10,10), Destination="Paris", EffectiveArrival=new DateTime(2022,02,01,23,10,10), plane=Planes[0], EstimatedDuration=105,Passengers=null},
            new Flight(){FlightDate=new DateTime(2022,03,01,5,10,10), Destination="Paris", EffectiveArrival=new DateTime(2022,03,01,6,40,10), plane=Planes[0], EstimatedDuration=100,Passengers=null},
            new Flight(){FlightDate=new DateTime(2022,04,01,6,10,10), Destination="Madrid", EffectiveArrival=new DateTime(2022,04,01,8,10,10), plane=Planes[0], EstimatedDuration=130,Passengers=null},

        };
    }
}
