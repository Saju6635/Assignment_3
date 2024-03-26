using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Motorcycle : Vehicle
    {
        // properties
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public bool HasFairing { get; set; }

        // Constructor
        public Motorcycle(string model, string manufacturer, int year, double rentalPrice, int engineCapacity, string fuelType, bool hasFairing)
            : base(model, manufacturer, year, rentalPrice)
        {
            EngineCapacity = engineCapacity;
            FuelType = fuelType;
            HasFairing = hasFairing;
        }

        // display motorcycle details
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Engine Capacity: {EngineCapacity} cc, Fuel Type: {FuelType}, Has Fairing: {HasFairing}");
        }
    }
}
