using BookAPI.Database;
using BookAPI.Entities;

namespace BookAPI.Services
{
    public class BookService:IBookService
    {
        private readonly MyContext _context;
        public BookService()
        {
            _context = new MyContext();
        }
        public void AddBook(Book book)
        {
            try
            {
                _context.Books.Add(book);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Book> GetAllBooks()
        {
            try
            {
                return _context.Books.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Book> GetBookByAuthor(string Author)
        {
            try
            {
                List<Book> books = _context.Books.Where(book => book.Author == Author).ToList();
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Book> GetBookByLang(string lang)
        {
            try
            {
                List<Book> books = _context.Books.Where(book => book.Language == lang).ToList();
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Book> GetBookByYear(int year)
        {
            try
            {
                List<Book> books = _context.Books.Where(book => book.ReleaseDate.Value.Year == year).ToList();
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void UpdateBook(Book book)
        {
            try
            {
                _context.Books.Update(book);
                _context.SaveChanges(true);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeleteBook(int bookId)
        {
            try
            {
                Book boook = _context.Books.SingleOrDefault(book => book.BookId == bookId);
                _context.Books.Remove(boook);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
