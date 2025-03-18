using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottObjects.Repositories
{
    public class CourseRepository : ICrudOps<Course>
    {
        private static readonly List<Course> Courses = new List<Course>();

        public void Create(Course entity)
        {
            if (Courses.Any(c => c.Id == entity.Id))
            {
                Console.WriteLine($"Course with ID {entity.Id} already exists.");
                return;
            }
            Courses.Add(entity);
            Console.WriteLine($"Courses added: {entity}");
        }

        public Course Read(int id)
        {
            var cs = Courses.FirstOrDefault(c => c.Id == id);
            if (cs == null)
            {
                Console.WriteLine($"Course with ID {id} not found.");
            }
            return cs;
        }

        public IEnumerable<Course> ReadAll()
        {
            return Courses;
        }

        public void Update(Course entity)
        {
            var cs = Courses.FirstOrDefault(c => c.Id == entity.Id);
            if (cs == null)
            {
                Console.WriteLine($"Course with ID {entity.Id} not found.");
                return;
            }
            cs.CourseName = entity.CourseName;
            cs.Description = entity.Description;
            cs.Credits = entity.Credits;
            Console.WriteLine($"Course updated: {entity}");
        }

        public void Delete(int id)
        {
            var cs = Courses.FirstOrDefault(c => c.Id == id);
            if (cs == null)
            {
                Console.WriteLine($"Course with ID {id} not found.");
                return;
            }
            Courses.Remove(cs);
            Console.WriteLine($"Course deleted: {cs}");
        }
    }

}





