using Bogus;

namespace AbstractClass;

public class Student : Person
{
    /// <summary>
    /// Дата вступу
    /// </summary>
    private DateTime _entryDate;
    /// <summary>
    /// Назва групи студента
    /// </summary>
    private string _group;

    public Student()
    {
        _entryDate = DateTime.Now;
        _group = "No group";
    }

    public Student(bool isRandom=false)
        : base(isRandom)
    {
        Faker faker = new Faker("uk");
        _group = "Group " + faker.Random.Int(1, 5);
    }

    public override void ViewInfo()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        base.ViewInfo();
        string strDate = _entryDate.ToString("dd.MM.yyyy");
        Console.WriteLine("Entry date: " + strDate);
        Console.WriteLine("Група: " + _group);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public override string ToString()
    {
        return $"Student: {_group}, дата вступу: {_entryDate:dd.MM.yyyy}";
    }
}

