using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.Controllers
{
    [Route("Users")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _employeesData;

        public EmployeesController(IEmployeesData employeesData) => _employeesData = employeesData;

        /// <summary>
        /// Вывод спискав
        /// </summary>
        /// <returns>The index.</returns>
        public IActionResult Index()
        {
            return View(_employeesData.GetAll());
        }

        /// <summary>
        /// Детали о сотруднике
        /// </summary>
        /// <param name="id">Identifier.</param>
        [Route("{id}")]
        public IActionResult Details(int id)
        {
            // Получаем сотрудинка по id
            var employee = _employeesData.GetById(id);

            // Если такого не существует, возвращаем 404
            if (employee is null) return NotFound();
            return View(employee);
        }
    }
}