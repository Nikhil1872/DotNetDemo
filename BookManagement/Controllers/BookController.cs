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
            Console.WriteLine("in create in ctrl");
            return View();
                }

        [HttpPost]
        public IActionResult Create(Book b)
        {
            int res = BookDAL.InsertData(b);

            if(res>0)
            {
                Console.WriteLine("in create in insert(bOOK B) in ctrl");
                ViewData["msg"] = "Book Added successfully";
                return View ("Success");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Book b = BookDAL.GetBook(id);
            return View(b);
        }

        [HttpPost]
        public IActionResult Update(Book b)
        {
            int res = BookDAL.UpdateData(b);
            if(res >0) {
                ViewData["msg"] = "Book Updated succesfully";
                return View("Success");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            int res = BookDAL.DeleteData(id);
            if (res > 0)
            {
                ViewData["msg"] = "Book Deleted Successfully !";
                return View("Success");
            }
            return View();
        }


    }
}
