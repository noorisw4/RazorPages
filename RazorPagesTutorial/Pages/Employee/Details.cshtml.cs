using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageTModel;
using RazorPageTServices;

namespace RazorPagesTutorial.Pages.Employee
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepository _emp;
        public IEnumerable<Employees> employees { get; set; }
        public Employees Employee { get; private set; }

        public DetailsModel(IEmployeeRepository emp)
        {
            _emp = emp;
        }
        public IActionResult OnGet(int id)
        {
            Employee = _emp.GetEmployee(id);
            if(Employee == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
    }
}
