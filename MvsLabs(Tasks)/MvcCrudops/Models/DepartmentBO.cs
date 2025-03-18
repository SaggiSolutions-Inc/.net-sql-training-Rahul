namespace MvcCrudops.Models
{
    public class DepartmentBO
    {
        private List<DepartmentModel> departments = new List<DepartmentModel>
        {
            new DepartmentModel {Id=10, DName="Software",Location = "Canada" },
            new DepartmentModel {Id=20, DName="Hardware",Location = "China" },
            new DepartmentModel {Id=30, DName="HR",Location = "UK" },
            new DepartmentModel {Id=40, DName="Finance",Location = "USA" },
        };
        public List<DepartmentModel> GetAll()
        {
            return departments;
        }
        public DepartmentModel GetById(int id)
        {
            return departments.Single(x => x.Id == id);
        }
        public void DeleteById(int id)
        {
            departments.Remove(departments.Single(x => x.Id == id));
        }
        public void Add(DepartmentModel d)
        {
            departments.Add(d);
        }
        public void UpdateById(int id, DepartmentModel d)
        {
            int index = departments.FindIndex(x=>x.Id == id);
            departments[index] = d;
        }
    }
}
