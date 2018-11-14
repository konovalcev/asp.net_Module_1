using System;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Modeis
{
    public class EmployeeView
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        [Range(18,100)]
        public int Age { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
    }
}