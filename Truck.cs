using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Truck : Vehicle
    {
        //properties
        public double Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }

        // Constructor
        public Truck(string model, string manufacturer, int year, double rentalPrice, double capacity, string truckType, bool fourWheelDrive)
            : base(model, manufacturer, year, rentalPrice)
        {
            Capacity = capacity;
            TruckType = truckType;
            FourWheelDrive = fourWheelDrive;
        }

        // Override display for truck details
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Capacity: {Capacity} tons, Truck Type: {TruckType}, Four Wheel Drive: {FourWheelDrive}");
        }
    }
}
