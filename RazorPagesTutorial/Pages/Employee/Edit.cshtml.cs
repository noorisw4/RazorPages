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
    public class EditModel : PageModel
    { 
        private readonly IEmployeeRepository _emp;

        [BindProperty]
        public Employees Employees { get; set; }

        [BindProperty]
        public bool Notify { get; set; }

        public string Message { get; set; }

        public EditModel(IEmployeeRepository emp)
        {
            _emp = emp;
        }
        public IActionResult OnGet(int id)
        {
            Employees = _emp.GetEmployee(id);

            if(Employees == null)
            {
                return RedirectToPage("/NotFound");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            Employees = _emp.Update(Employees);
            return RedirectToPage("Index");
        }

        public void OnPostUpdate(int id)
        {
            if (Notify)
            {
                Message = "Thank you for turning on notifications";
            }
            else
            {
                Message = "You have turned off email notification ";
            }
            Employees = _emp.GetEmployee(id);
        }
    }
}
