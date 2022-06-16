namespace CitizenApp;

public class Baku:ICity
{
    public Human[] humans = new Human[0];
    public Human[] Humans {
        get
        {
            return humans;
        }
        
        
    }
    public void AddHuman(Human human)
    {
        Array.Resize(ref humans, Humans.Length+1);
        humans[humans.Length - 1] = human;
    }

    public Human[] SearchHumans(string word)
    {
        Human[] humansSearched = new Human[0];
        for (int i = 0; i < Humans.Length; i++)
        {
            string fullname = Humans[i].Name + " " + Humans[i].Surname;
            if (fullname.Contains(word))
            {
                Array.Resize(ref humans, humans.Length+1);
                humans[humans.Length - 1] = Humans[i];
            }
        }

        return humansSearched;
    }

    public Human[] GetStudents()
    {
        Human[] humansStd = new Human[0];
        for (int i = 0; i < humans.Length; i++)
        {
            if (humans[i] is Student)
            {
                Array.Resize(ref humansStd, humansStd.Length+1);
                humansStd[humansStd.Length - 1] = humans[i];
            }
        }

        return humansStd;
    }
    
    public Human[] GetEmployees()
    {
        Human[] humansStd = new Human[0];
        for (int i = 0; i < humans.Length; i++)
        {
            if (humans[i] is Employee)
            {
                Array.Resize(ref humansStd, humansStd.Length+1);
                humansStd[humansStd.Length - 1] = humans[i];
            }
        }

        return humansStd;
    }
}