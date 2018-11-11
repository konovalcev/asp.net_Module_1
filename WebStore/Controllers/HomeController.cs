using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.Modeis;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id = 1,
                FirstName = "John",
                Surname = "Lennon",
                Age = 20,
                Position = "guitar",
                Salary = 100
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Paul",
                Surname = "McCartney",
                Age = 21,
                Position = "bass",
                Salary = 100
            },
            new EmployeeView
            {
                Id = 3,
                FirstName = "George",
                Surname = "Harrison",
                Age = 22,
                Position = "guitar",
                Salary = 105
            },
                        new EmployeeView
            {
                Id = 4,
                FirstName = "Ringo",
                Surname = "Starr",
                Age = 23,
                Position = "bass",
                Salary = 110
            }
        };

        public IActionResult Index() => View(_employees);

        public IActionResult Details(int id)
        {
            var employeeDetail = _employees.FirstOrDefault(t => t.Id.Equals(id)); //.Find(x => x.Id == id);
            if(employeeDetail is null) return NotFound();
            return View(employeeDetail);
        }

        public IActionResult Shop() => View();
        public IActionResult ProductDetails() => View();
        public IActionResult Login() => View();
        public IActionResult ContactUs() => View();
        public IActionResult Checkout() => View();
        public ActionResult Cart() => View();
        public IActionResult BlogSingle() => View();
        public IActionResult Blog() => View();
        public new IActionResult NotFound() => View();

    }
}