using Microsoft.AspNetCore.Mvc;

namespace myfirstapp.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ContentResult Content()
        {
            return Content("<h1>Hello from content result");
        }

        public JsonResult empjson()
        {
            var emp = new { Id =10,Name = "Employee name"};
            return Json(emp);
           
        }

    }
}
