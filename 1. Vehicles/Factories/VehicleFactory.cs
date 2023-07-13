using _1._Vehicles.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._Vehicles.Interfaces;

namespace _1._Vehicles.Factories
{
    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(string type, double fuelQuantity, double fuelConsumption,double tankCapacity)
        {
            switch (type)
            {
                case "Car":
                    return new Car(fuelQuantity, fuelConsumption,tankCapacity);
                case "Truck":
                    return new Truck(fuelQuantity, fuelConsumption, tankCapacity);
                case "Bus":
                    return new Bus(fuelQuantity, fuelConsumption, tankCapacity);
                    default:
                    throw new ArgumentException("Invalid vehicle type!");
            }
        }
    }
}
