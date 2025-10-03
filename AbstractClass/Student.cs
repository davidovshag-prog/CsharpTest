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

    public override void ViewInfo()
    {
        base.ViewInfo();
        string strDate = _entryDate.ToString("dd.MM.yyyy");
        Console.WriteLine("Entry date: " + strDate);
        Console.WriteLine("Група: " + _group);
    }
}

