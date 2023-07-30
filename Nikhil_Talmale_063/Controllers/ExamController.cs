using Microsoft.AspNetCore.Mvc;
using Nikhil_Talmale_063.DAL;

namespace Nikhil_Talmale_063.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public IActionResult ShowData(int id)
        {
            Models.Person b = PersonCreditDAL.GetData(id);
            return View(b);
        }


    }
}
