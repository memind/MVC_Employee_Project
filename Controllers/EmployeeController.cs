using _16_MVC_Uygulama2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _16_MVC_Uygulama1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext _context;
        public EmployeeController(EmployeeContext context) 
        {
            _context = context;
        }

        // List (Index)
        public IActionResult Index()
        {
            IEnumerable<Employee> employeeList = _context.Employees.ToList();

            return View(employeeList);
        }


        // Create
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        // Edit
        public IActionResult Edit(int id)
        {
            Employee employee = _context.Employees.FirstOrDefault(c => c.Id == id);

            if (employee is not null)
            {
                return View("Edit", employee);
            }

            else
                return View();
        }

        [HttpPost]
        public IActionResult Edit(int Id, string name, string surname, DateTime birthDate, string title)
        {
            Employee employee = _context.Employees.Find(Id);

            employee.Name = name;
            employee.Surname = surname;
            employee.BirthDate = birthDate;
            employee.Title = title;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        // Details
        public IActionResult Details(int id)
        {
            Employee employee = _context.Employees.Find(id);
            return View(employee);
        }


        // Delete
        public IActionResult Delete(int id)
        {
            Employee employee = _context.Employees.Find(id);

            _context.Employees.Remove(employee);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
