namespace ScaffoldMvcTask1.Models
{
    public class StudentBo
    {
        private List<StudentModel> students = new List<StudentModel>
        {
            new StudentModel { Id = 1, SName = "Sneha", Course = "REACT", Phone = 123456789 },
            new StudentModel { Id = 2, SName = "Morya", Course = "NodeJS", Phone = 456798123 },
            new StudentModel { Id = 3, SName = "Siddhiksha", Course = ".NET", Phone = 789456123 },
            new StudentModel { Id = 4, SName = "Rudraksh", Course = "Angular", Phone = 456132798 },
        };
        public List<StudentModel> GetAll() => students;
        public StudentModel GetById(int id) => students.Single(x => x.Id == id);
        public void EditById(StudentModel s, int id) => students[students.FindIndex(x => x.Id == id)] = s;
        public void DeleteById(int id) => students.RemoveAt(students.FindIndex(x => x.Id == id));
        public void Add(StudentModel s) => students.Add(s);

    }
}
