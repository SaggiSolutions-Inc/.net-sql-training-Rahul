namespace MvcLabs1.Models
{
    public class EmployeeBO
    {
        private List<EmployeeModel> employees = new List<EmployeeModel>
            {
                new EmployeeModel{Id = 1,EName="Maikanta Rahul",Job=".NET Devloper",Salary=220000},
                new EmployeeModel{Id=2,EName="Sai Tarun",Job="Data Analyst",Salary=250000},
                new EmployeeModel{Id = 3, EName = "Jyo", Job = "UI Designer", Salary = 300000}
            };
        public List<EmployeeModel> GetAll()
        { 
            return employees; 
        }
        public EmployeeModel GetbyID(int id)
        {
            int index = -1;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == id)
                {
                    index = i; break;
                }
            }
            return employees[index];

        }
    }
}
