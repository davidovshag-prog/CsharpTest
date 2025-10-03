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
                p = new Student(true);
            else
                p = new Teacher(true);
            _persons.Add(p);
        }
    }

    /// <summary>
    /// Записує усіх осіб у файл
    /// </summary>
    /// <param name="stream">Вказівник на потік</param>
    public void WriteAllToFile(Stream stream)
    {
        
    }
    /// <summary>
    /// Читання із файлу через потік
    /// </summary>
    /// <param name="stream">Вказівник на потік</param>
    public void ReadAllFile(Stream stream)
    {

    }

    public void ShowAll()
    {
        foreach (Person p in _persons)
        {
            p.ViewInfo();
        }
    }
}
