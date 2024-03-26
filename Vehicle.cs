using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Vehicle
    {
        // vechile class Properties
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public double RentalPrice { get; set; }

        // Constructors
        public Vehicle(string model, string manufacturer, int year, double rentalPrice)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalPrice;
        }

        // Method to display the details of vechiles available
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}, Rental Price:${RentalPrice}");
        }
    }
}
