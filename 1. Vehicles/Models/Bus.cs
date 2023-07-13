using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double airConditionerConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }
        public override double FuelConsumption => base.FuelConsumption + airConditionerConsumption;

        public override void Drive(double distance)
        {

            base.Drive(distance);
        }
        public override void Refuel(double fuelAmount)
        {
            base.Refuel(fuelAmount);
        }
        public void DriveEmpty(double distance)
        {
            double neededFuel = distance * base.FuelConsumption;
            if (neededFuel <= base.FuelQuantity)
            {
                base.FuelQuantity -= neededFuel;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");
            }
        }

    }
}
