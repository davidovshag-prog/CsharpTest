namespace AbstractClass;

public class Teacher : Person
{
    /// <summary>
    /// Предмет
    /// </summary>
    private string _subject = String.Empty;
    /// <summary>
    /// Посада
    /// </summary>
    private string _position = String.Empty;
    /// <summary>
    /// Зарплата
    /// </summary>
    private decimal _salary;

    public Teacher()
    {
        _subject = "Програмування c#";
        _position = "Куди вітер дує";
        _salary = 0;
    }
    public override void ViewInfo()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        base.ViewInfo();
        Console.WriteLine($"Предмети {_subject}");
        Console.WriteLine($"Посада {_position}");
        Console.WriteLine($"Зарплата {_salary}");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
