using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottObjects.Repositories
{
    public class StudentRepository : ICrudOps<Student>
    {
        private static readonly List<Student> Students = new List<Student>();

        public void Create(Student entity)
        {
            if (Students.Any(s => s.Id == entity.Id))
            {
                Console.WriteLine($"Student with ID {entity.Id} already exists.");
                return;
            }
            Students.Add(entity);
            Console.WriteLine($"Student added: {entity}");
        }

        public Student Read(int id)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                Console.WriteLine($"Student with ID {id} not found.");
            }
            return student;
        }

        public IEnumerable<Student> ReadAll()
        {
            return Students;
        }

        public void Update(Student entity)
        {
            var student = Students.FirstOrDefault(s => s.Id == entity.Id);
            if (student == null)
            {
                Console.WriteLine($"Student with ID {entity.Id} not found.");
                return;
            }
            student.FirstName = entity.FirstName;
            student.MiddleInitial = entity.MiddleInitial;
            student.LastName = entity.LastName;
            student.Email = entity.Email;
            student.Phone = entity.Phone;
            student.DateOfBirth = entity.DateOfBirth;
            Console.WriteLine($"Student updated: {entity}");
        }

        public void Delete(int id)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                Console.WriteLine($"Student with ID {id} not found.");
                return;
            }
            Students.Remove(student);
            Console.WriteLine($"Student deleted: {student}");
        }
    }
}
