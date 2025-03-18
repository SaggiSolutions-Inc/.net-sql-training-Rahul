using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottObjects.Repositories
{
    public class DeptRepository : ICrudOps<Department>
    {
        private static readonly List<Department> Departments = new List<Department>();

        public void Create(Department entity)
        {
            if (Departments.Any(d => d.Id == entity.Id))
            {
                Console.WriteLine($"Department with ID {entity.Id} already exists.");
                return;
            }
            Departments.Add(entity);
            Console.WriteLine($"Department added: {entity}");
        }

        public Department Read(int id)
        {
            var dept = Departments.FirstOrDefault(d => d.Id == id);
            if (dept == null)
            {
                Console.WriteLine($"Department with ID {id} not found.");
            }
            return dept;
        }

        public IEnumerable<Department> ReadAll()
        {
            return Departments;
        }

        public void Update(Department entity)
        {
            var dept = Departments.FirstOrDefault(d => d.Id == entity.Id);
            if (dept == null)
            {
                Console.WriteLine($"Department with ID {entity.Id} not found.");
                return;
            }
            dept.DName = entity.DName;
            dept.Loc = entity.Loc;
            Console.WriteLine($"Department updated: {entity}");
        }

        public void Delete(int id)
        {
            var dept = Departments.FirstOrDefault(d => d.Id == id);
            if (dept == null)
            {
                Console.WriteLine($"Department with ID {id} not found.");
                return;
            }
            Departments.Remove(dept);
            Console.WriteLine($"Department deleted: {dept}");
        }
    }

}
