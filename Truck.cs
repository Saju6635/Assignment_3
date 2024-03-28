// Truck Class

public class Truck : Vehicle
{
    // properties
    public int Capacity { get; set; }
    public string TruckType { get; set; }
    public bool FourWheelDrive { get; set; }

    // rental information properties
    public double RentalPrice { get; private set; }
    public int RentedDays { get; private set; }

    // Constructor
    public Truck(string model, string manufacturer, int year, double rentalPrice, int capacity, string truckType, bool fourWheelDrive)
        : base(model, manufacturer, year)
    {
        Capacity = capacity;
        TruckType = truckType;
        FourWheelDrive = fourWheelDrive;
        RentalPrice = rentalPrice;
    }

    // Method to display details including rental information
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Capacity: {Capacity} tons, Truck Type: {TruckType}, Four Wheel Drive: {FourWheelDrive}");
        Console.WriteLine($"Rental Price: {RentalPrice:C}, Rented Days: {RentedDays}");
    }
}
