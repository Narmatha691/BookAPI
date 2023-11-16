using BookAPI.Entities;

namespace BookAPI.Services
{
    public interface IBookService
    {
        void AddBook (Book book);
        List<Book> GetAllBooks();
        List<Book> GetBookByAuthor(string Author);
        List<Book> GetBookByLang(string lang);
        List<Book> GetBookByYear(int year);
        void UpdateBook (Book book);
        void DeleteBook (int bookId);

    }
}
