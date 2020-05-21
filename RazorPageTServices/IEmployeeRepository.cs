using System;
using System.Collections.Generic;
using RazorPageTModel;

namespace RazorPageTServices
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employees> GetAllEmployees();

        Employees GetEmployee(int Id);
        Employees Update(Employees updatedEmployee);

    }
}
