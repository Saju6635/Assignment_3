using System;

class Program
{
    static void Main(string[] args)
    {
        //instances

        Car car1 = new Car("X6", "BMW", 2021, 70, 6, "Petrol", "Automatic", false);
        Truck truck1 = new Truck("Figo", "Ford", 2017, 50, 5, "pickup", true);
        Motorcycle bike1 = new Motorcycle("1000rr", "Aprilla", 2020, 30, 1000, "Petrol", true);

        // Create Rental Agency

        RentalAgency rentalAgency = new RentalAgency(10);

        int choice;
        do
        {
            // Display options
            Console.WriteLine("\nPleasse select an option:");

            Console.WriteLine("1. Rent a Vehicle");
            Console.WriteLine("2. Add a Vehicle");
            Console.WriteLine("3. Exit");
            Console.Write("Please enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Rent a vehicle

                    RentVehicle(rentalAgency, car1, truck1, bike1);
                    break;

                case 2:
                    // Add a vehicle

                    AddVehicle(rentalAgency);
                    break;

                case 3:
                    // Exit
                    Console.WriteLine("Exiting the program");
                    break;

                default:
                    Console.WriteLine("Invalid choice entered");
                    break;
            }
        } while (choice != 3);
    }

    
    static void RentVehicle(RentalAgency rentalAgency, Car car1, Truck truck1, Motorcycle bike1)
    {
        // Display vehicle details
        Console.WriteLine("Vehicles Available:");
        Console.WriteLine("1. Car");
        car1.DisplayDetails();

        Console.WriteLine("2. Truck");
        truck1.DisplayDetails();

        Console.WriteLine("3. Motorcycle");
        bike1.DisplayDetails();

        // Prompt user 
        Console.WriteLine("\nEnter the number of the vehicle you want to rent:");
        int choice = int.Parse(Console.ReadLine());

        Vehicle selectedVehicle = null;
        switch (choice)
        {
            case 1:
                selectedVehicle = car1;
                break;
            case 2:
                selectedVehicle = truck1;
                break;
            case 3:
                selectedVehicle = bike1;
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        if (selectedVehicle != null)
        {
            // Prompt user for the number of  days
            Console.WriteLine("Enter the number of days you want to rent the vehicle:");
            int days = int.Parse(Console.ReadLine());

            // Rent selected vehicles
            rentalAgency.RentVehicle(selectedVehicle, days);

            // selected vehicle from the fleet removal
            rentalAgency.RemoveVehicle(selectedVehicle);

            // Add the rented vehicle to the rental list based on its type given
            if (selectedVehicle is Car)
            {
                rentalAgency.AddRentedCar(selectedVehicle as Car, days);
            }
            else if (selectedVehicle is Truck)
            {
                rentalAgency.AddRentedTruck(selectedVehicle as Truck, days);
            }
            else if (selectedVehicle is Motorcycle)
            {
                rentalAgency.AddRentedMotorcycle(selectedVehicle as Motorcycle, days);
            }
        }
    }


    // Method to add a vehicle
    static void AddVehicle(RentalAgency rentalAgency)
    {
        Console.WriteLine("Select vehicle type to add:");

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
                Console.WriteLine("Car added successfully.");
                break;
            case 2:
                // Add a truck
                Truck newTruck = new Truck();
                rentalAgency.AddVehicle(newTruck);
                Console.WriteLine("Truck added successfully.");
                break;
            case 3:
                // Add a motorcycle
                Motorcycle newMotorcycle = new Motorcycle();
                rentalAgency.AddVehicle(newMotorcycle);
                Console.WriteLine("Motorcycle added successfully.");
                break;
            default:
                Console.WriteLine("Invalid choice entered!");
                break;
        }
    }
}
