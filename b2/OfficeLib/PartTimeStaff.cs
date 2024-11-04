namespace Office;

// sealed class PartTimeStaff : Staff
// {
    
// }

public class PartTimeStaff : Staff
{
    public int NumberOfHours { get; set; }
    public double RatePerHour { get; set; }

    public PartTimeStaff(string name, string address, int numberOfHours, double ratePerHour)
        : base(name, address)
    {
        NumberOfHours = numberOfHours;
        RatePerHour = ratePerHour;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"PartTimeStaff - Name: {Name}, Address: {Address}, Number of Hours: {NumberOfHours}, Rate per Hour: {RatePerHour}");
    }
}