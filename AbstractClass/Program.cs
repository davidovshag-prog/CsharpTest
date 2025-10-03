using AbstractClass;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Привіт");

// Неможна створювати об'єкт абстрактного класу
Person person = new Student();


person.ViewInfo();