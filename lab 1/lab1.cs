//2-ой вариант вариант работы программы
class lab1
{
    static void Main(string[] args)
    {
        Book b1 = new Book("Война и мир", "Л.Н.Толстой", 1869,1);//Новая книга
        Book b2 = new Book();//Новая книга
        Book b3 = new Book("Филипок", "Л.Н.Толстой", 1875,1);//Новая книга
        Library bibl1 = new Library(); //создание новой библиотеки
        Handler1 h1 = new Handler1();
        Handler2 h2 = new Handler2();
        bibl1.books.AddRange(new Book[] { b1, b2, b3 });//заполнение коллекции
        while (true)
        {
            bibl1.onDel += h1.Message;//метод сигнатура которого совпадает с сигнатурой делегата удаления книг в коллекцию библиотеки
            bibl1.onAdd += h2.Message; //метод сигнатура которого совпадает с сигнатурой делегата добавление книг в коллекцию библиотеки
            Console.WriteLine("Добавление(1 или Добавление) | Удаление(2 или Удаление) | Вывести коллекцию библиотеки(3 или Коллекция) | Прекратить работу программы(4 или Конец)");
            string mode = Console.ReadLine();
            if (mode == "Добавление" || mode == "1")
            {
                while (true)
                {
                    Console.WriteLine("\nВведите наазвание книги");
                    string book = Console.ReadLine();
                    book = check(book);
                    Console.WriteLine("Введите автора");
                    string author = Console.ReadLine();
                    author = check(author);
                    Console.WriteLine("Введите год издания");
                    string year = Console.ReadLine(); 
                    year = check(year);
                    Console.WriteLine("Введите количество книг");
                    string cnt = Console.ReadLine();
                    year = check(cnt);
                    Book bnew = new Book(book, author, Int32.Parse(year), Int32.Parse(cnt));//Новая книга
                    bibl1.add(bnew);//добавление книги
                    Console.WriteLine();
                    Console.WriteLine("Еще добавить книгу? Да(Да или 1) | Нет(Нет или 0)");
                    string addbk = Console.ReadLine();
                    Console.WriteLine();
                    if(addbk=="Да" || addbk == "1")
                    {
                        continue;
                    }
                    else if(addbk == "Нет" || addbk == "0")
                    {
                        break;
                    }
                }
            }
            else if (mode == "2" || mode == "Удаление")
            {
                Console.WriteLine("Введите инициалы и фамилию автора, книги котороги требуется удалить");
                Console.WriteLine("\nПример удаления книг:");
                Console.WriteLine("Л.Н.Толстой\n");
                while (true)
                {
                    string author = Console.ReadLine();
                    bibl1.del(author);//удаление книг
                    Console.WriteLine();
                    Console.WriteLine("Еще удалить книги? Да(Да или 1) | Нет(Нет или 0)");
                    string delbk = Console.ReadLine();
                    if (delbk == "Да" || delbk == "1")
                    {
                        continue;
                    }
                    else if (delbk == "Нет" || delbk == "0")
                    {
                        break;
                    }
                }
            }
            else if(mode == "3" || mode == "Коллекция")
            {
                Console.WriteLine("\nРазмер массива коллекций = {0}", bibl1.books.Count());//Вывод размера коллекции
                Console.WriteLine();//Разделяющая строка
                foreach (Book b in bibl1.books)//Цикл, который проходится по элементам коллекции и заносит их в переменную b
                {
                    b.GetInformation();//Вывод книги из коллекции
                }
                Console.WriteLine();
            }
            else if(mode == "4" || mode == "Конец")
            {
                break;
            }
            else
            {
                Console.WriteLine("Неправильно введенна функция.\n");
            }
        }
    }
    static string check(string param)
    {
        while (param == "")
        {
            Console.WriteLine("Проверьте введенный аргумент");
            param = Console.ReadLine();
        }
        return param;
    }
    /*static string Check_year(string param)
    {
        while (param == "")
        {
            while ((Int32.Parse(param)! > -1 && Int32.Parse(param)! < 2025))
            {
                Console.WriteLine("Проверьте введенный аргумент");
                param = Console.ReadLine();
            }
        }
        return param;
    }
    static string Check_cnt(string param)
    {
        while (Int32.Parse(param) !> -217448363 && Int32.Parse(param) ! < 217448365)
        {
            Console.WriteLine("Проверьте введенный аргумент");
            param = Console.ReadLine();
        }
        return param;
    }*/
}
