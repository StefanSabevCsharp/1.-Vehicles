using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double airConditionerConsumption = 1.6;
        private const double refuelCoefficient = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption,double tankCapacity)
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
            base.Refuel(fuelAmount * refuelCoefficient);
        }
    }
}
