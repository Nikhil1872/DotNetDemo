using BookManagement.DAL;
using BookManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {

            List<Book> blist = BookDAL.GetListOfBooks();
            return View(blist);
        }
        [HttpGet]

        public IActionResult Create() {
            return View();
                }

        
    }
}
