using _1._Vehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _1._Vehicles.Models
{
    public class Vehicle : IVehicle
    {

        double fuelQuantity;
        double fuelConsumption;
        double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; protected set; }


        public virtual double FuelConsumption
        {
            get => fuelConsumption;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("FuelConsumption must be a positive number");
                }
                fuelConsumption = value;
            }
        }

        public double TraveledDistance { get; private set; }

        public double TankCapacity { get; private set; }

        public virtual void Drive(double distance)
        {
            if (fuelQuantity >= distance * FuelConsumption)
            {
                fuelQuantity -= distance * FuelConsumption;
                TraveledDistance += distance;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }




        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if(fuelAmount + fuelQuantity > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {fuelAmount} fuel in the tank");
            }
            else
            {
                fuelQuantity += fuelAmount;

            }
        }
    }
}
