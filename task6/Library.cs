namespace task6;

public class Library : ILibrary
{
    list<Book> books = new list<Book>();
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void DeleteBook(int book)
    {
        foreach (var item in books)
        {
            if(item==book)
           {
            System.Console.WriteLine(books.Remove(item));
           }
        }
    }

    public void DisplayBooks()
    {
       
         foreach (var item in books)
        {
            
           
            System.Console.WriteLine(item);
           
        }
    }

    public void SearchByAuthor(string autor)
    {
         foreach (var item in autor)
         {
            if()
         }
    }

    public void SearchByTitle(string title)
    {
        throw new NotImplementedException();
    }

    public void UpdateBook(Book book)
    {
        throw new NotImplementedException();
    }
}
