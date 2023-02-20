using AM.Application;
using AM.Application.Domain;
using static AM.Application.Domain.Plane;

Plane p1= new Plane();

p1.Capacity = 30;
p1.ManufactureDate = new DateOnly(2001, 05, 15);
p1.PlaneType = PlaneType.Boing;
p1.PlaneId= 2;

Console.WriteLine(p1);

Plane p2 = new Plane(15, new DateOnly(2000, 02, 22), PlaneType.Airbus);

Console.WriteLine(p2);

Passenger passenger= new Passenger();
passenger.PassengerType();

Staff staff= new Staff();
staff.PassengerType();

Traveller traveller= new Traveller();
traveller.PassengerType();

Console.WriteLine("Hello, World!");