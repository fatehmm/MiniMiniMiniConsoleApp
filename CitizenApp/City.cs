namespace CitizenApp;

public interface ICity
{
    Human[] Humans { get; }

    public abstract void AddHuman(Human human);


    public abstract Human[] SearchHumans(string word);


}