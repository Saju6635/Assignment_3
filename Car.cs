
public class Car : Vehicle
{
    // properties
    public int Seats { get; set; }
    public string EngineType { get; set; }
    public string Transmission { get; set; }
    public bool Convertible { get; set; }

    // rental information properties
    public double RentalPrice { get; private set; }
    public int RentedDays { get; private set; }

    // Constructor
    public Car(string model, string manufacturer, int year, double rentalPrice, int seats, string engineType, string transmission, bool convertible)
        : base(model, manufacturer, year)
    {
        Seats = seats;
        EngineType = engineType;
        Transmission = transmission;
        Convertible = convertible;
        RentalPrice = rentalPrice;
    }

    // Override display for car details
    public override void DisplayDetails()
    {
        base.DisplayDetails();

        Console.WriteLine($"Seats: {Seats}, Engine Type: {EngineType}, Transmission: {Transmission}, Convertible: {Convertible}");

        Console.WriteLine($"Rental Price: {RentalPrice:C}, Rented Days: {RentedDays}");
    }
}
