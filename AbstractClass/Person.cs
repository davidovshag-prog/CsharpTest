using Bogus;

namespace AbstractClass;

public abstract class Person
{
    // _ - позначка для програмiста, що це приватне поле
    private string _id = String.Empty;
    private string _name = String.Empty;
    private string _phone = String.Empty;

    // Конструктор захищений - можна використувувати у 
    // дочірніх класах
    protected Person()
    {
        _id = Guid.NewGuid().ToString();
        _name = "No name";
        _phone = "+38(000) 00 00 000";
    }

    protected Person(bool isRandom = false)
    {
        Faker faker = new Faker("uk");
        if (isRandom)
        {
            _id = Guid.NewGuid().ToString();
            _name = faker.Person.FullName;
            _phone = faker.Person.Phone;
        }
    }

    /// <summary>
    /// Virtual - можна перевизначити у дочірньому класі
    /// </summary>
    public virtual void ViewInfo()
    {
        Console.WriteLine("Id: " + _id);
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Phone: " + _phone);
    }
}
