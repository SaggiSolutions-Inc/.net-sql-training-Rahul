using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ScottObjects.Repositories
{
    public class EmployeeRepository : ICrudOps<Employee>
    {
        private static readonly List<Employee> Employees = new List<Employee>();

        public void Create(Employee entity)
        {
            if (Employees.Any(c => c.Id == entity.Id))
            {
                Console.WriteLine($"Employee with ID {entity.Id} already exists");
                return;
            }
            Employees.Add(entity);

        }
        public Employee Read(int id)
        {
            var Employee = Employees.FirstOrDefault(d => d.Id == id);
            if (Employees == null)
            {
                Console.WriteLine($"Employee with ID {id} not found.");
            }
            return Employee;
        }
        public IEnumerable<Employee> ReadAll()
        {
            return Employees;
        }
        public void Update(Employee entity)
        {
            var Employee = Employees.FirstOrDefault(e => e.Id == entity.Id);
            if (Employee == null)
            {
                Console.WriteLine($"Employee with ID {entity.Id} not found");
                return;
            }
            Employee.FirstName = entity.FirstName;
            Employee.MiddleInitial = entity.MiddleInitial;
            Employee.LastName = entity.LastName;
            Employee.Email = entity.Email;
            Employee.Phone = entity.Phone;
            Employee.Job = entity.Job;
            Employee.HireDate = entity.HireDate;
            Employee.ManagerId = entity.ManagerId;
            Employee.DeptNo = entity.DeptNo;
            Employee.Salary = entity.Salary;
            Employee.Commission = entity.Commission;

            Console.WriteLine($"Employees record Updated: {entity}");
        }

        public void Delete(int id)
        {
            var Employee = Employees.FirstOrDefault(d => d.Id == id);
            if (Employee == null)
            {
                Console.WriteLine($"Course with ID {id} not Found");
                return;
            }
            Employees.Remove(Employee);
            Console.WriteLine($"Course Deleted: {Employee}");

        }

    }
}