using AbstractClass;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
/*
//Console.WriteLine("Привіт");

// Неможна створювати об'єкт абстрактного класу
Person person = new Student();
//Person teacher = new Teacher();

// as i is
if (person is Student)
{
    Console.WriteLine("----Student----");
    person.ViewInfo();
}
else if (person is Teacher)
    {
    Console.WriteLine("----Teacher-=---");
    person.ViewInfo();
}
*/
try
{
    PersonProvider provider = new PersonProvider();
    provider.ListGeneration(5);

    Console.WriteLine("--------- Створено ---------");
    provider.ShowAll();

    using (FileStream fs = new FileStream("people.txt", FileMode.Create))
    {
        provider.WriteAllToFile(fs);
    }

    using (FileStream fs = new FileStream("people.txt", FileMode.Open))
    {
        provider.ReadAllFile(fs);
    }

    Console.WriteLine("--------- Після зчитування ---------");
    provider.ShowAll();

    Console.WriteLine("--------- ToString тест ---------");
    Person s = new Student(true);
    Person t = new Teacher(true);
    Console.WriteLine(s.ToString());
    Console.WriteLine(t.ToString());
}
catch (Exception ex)
{
    Console.WriteLine("Помилка: " + ex.Message);
}

