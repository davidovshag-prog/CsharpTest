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
    Console.WriteLine("----Teacher----");
    person.ViewInfo();
}
*/
PersonProvider provider = new PersonProvider();
provider.ListGeneration(12);
Console.WriteLine("---------Items View---------");
provider.ShowAll();

