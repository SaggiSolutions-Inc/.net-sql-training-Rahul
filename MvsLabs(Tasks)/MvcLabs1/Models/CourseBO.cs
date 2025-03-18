using System.Reflection.Metadata.Ecma335;

namespace MvcLabs1.Models
{
    public class CourseBO
    {
        private List<CourseModel> courses = new List<CourseModel>
                {
                new CourseModel { Id = 101, Course = ".NET", Faculty = "Kiran", DurationInDays = 45, Fee = 30000 },
                new CourseModel { Id = 102, Course = "Azure", Faculty = "Harshitha", DurationInDays = 30, Fee = 35000 },
                new CourseModel { Id = 103, Course = "SQL", Faculty = "Ravi", DurationInDays = 25, Fee = 36000 },
                new CourseModel { Id = 104, Course = "Angular", Faculty = "Chandu", DurationInDays = 35, Fee = 40000 },

                };
        public List<CourseModel> GetAll()
        {
            return courses;
        }
        public CourseModel GetByID(int id)
        {
            CourseModel c = new CourseModel();
            for (int i = 0;i< courses.Count;i++)
            {
                if (courses[i].Id == id)
                {
                    c = courses[i];
                    break;
                }
            }
            return c;
        }
    }
}
