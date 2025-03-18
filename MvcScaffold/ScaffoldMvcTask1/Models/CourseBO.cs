namespace ScaffoldMvcTask1.Models
{
    public class CourseBO
    {
        private List<CourseModel> courses = new List<CourseModel> 
        {
            new CourseModel { Id = 1,Course="Angular",Hod="Akhil",Fee=10000},
            new CourseModel { Id = 2,Course=".NET",Hod="Deva",Fee=12000},
            new CourseModel { Id = 3,Course="Azure",Hod="Shyam",Fee=14000},
            new CourseModel { Id = 4,Course="React",Hod="Sasi",Fee=15000}
        };

        public List<CourseModel> GetAll() => courses;
        public CourseModel GetById(int id) => courses.Single(x => x.Id == id);
        public void EditById(CourseModel c, int id) => courses[courses.FindIndex(x => x.Id == id)] = c;
        public void DeleteById(int id) => courses.RemoveAt(courses.FindIndex(x => x.Id == id));
        public void Add(CourseModel c) => courses.Add(c);
    }

}
