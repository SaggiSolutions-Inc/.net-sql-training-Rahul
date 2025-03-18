namespace MvcLabs1.Models
{
    public class PersonBO
    {
       private List<PersonModel> people = new List<PersonModel>();

        public PersonBO() 
        {
            people.Add(new PersonModel { Id = 101, PName = "Rahul", Gender = "Male", Age = 26 });
            people.Add(new PersonModel { Id = 102, PName = "Tarun", Gender = "Male", Age = 28 });
            people.Add(new PersonModel { Id = 103, PName = "Jyo", Gender = "Female", Age = 30 });
        }
        public List<PersonModel> GetAll()
        {
            return people;
        }
        public PersonModel GetById(int id)
        {
            PersonModel p = new PersonModel();
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Id == id)
                {
                    p = people[i];
                    break;
                }
            }
            return p;
        }

    }
}
