using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp //из принципов ооп использовала инкапсуляцию
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        private List<Reader> readers = new List<Reader>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Книга \"{book.GetTitle()}\" добавлена в библиотеку.");
        }

        public void RemoveBook(string isbn)
        {
            var bookToRemove = books.FirstOrDefault(b => b.GetIsbn() == isbn);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"Книга \"{bookToRemove.GetTitle()}\" удалена.");
            }
        }

        public void RegisterReader(Reader reader)
        {
            readers.Add(reader);
            Console.WriteLine($"Читатель {reader.GetName()} зарегистрирован.");
        }

        public void LendBook(string isbn, int readerId)
        {
            var book = books.FirstOrDefault(b => b.GetIsbn() == isbn);
            var reader = readers.FirstOrDefault(r => r.GetId() == readerId);

            if (book != null && reader != null && book.Borrow())
            {
                Console.WriteLine($"Книга \"{book.GetTitle()}\" выдана читателю {reader.GetName()}.");
            }
            else
            {
                Console.WriteLine("Невозможно выдать книгу (нет экземпляров или читатель не найден).");
            }
        }

        
        public void ReturnBook(string isbn)
        {
            var book = books.FirstOrDefault(b => b.GetIsbn() == isbn);
            if (book != null)
            {
                book.ReturnBook();
                Console.WriteLine($"Книга \"{book.GetTitle()}\" возвращена в библиотеку.");
            }
        }
    }
}
