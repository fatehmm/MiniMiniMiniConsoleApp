namespace CitizenApp;

public class Employee:Human
{
    public Employee(string name, string surname):base(name, surname)
    {
            
    }

    public string Position;

    public override void ShowInfo()
    {
        Console.WriteLine($"{Position}");
    }
}