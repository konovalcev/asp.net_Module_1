using System.Collections.Generic;
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

        public IActionResult Index()
        {
            return View(_employees);
        }

        public IActionResult Details(int id)
        {
            var employeeDetail = _employees.Find(x => x.Id == id);
            return View(employeeDetail);
        }
    }
}