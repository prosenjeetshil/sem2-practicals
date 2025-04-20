using _30_CoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace _30_CoreMVC.Controllers
{
    public class BooksController : Controller
    {
        public static List<Book> Books = new List<Book>
        {
            new Book { Id = 1, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Fiction", Year = 1951 },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", Year = 1960 },
            new Book { Id = 3, Title = "1984", Author = "George Orwell", Genre = "Dystopian", Year = 1949 },
            new Book { Id = 4, Title = "Moby Dick", Author = "Herman Melville", Genre = "Adventure", Year = 1851 }
        };

        public IActionResult Index()
        {
            return View(Books);
        }

        public IActionResult Details(int id)
        {
            var book = Books.Find(b => b.Id == id);
            if (book == null)
                return NotFound();
            return View(book);
        }
    }
}
