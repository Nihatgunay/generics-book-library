namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("harry potter", "Rowling", 400, "H12", 12);
            Book book2 = new Book("lord of the rings", "somebody", 300, "l23", 23);
            Library library = new();
            library.AddBook(book1);
            library.AddBook(book2);
            library.FindAllBooksByName("  Harry poTter");
            library.FindBookByCode("l23");
            library.RemoveBookByCode("h12");

        }
    }
    
}
