namespace ScaffoldMvcTask1.Models
{
    public class EmployeeBO
    {
        private List<EmployeeModel> employees = new List<EmployeeModel>
        {
            new EmployeeModel { Id = 1,Ename = "Venkat", Job="Business Analyst", Salary=100000 },
            new EmployeeModel { Id = 2,Ename = "Kiran", Job="Data Analyst", Salary=120000 },
            new EmployeeModel { Id = 3,Ename = "Sai Madhu", Job="Data Scientist", Salary=130000 },
            new EmployeeModel { Id = 4,Ename = "Praveen", Job="Software Engineer", Salary=140000 },

        };
        public List<EmployeeModel> GetAll() => employees;
        public EmployeeModel GetById(int id) => employees.Single(x => x.Id == id);
        public void EditById(EmployeeModel e, int id) => employees[employees.FindIndex(x => x.Id == id)] = e;
        public void DeleteById(int id) => employees.RemoveAt(employees.FindIndex(x => x.Id == id));
        public void Add(EmployeeModel e) => employees.Add(e);
    }    
}
