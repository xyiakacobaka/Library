//2-ой вариант работы программы
class Library
{
    public int lol = 0;
    public List<Book> books = new List<Book> { };
    private string filterName, filterAuthor;
    private int addcnt;
    public delegate void MethodContainer();
    public event MethodContainer onAdd;
    public event MethodContainer onDel;
    public void add(Book bnew)
    {
        filterName = bnew.name;
        filterAuthor = bnew.author;
        addcnt = bnew.cnt;
        if (PredicateNameAndAuthor() == true)
        {
            books.Add(bnew);
            if (lol==1) 
            {
                onAdd(); 
            }
            lol += 1;
        }
    }
    public void del(string author)
    {
        filterAuthor = author;
        books.RemoveAll(PredicateAuthor);
        onDel();
    }
    private bool PredicateNameAndAuthor()
    {
        int y_or_n = 1;
        foreach (Book book in books)
        {
            if (book.name != filterName)
            {
                y_or_n *= 1;
            }
            else
            {
                book.cnt += addcnt;
                y_or_n *= 0;
            }
        }
        if (y_or_n == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private bool PredicateAuthor(Book bk)
    {
        if (bk.author == filterAuthor)
            return true;
        else
            return false;
    }
}
/*1-ый вариант вариант работы программы
class Library
{
    public List<Book> books = new List<Book> { };
    private string filterName, filterAuthor;
    public delegate void MethodContainer();
    public event MethodContainer onAdd;
    public void add(Book b4)
    {
        filterName = b4.name;
        filterAuthor = b4.author;
        Book b5 = new Book("", "", 0);
        if (PredicateNameAndAuthor() == true)
        {
            books.Add(b4);
            onAdd();
        }
        else
        {
            books.Add(b5);
        }
    }
    private bool PredicateNameAndAuthor()
    {
        int y_or_n=1;
        foreach (Book book in books)
        {
            if (book.name != filterName && book.author != filterAuthor)
            {
                y_or_n *= 1;
            }
            else
            {
                y_or_n *= 0;
            }
        }
        if (y_or_n == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
*/

/* Исходник
class Library
{
    public List<Book> books = new List<Book> { };
    private string filterAuthor;
    public delegate void MethodContainer();
    public event MethodContainer onDel;
    public List<Book> fnd(string author)
    {
        filterAuthor = author;
        List<Book> res = books.FindAll(PredicateAuthor);
        return res;
    }
    public void del(string author)
    {
        filterAuthor = author;
        books.RemoveAll(PredicateAuthor);
        onDel();
    }
    
}
*/