using System.Text;

namespace AbstractClass;

public class PersonProvider
{
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
    /// Записує усіх користувачів у файл (текстом)
    /// </summary>
    public void WriteAllToFile(Stream stream)
    {
        using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8, leaveOpen: true))
        {
            foreach (Person p in _persons)
            {
                // Тип (Student або Teacher)
                writer.WriteLine(p.GetType().Name);

                // Виводимо усю інформацію у одну лінію
                if (p is Student s)
                {
                    writer.WriteLine($"Student|{s.GetHashCode()}");
                }
                else if (p is Teacher t)
                {
                    writer.WriteLine($"Teacher|{t.GetHashCode()}");
                }
            }
        }
        Console.WriteLine(" Дані записані у файл (текстом).");
    }

    /// <summary>
    /// Читання із файлу через потік (текстом)
    /// </summary>
    public void ReadAllFile(Stream stream)
    {
        _persons.Clear();

        using (StreamReader reader = new StreamReader(stream, Encoding.UTF8, leaveOpen: true))
        {
            while (!reader.EndOfStream)
            {
                string? type = reader.ReadLine();
                string? data = reader.ReadLine();

                if (type == "Student")
                {
                    _persons.Add(new Student(true));
                }
                else if (type == "Teacher")
                {
                    _persons.Add(new Teacher(true));
                }
            }
        }

        Console.WriteLine("Дані зчитані з файлу (текстом).");
    }

    public void ShowAll()
    {
        foreach (Person p in _persons)
        {
            p.ViewInfo();
            Console.WriteLine("-------------------");
        }
    }
}