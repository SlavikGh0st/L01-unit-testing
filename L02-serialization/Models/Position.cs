namespace L02_serialization.Models;

public class Position
{
    public string Name { get; }
    public DateTime StartAt { get; }
    public Person Person { get; }

    public Position(string name, DateTime startAt, Person person)
    {
        Name = name;
        StartAt = startAt;
        Person = person;
    }
}