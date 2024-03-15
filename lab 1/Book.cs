// 2-ой вариант вариант работы программы
class Book
{
    public string name;
    public string author;
    public int year;
    public int cnt;
    public Book(string name, string author, int year, int cnt)
    {
        this.name = name;
        this.author = author;
        this.year = year;
        this.cnt = cnt;
    }
    public Book()
    {
        name = "Евгений Онегин";
        author = "А.С. Пушкин";
        year = 1833;
        cnt = 1;
    }
    public void GetInformation()
    {
        if (name != "")
        {
            Console.WriteLine("Книга '{0}' Автор '{1}' Была издана в {2} году. Количество экземпляров книги = {3}", name, author, year,cnt);
        }
    }
}