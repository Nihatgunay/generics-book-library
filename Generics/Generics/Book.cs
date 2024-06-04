namespace Generics
{
    public class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }
        public int NumberCount { get; set; }

        public Book(string name, string authorName, int pageCount, string code, int numberCount)
        {
            if (!CheckBookCode(code, numberCount))
            {
                Console.WriteLine("Invalid code.");
            }

            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = code;
            NumberCount = numberCount;
        }
        public bool CheckBookCode(string code, int numbercount)
        {
            if (code[0] != Name[0])
            {
                if (!code.Trim().Contains((char)numbercount))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
