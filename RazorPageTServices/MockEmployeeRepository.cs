using System;
using System.Collections.Generic;
using System.Linq;
using RazorPageTModel;

namespace RazorPageTServices
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employees> _emp;

        public MockEmployeeRepository()
        {
            _emp = new List<Employees>()
            {
                new Employees() {ID = 1, Name ="Mary", Email="mary@iot.com",Department =Dept.HR,photoPath="mary.jpg"},
                new Employees() {ID = 2, Name ="John", Email="john@iot.com",Department =Dept.Manager,photoPath="john.jpg"},
                new Employees() {ID = 3, Name ="Sam", Email="sam@iot.com",Department =Dept.IT,photoPath="sam.jpg"},
                new Employees() {ID = 4, Name ="David", Email="david@iot.com",Department =Dept.PayRoll,photoPath="david.jpg"}
            };
        }

        public IEnumerable<Employees> GetAllEmployees()
        {
            return _emp;
        }

        public Employees Empl { get; set; }

        public Employees GetEmployee(int Id)
        {
           return  Empl = _emp.FirstOrDefault(e => e.ID == Id);
        }

        public Employees Update(Employees updatedEmployee)
         {
           Employees employees =  _emp.FirstOrDefault(e => e.ID == updatedEmployee.ID);
            if(employees != null)
            {
                employees.Name = updatedEmployee.Name;
                employees.Email = updatedEmployee.Email;
                employees.Department = updatedEmployee.Department;
            }
            return employees;
        }


    }
}
