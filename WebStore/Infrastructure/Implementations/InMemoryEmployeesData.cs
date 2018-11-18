using System;
using System.Collections.Generic;
using System.Linq;
using WebStore.Models;

namespace WebStore.Infrastructure.Interfaces
{
    /// <summary>
    /// Хранит список сотрудников в памяти
    /// </summary>
    public class InMemoryEmployeesData:IEmployeesData
    {
        private readonly List<EmployeeView> _employees;

        public InMemoryEmployeesData() => _employees = new List<EmployeeView>
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

        public void AddNew(EmployeeView model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            model.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(model);
        }

        public void Commit()
        {

        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            if (employee != null) _employees.Remove(employee);
        }

        public EmployeeView GetById(int id) => _employees.FirstOrDefault(e => e.Id.Equals(id));

        public IEnumerable<EmployeeView> GetAll() => _employees;
    }
}