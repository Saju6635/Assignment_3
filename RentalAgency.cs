
using System;

// RentalAgency Class
public class RentalAgency
{
    // array for storing fleet
    private Vehicle[] Fleet { get; set; }
    public double TotalRevenue { get; private set; }

    // Constructor
    public RentalAgency(int capacity)
    {
        Fleet = new Vehicle[capacity];
        TotalRevenue = 0;
    }

    // add vechicle method
    public void AddVehicle(Vehicle vehicle)
    {
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] == null)
            {
                Fleet[i] = vehicle;
                return;
            }
        }

        Console.WriteLine("Cannot add more vehicles because the fleet is full.");
    }

    // remove vehicle from fleet method
    public void RemoveVehicle(Vehicle vehicle)
    {
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] == vehicle)
            {
                Fleet[i] = null;
                return;
            }
        }

        Console.WriteLine("this vehicle is not found in fleet");
    }

    // Method to rent a vehicle
    public void RentVehicle(Vehicle vehicle, int days)
    {
        double rentalCost = vehicle.RentalPrice * days;
        TotalRevenue += rentalCost;

        Console.WriteLine($"Vehicle rented for {days} days. Rental cost is: {rentalCost:C}");
    }

    // Method to add a vehicle
    static void AddVehicle(RentalAgency rentalAgency)
    {
        Console.WriteLine("Select the vehicle type to add:)");

        Console.WriteLine("1. Car");
        Console.WriteLine("2. Truck");
        Console.WriteLine("3. Motorcycle");
        Console.Write("Enter your choice: ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Add a car

                Car newCar = new Car();
                rentalAgency.AddVehicle(newCar);
                Console.WriteLine("Car is added successfully.");
                break;

            case 2:
                // Add a truck

                Truck newTruck = new Truck();
                rentalAgency.AddVehicle(newTruck);
                Console.WriteLine("Truck is added successfully.");
                break;

            case 3:
                // Add a motorcycle

                Motorcycle newMotorcycle = new Motorcycle();
                rentalAgency.AddVehicle(newMotorcycle);
                Console.WriteLine("Motorcycle is added successfully.");
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

}
