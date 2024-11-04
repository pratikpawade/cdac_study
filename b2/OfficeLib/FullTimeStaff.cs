namespace Office;

// sealed class FullTimeStaff : Staff
// {
    
// }

public class FullTimeStaff : Staff
{
    public string Department { get; set; }
    public double Salary { get; set; }

    public FullTimeStaff(string name, string address, string department, double salary)
        : base(name, address)
    {
        Department = department;
        Salary = salary;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"FullTimeStaff - Name: {Name}, Address: {Address}, Department: {Department}, Salary: {Salary}");
    }
}