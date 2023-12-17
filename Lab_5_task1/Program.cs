using System;

namespace Lab_5_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportNetwork network = new TransportNetwork();
            
            Car car = new Car { Speed = 100, Capacity = 5 };
            Bus bus = new Bus { Speed = 60, Capacity = 30 };
            Train train = new Train { Speed = 120, Capacity = 200 };
            
            network.AddVehicle(car);
            network.AddVehicle(bus);
            network.AddVehicle(train);
            
            network.ControlMovement();
            
            Route route = new Route { StartPoint = "Kyiv", EndPoint = "Rivne" };
            
            Console.WriteLine("Car: " + route.CalculateOptimalRoute(car));
            Console.WriteLine("Bus: " + route.CalculateOptimalRoute(bus));
            Console.WriteLine("Train: " + route.CalculateOptimalRoute(train));
            
            Passenger passenger = new Passenger();
            
            passenger.Board(car);
            passenger.Alight(car);
            
            passenger.Board(bus);
            passenger.Alight(bus);
            
            passenger.Board(train);
            passenger.Alight(train);
        }
    }
}