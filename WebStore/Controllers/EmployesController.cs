using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployesController : Controller
    {
        private static readonly List<Employee> __Employes = new List<Employee>
        {
            new Employee { Id = 1, SurName = "Васильев", FirstName = "Олег", Patronymic = "Степанович", Age = 34 },
            new Employee { Id = 2, SurName = "Смирнов", FirstName = "Сергей", Patronymic = "Иванович", Age = 22 },
            new Employee { Id = 3, SurName = "Кузнецов", FirstName = "Михаил", Patronymic = "Олегович", Age = 28 },
        };
        public IActionResult Index()
        {
            return View(__Employes);
        }

        public IActionResult Details(int id)
        {
            var employe = __Employes.FirstOrDefault(e => e.Id == id);
            if (employe == null)
                return NotFound();

            return View(employe);
        }
    }
}