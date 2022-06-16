namespace CitizenApp;

public class Student:Human
{
    public Student(string name, string surname):base(name, surname)
    {
            
    }

    public int Grade;
    public int GroupNo;

    public override void ShowInfo()
    {
        Console.WriteLine($"{Grade} , {GroupNo}");
    }
}