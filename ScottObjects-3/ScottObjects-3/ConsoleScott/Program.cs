using ScottObjects;
using ScottObjects.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScott
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StateCrudOps();

            DepartmentCrudOps();
            CourseCrudOps();
            StudentCrudOps();

        }

      private static void StateCrudOps()
        {
            var stateRepo = new StateRepository();


            stateRepo.Create(new State(1, "California", "CA"));
            stateRepo.Create(new State(2, "Texas", "TX"));
            stateRepo.Create(new State(3, "New York", "NY"));


            Console.WriteLine("\nAll States:");
            foreach (var state in stateRepo.ReadAll())
            {
                Console.WriteLine(state);
            }


            Console.WriteLine("\nRead State with ID 2:");
            var state2 = stateRepo.Read(2);
            if (state2 != null) Console.WriteLine(state2);


            Console.WriteLine("\nUpdating State with ID 3:");
            stateRepo.Update(new State(3, "New York Updated", "NYU"));


            Console.WriteLine("\nAll States After Update:");
            foreach (var state in stateRepo.ReadAll())
            {
                Console.WriteLine(state);
            }


            Console.WriteLine("\nDeleting State with ID 1:");
            stateRepo.Delete(1);


            Console.WriteLine("\nAll States After Deletion:");
            foreach (var state in stateRepo.ReadAll())
            {
                Console.WriteLine(state);
            }
        }

        private static void DepartmentCrudOps()
        {
            var deptRepo = new DeptRepository();

           
            deptRepo.Create(new Department(1, "Human Resources", "New York"));
            deptRepo.Create(new Department(2, "Finance", "Los Angeles"));
            deptRepo.Create(new Department(3, "IT", "San Francisco"));

            
            Console.WriteLine("\nAll Departments:");
            foreach (var dept in deptRepo.ReadAll())
            {
                Console.WriteLine(dept);
            }

            
            Console.WriteLine("\nRead Department with ID 2:");
            var dept2 = deptRepo.Read(2);
            if (dept2 != null) Console.WriteLine(dept2);

           
            Console.WriteLine("\nUpdating Department with ID 3:");
            deptRepo.Update(new Department(3, "Information Technology", "San Jose"));

          
            Console.WriteLine("\nAll Departments After Update:");
            foreach (var dept in deptRepo.ReadAll())
            {
                Console.WriteLine(dept);
            }

         
            Console.WriteLine("\nDeleting Department with ID 1:");
            deptRepo.Delete(1);

          
            Console.WriteLine("\nAll Departments After Deletion:");
            foreach (var dept in deptRepo.ReadAll())
            {
                Console.WriteLine(dept);
            }
        }
        private static void CourseCrudOps()
        {
            var courseRepo = new CourseRepository();


            courseRepo.Create(new Course(1, "C# Programming", "Basics of C#",3));
            courseRepo.Create(new Course(2, "SQL", "Database",4));
            courseRepo.Create(new Course(3, "Angular", "FrontEnd",3));


            Console.WriteLine("\nAll Courses:");
            foreach (var course in courseRepo.ReadAll())
            {
                Console.WriteLine(course);
            }


            Console.WriteLine("\nRead Course with ID 2:");
            var course2 = courseRepo.Read(2);
            if (course2 != null) Console.WriteLine(course2);


            Console.WriteLine("\nUpdating course with ID 3:");
            courseRepo.Update(new Course(3, "JavaScript", "Frontend using JS",4));


            Console.WriteLine("\nAll Courses After Update:");
            foreach (var course in courseRepo.ReadAll())
            {
                Console.WriteLine(course);
            }


            Console.WriteLine("\nDeleting Course with ID 1:");
            courseRepo.Delete(1);


            Console.WriteLine("\nAll States After Deletion:");
            foreach (var course in courseRepo.ReadAll())
            {
                Console.WriteLine(course);
            }
        }
        private static void StudentCrudOps()
        {
            var studentRepo = new StudentRepository();

            // Adding Students
            studentRepo.Create(new Student(1, "John", "A", "Doe", "john.doe@example.com", "123-456-7890", new DateTime(1995, 5, 15)));
            studentRepo.Create(new Student(2, "Jane", "B", "Smith", "jane.smith@example.com", "987-654-3210", new DateTime(1997, 8, 25)));
            studentRepo.Create(new Student(3, "Alice", "C", "Brown", "alice.brown@example.com", "111-222-3333", new DateTime(2000, 10, 10)));

            // Display All Students
            Console.WriteLine("\nAll Students:");
            foreach (var student in studentRepo.ReadAll())
            {
                Console.WriteLine(student);
            }

            // Read Student by ID
            Console.WriteLine("\nRead Student with ID 2:");
            var student2 = studentRepo.Read(2);
            if (student2 != null) Console.WriteLine(student2);

            // Update Student
            Console.WriteLine("\nUpdating Student with ID 3:");
            studentRepo.Update(new Student(3, "Alice", "C", "Johnson", "alice.johnson@example.com", "111-222-3333", new DateTime(2000, 10, 10)));

            // Display All Students After Update
            Console.WriteLine("\nAll Students After Update:");
            foreach (var student in studentRepo.ReadAll())
            {
                Console.WriteLine(student);
            }

            // Delete Student
            Console.WriteLine("\nDeleting Student with ID 1:");
            studentRepo.Delete(1);

            // Display All Students After Deletion
            Console.WriteLine("\nAll Students After Deletion:");
            foreach (var student in studentRepo.ReadAll())
            {
                Console.WriteLine(student);
            }
        }

    }
}

