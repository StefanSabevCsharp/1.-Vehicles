using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Vehicles.Interfaces
{
    public interface IVehicle
    {
        double FuelQuantity { get; }
        double FuelConsumption { get; }
        double TraveledDistance { get; }
        double TankCapacity { get; }
        void Drive(double distance);
        void Refuel(double fuelAmount);
    }
}
