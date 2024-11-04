namespace Office;

// public abstract class Staff
// {
    
// }

public abstract class Staff
{
    public string Name { get; set; }
    public string Address { get; set; }

    protected Staff(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public abstract void DisplayDetails();
}