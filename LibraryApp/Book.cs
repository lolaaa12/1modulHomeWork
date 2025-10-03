namespace LibraryApp
{
    public class Book
    {
        private string title;
        private string author;
        private string isbn;
        private int copies;

        public Book(string title, string author, string isbn, int copies)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.copies = copies;
        }

        public string GetTitle() => title;
        public string GetAuthor() => author;
        public string GetIsbn() => isbn;
        public int GetCopies() => copies;

        
        public bool Borrow()
        {
            if (copies > 0)
            {
                copies--;
                return true;
            }
            return false;
        }

        public void ReturnBook()
        {
            copies++;
        }
    }
}
