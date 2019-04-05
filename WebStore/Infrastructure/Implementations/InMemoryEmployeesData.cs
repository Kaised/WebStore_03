using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore.Infrastructure.Implementations
{
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<Employee> _Employes = new List<Employee>
        {
            new Employee { Id = 1, SurName = "Васильев", FirstName = "Олег", Patronymic = "Степанович", Age = 34 },
            new Employee { Id = 2, SurName = "Смирнов", FirstName = "Сергей", Patronymic = "Иванович", Age = 22 },
            new Employee { Id = 3, SurName = "Кузнецов", FirstName = "Михаил", Patronymic = "Олегович", Age = 28 },
        };

        public IEnumerable<Employee> GetAll() => _Employes;

        public Employee GetById(int id) => _Employes.FirstOrDefault(e => e.Id == id);

        public void AddNew(Employee employee)
        {
            if (employee is null) throw new ArgumentNullException(nameof(employee));

            if (_Employes.Contains(employee) || _Employes.Any(e => e.Id == employee.Id)) return;

            employee.Id = _Employes.Count == 0 ? 1 : _Employes.Max(e => e.Id) + 1;

            _Employes.Add(employee);
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            if (employee is null) return;
            _Employes.Remove(employee);
        }

        public void SaveChanges() { }
    }
}
