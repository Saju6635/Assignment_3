// Vehicle Class
public abstract class Vehicle
{
    //Vehicle class Properties
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public int Year { get; set; }


    // Constructors
    public Vehicle(string model, string manufacturer, int year)
    {
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
    }

    // Abstract method to display the details of vehicle
    public abstract void DisplayDetails();
}
