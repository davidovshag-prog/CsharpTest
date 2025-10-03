namespace AbstractClass;

public class PersonProvider
{
    /// <summary>
    /// Можна проініціалізувати при створенні, або у конструкторі
    /// </summary>
    private readonly List<Person> _persons;
    public PersonProvider()
    {
        _persons = new List<Person>();
    }

    public void ListGeneration(int count = 10)
    {
        Random rnd = new Random();
        for (int i = 0; i < count; i++)
        {
            Person p;
            var item = rnd.Next(0, 2);
            if (item == 0)
                p = new Student();
            else
                p = new Teacher();
            _persons.Add(p);
        }
    }

    public void ShowAll()
    {
        foreach (Person p in _persons)
        {
            p.ViewInfo();
        }
    }
}
