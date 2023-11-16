using BookAPI.Services;
using BookAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;
        public BookController()
        { 
            bookService = new BookService();
        }
        [HttpPost,Route("AddBook")]
        public IActionResult AddBook([FromBody] Book book)
        {
            try
            {
                bookService.AddBook(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet,Route("GetAllBooks")]
        public IActionResult GetAll()
        {
            try
            {
                List<Book> books = bookService.GetAllBooks();
                return StatusCode(200, books);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet, Route("GetBookByAuthor/{author}")]
        public IActionResult GetByAuthor(string author)
        {
            try
            {
                List<Book> book = bookService.GetBookByAuthor(author);
                if (book.Count != 0 != null)
                    return StatusCode(200, book);
                else
                    return StatusCode(404, new JsonResult("Author not found"));
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet, Route("GetBookByLanguage/{lang}")]
        public IActionResult GetByLanguage(string lang)
        {
            try
            {
                List<Book> book = bookService.GetBookByLang(lang);
                if (book.Count != 0)
                    return StatusCode(200, book);
                else
                    return StatusCode(404, new JsonResult("Lamguage not found"));
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet, Route("GetBookByYear/{year}")]
        public IActionResult GetBookByYear(int year)
        {
            try
            {
                Console.WriteLine(year);
                List<Book> book = bookService.GetBookByYear(year);
                Console.WriteLine(book.Count);
                if (book.Count != 0)
                    return StatusCode(200, book);
                else
                    return StatusCode(404, new JsonResult("Year not found"));
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut,Route("EditBook")]
        public IActionResult EditBook(Book book) 
        {
            try
            {
                bookService.UpdateBook(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete,Route("DeleteBook/{bookId}")]
        public IActionResult DeleteBook(int bookId) 
        {
            try
            {
                bookService.DeleteBook(bookId);
                return StatusCode(200, new JsonResult($"Bookid {bookId} is Deleted"));
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
    }
}
