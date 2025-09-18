class Edition
{
    public string Author { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public Edition(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
    public override string ToString()
    {
        return $"Печатное издание '{Title}' (автор {Author}) {Year} года";
    }
}
class Book : Edition
{
    public Book(string title, string author, int year) : base(title, author, year) { }
    public override string ToString()
    {
        return $"Книга '{Title}' (автор {Author}) {Year} года";
    }
}

class Journal : Edition
{
    public Journal(string title, string author, int year) : base(title, author, year) { }
    public override string ToString()
    {
        return $"Журнал '{Title}' {Year} года";
    }
}
class StudentBook : Edition
{
    public string Subject { get; set; }
    public StudentBook(string title, string author, int year, string subject) : base(title, author, year)
    {
        Subject = subject;
    }
    public override string ToString()
    {
        return $"Учебник '{Title}' по предмету '{Subject}' (автор {Author}) {Year} года";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Edition e = new Edition("Звезда", "Ю.Шатунов", 2000);
        Console.WriteLine(e);
        Book b = new Book("Война и мир", "Л.Н.Толстой", 1869);
        Console.WriteLine(b);
        Journal j = new Journal("Телесемь", "", 2025);
        Console.WriteLine(j);
        StudentBook s = new StudentBook("Геометрия 7-8 класс", "Л.С.Атасян", 2013, "Математика");
        Console.WriteLine(s);
        Console.ReadLine();
    }
}
