using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;
using WebStore.Modeis;

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

        /// <summary>
        /// Добавление или редактирование сотрудника
        /// </summary>
        /// <param name="id">Identifier.</param>
        [Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            EmployeeView model;
            if(id.HasValue)
            {
                model = _employeesData.GetById(id.Value);
                if (model is null) return NotFound();
            }
            else
            {
                model = new EmployeeView();
            }
            return View(model);
        }

        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(EmployeeView model)
        {
            if(model.Id > 0)
            {
                var dbitem = _employeesData.GetById(model.Id);
                if (dbitem is null) return NotFound();
                dbitem.FirstName = model.FirstName;
                dbitem.Surname = model.Surname;
                dbitem.Age = model.Age;
                dbitem.Position = model.Position;
                dbitem.Salary = model.Salary;
            }
            else
            {
                _employeesData.AddNew(model);
            }
            _employeesData.Commit();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        /// <param name="id">Id сотрудника</param>
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _employeesData.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}