using System;
namespace RazorPageTModel
{
    public class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string photoPath { get; set; }
        public Dept Department { get; set; }

    }
}
