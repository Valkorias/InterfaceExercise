using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class Suv : IVehicle, ICompany
    {
        public string Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public bool CargoHoldSize { get; set; }

        public bool GreaterTowingCapacity { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving in my {GetType().Name}");
        }
    }
}
