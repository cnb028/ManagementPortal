using Microsoft.AspNetCore.Mvc;
using ManagementPortal.Models;

namespace ManagementPortal.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Salary()
        {
            ViewBag.Salary = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Salary(Employee model)
        {
            ViewBag.Salary = model.CalculatePay();
            return View(model);
        }
    }
}
