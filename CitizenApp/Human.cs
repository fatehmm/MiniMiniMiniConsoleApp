namespace CitizenApp;

public class Human
{
    public Human(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }

    private string _name;
    private string _surname;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            bool check = true;
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    check = false;
                }
            }

            if (check)
            {
                _name = value;
            }
        }
    }
    public string Surname
    {
        get
        {
            return _surname;
        }
        set
        {
            bool check = true;
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    check = false;
                }
            }

            if (check)
            {
                _surname = value;
            }
        }
    }
    public int Age;

    public virtual void ShowInfo()
    {
        Console.WriteLine($"{Name} {Surname} - {Age}");
    }


}