using System;

namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            
            Book book1 = new Book("с#", "java", "cs", 3);
            Book book2 = new Book("html", "css", "js", 2);

           
            library.AddBook(book1);
            library.AddBook(book2);

           
            Reader reader1 = new Reader("leila", 1);
            Reader reader2 = new Reader("dias", 2);

            
            library.RegisterReader(reader1);
            library.RegisterReader(reader2);

        
            library.LendBook("cs", 1);

            
            library.ReturnBook("cs");

            
            library.RemoveBook("js");

            Console.WriteLine("Работа программы завершена.");
        }
    }
}



