using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageTServices;
using RazorPageTModel;

namespace RazorPagesTutorial.Pages.Employee
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRepository _emp;

        public IEnumerable<Employees> employees { get; set; }

        public IndexModel(IEmployeeRepository emp)
        {
            _emp = emp;
        }

        public void OnGet()
        {
            employees = _emp.GetAllEmployees();
        }
    }
}
