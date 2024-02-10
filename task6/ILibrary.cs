namespace task6;

public interface ILibrary
{

    public void AddBook(Book book);

    public void DisplayBooks ();

    public void UpdateBook(Book book);

    public void DeleteBook(int  id);

    public void SearchByTitle(string title);
    public  void SearchByAuthor(string autor);
    



}
