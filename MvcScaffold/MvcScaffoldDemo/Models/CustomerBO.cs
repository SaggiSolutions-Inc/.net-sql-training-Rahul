namespace MvcScaffoldDemo.Models
{
    public class CustomerBO
    {
        private List<CustomerModel> customers = new List<CustomerModel>
        {
            new CustomerModel { Id = 1,Cname="Sheshu", Address="Saidabad", Email="saiyadav@gmail.com" },
            new CustomerModel { Id = 2,Cname="Madhav", Address="Pooranapool", Email="madhavyadav@gmail.com" },
            new CustomerModel { Id = 3,Cname="Keshav", Address="Pooranapool", Email="keshavyadav@gmail.com" },
            new CustomerModel { Id = 4,Cname="jai", Address="Old City", Email="jaiyadav@gmail.com" },
        };
        public List<CustomerModel> GetAll()
        {
            return customers;
        }
        public CustomerModel GetById(int id)
        {
            return customers.Single(x => x.Id == id);
        }
        public void Create(CustomerModel c)
        {
            customers.Add(c);
        }
        public void Edit(CustomerModel c, int id)
        {
            int index = customers.FindIndex(x => x.Id == id);
            customers[index] = c;
        }
        public void Delete(int id)
        {
            int index = customers.FindIndex(x => x.Id == id);
            customers.RemoveAt(index);
        }
    }
}
