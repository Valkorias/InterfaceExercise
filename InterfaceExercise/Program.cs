using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region InterfaceRegion

            Car myFirstCar = new Car { Year = "2022", Make = "Ford", Model = "Mustang", HasTrunk = true, LowerDrivingPosition = true };
            Truck myFirstTruck = new Truck { Year = "2010", Make = "Ford", Model = "Ranger", HasTruckBed = true, HasSideCart = true };
            Suv myFirstSuv = new Suv { Year = "2023", Make = "Ford", Model = "Mustang Mach-E", CargoHoldSize = true , GreaterTowingCapacity = true};

            List<IVehicle> vehicles = new List<IVehicle>();
            
            vehicles.Add(myFirstCar);
            vehicles.Add(myFirstTruck);
            vehicles.Add(myFirstSuv);

            foreach (IVehicle vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model}");
                Console.WriteLine();
                Console.WriteLine();
                vehicle.Drive();
                vehicle.DriveDefault();
                Console.WriteLine();
            }

            #endregion

            Console.ReadLine();
        }
    }
}
