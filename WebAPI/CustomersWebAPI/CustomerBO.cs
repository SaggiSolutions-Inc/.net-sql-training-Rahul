// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomersWebAPI
{
    public class CustomerBO
    {
        private List<CustomerModel> customers = new List<CustomerModel>()
        {
            new CustomerModel { Id = 1, CName = "Rahul", City = "Hyderabad" },
            new CustomerModel { Id = 2, CName = "Allu Arjun", City = "Hyderabad" },
            new CustomerModel { Id = 3, CName = "Dhanush", City = "Chennai" },
            new CustomerModel { Id = 4, CName = "Hrithik", City = "Mumbai" },
        };
        public List<CustomerModel> GetAll()
        { return customers; }
        public CustomerModel GetById(int id)
        { return customers.Single(x => x.Id == id); }
        public void Add(CustomerModel c)
        {
            customers.Add(c);
        }
        public void Edit(CustomerModel c, int id)
        {
            customers[customers.FindIndex(x=>x.Id==id)]= c;
        }
        public void Delete(int id)
        {
            customers.RemoveAt(customers.FindIndex((x)=>x.Id==id));
        }

    }
}
