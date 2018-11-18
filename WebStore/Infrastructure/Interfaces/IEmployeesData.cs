using System;
using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Infrastructure.Interfaces
{
    /// <summary>
    /// Интерфейс для работы с сотрудниками
    /// </summary>
    public interface IEmployeesData
    {
        /// <summary>
        /// Получение списка всех сотрудников
        /// </summary>
        /// <returns></returns>
        IEnumerable<EmployeeView> GetAll();

        /// <summary>
        /// Получение сотрудинка по id
        /// </summary>
        /// <param name="id">Identifier.</param>
        EmployeeView GetById(int id);

        /// <summary>
        /// Сохранить изменения
        /// </summary>
        void Commit();

        /// <summary>
        /// Добавить нового сотрудинка
        /// </summary>
        /// <param name="model">Model.</param>
        void AddNew(EmployeeView model);

        /// <summary>
        /// Удалить сотрудника
        /// </summary>
        /// <param name="id">Identifier.</param>
        void Delete(int id);
    }
}