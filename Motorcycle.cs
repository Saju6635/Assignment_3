// Motorcycle Class
public class Motorcycle : Vehicle
{
    // properties
    public int EngineCapacity { get; set; }
    public string FuelType { get; set; }
    public bool HasFairing { get; set; }

    // rental information properties
    public double RentalPrice { get; private set; }
    public int RentedDays { get; private set; }

    // Constructor
    public Motorcycle(string model, string manufacturer, int year, double rentalPrice, int engineCapacity, string fuelType, bool hasFairing)
        : base(model, manufacturer, year)
    {
        EngineCapacity = engineCapacity;
        FuelType = fuelType;
        HasFairing = hasFairing;
        RentalPrice = rentalPrice;
    }

    // Method to display details including rental information
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Engine Capacity: {EngineCapacity} cc, Fuel Type: {FuelType}, Has Fairing: {HasFairing}");

        Console.WriteLine($"Rental Price: {RentalPrice:C}, Rented Days: {RentedDays}");
    }
}
