using _1._Vehicles.Factories;
using _1._Vehicles.Interfaces;

const int numerOfVehicles = 3;
List<IVehicle> vehicles = new List<IVehicle>();

for (int i = 0; i < numerOfVehicles; i++)
{
    string[] vehicleInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    IVehicle vehicle = VehicleFactory.CreateVehicle(vehicleInfo[0], double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]), double.Parse(vehicleInfo[3]));
    vehicles.Add(vehicle);

}

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    
    string action = command[0];
    string vehicleType = command[1];
    double value = double.Parse(command[2]);
    try
    {
        if (vehicles.Contains(vehicles.FirstOrDefault(x => x.GetType().Name == vehicleType)))
        {
            if (action == "Drive")
            {
                vehicles.FirstOrDefault(x => x.GetType().Name == vehicleType).Drive(value);
            }
            else if (action == "Refuel")
            {
                vehicles.FirstOrDefault(x => x.GetType().Name == vehicleType).Refuel(value);
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    

}
foreach (var vehicle in vehicles)
{
    Console.WriteLine($"{vehicle.GetType().Name}: {vehicle.FuelQuantity:f2}");
}