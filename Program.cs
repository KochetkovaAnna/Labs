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
    public void Info()
    {
        Console.WriteLine("Печатное издание '{0}' (автор {1}) {2} года", Title, Author, Year);
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
    public void Info()
    {
        Console.WriteLine("Журнал '{0}' {1} года", Title, Year);
    }
}
class StudentBook : Edition
{
    public string Subject { get; set; }
    public StudentBook(string title, string author, int year, string subject) : base(title, author, year)
    {
        Subject = subject;
    }
    public void Info()
    {
        Console.WriteLine("Учебник '{0}' по предмету '{3}' (автор {1}) {2} года", Title, Author, Year, Subject);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Edition e = new Edition("Звезда", "Ю.Шатунов", 2000);
        e.Info();
        Book b = new Book("Война и мир", "Л.Н.Толстой", 1869);
        Console.WriteLine(b);
        Journal j = new Journal("Телесемь", "", 2025);
        j.Info();
        StudentBook s = new StudentBook("Геометрия 7-8 класс", "Л.С.Атасян", 2013, "Математика");
        s.Info();
        Console.ReadLine();
    }
}
