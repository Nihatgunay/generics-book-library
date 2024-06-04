using static System.Reflection.Metadata.BlobBuilder;

namespace Generics
{
    public class Library
    {
        private int _bookcount;
        private Book[] Books;

        public Library()
        {
            Books = new Book[0];
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, _bookcount + 1);
            Books[^1] = book;
            Console.WriteLine($"Book {book.Name} was added");
        }

        public Book FindAllBooksByName(string value)
        {
            foreach (var bk in Books)
            {
                if (bk.Name.Trim().ToLower() == value.Trim().ToLower())
                {
                    return bk;
                }
            }
            return null;
        }

        public Book FindBookByCode(string code)
        {
            foreach (var bk in Books)
            {
                if (bk.Code.Trim().ToLower() == code.Trim().ToLower())
                {
                    return bk;
                }
            }
            return null;
        }

        public Book RemoveBookByCode(string value)
        {
            Book removebook = null;
            for (int i = 0; i < _bookcount; i++)
            {
                if (Books[i].Code.Trim().ToLower() == value.Trim().ToLower())
                {
                    removebook = Books[i];
                    for (int j = i; j < _bookcount - 1; j++)
                    {
                        Books[j] = Books[j + 1];
                    }
                    Array.Resize(ref Books, --_bookcount);
                    Console.WriteLine($"Book {removebook.Name} was removed");
                    break;
                }
            }
            return removebook;
        }
        
    }

}

