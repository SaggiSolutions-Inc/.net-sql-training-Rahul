namespace MvcScaffoldDemo.Models
{
    public class PersonBO
    {
        private List<PersonModel> people = new List<PersonModel>
        {
            new PersonModel {Id=1,PName="Tarun",Gender="Male",Age=20 },
            new PersonModel {Id=2,PName="Mad",Gender= "Female",Age=20 },
            new PersonModel {Id=3,PName="Jyo",Gender="Female",Age=20 },
            new PersonModel {Id=4,PName="Rahul",Gender="Male",Age=20 },
        };
        public List<PersonModel> GetAll()
        {
            return people;
        }
        public PersonModel GetById(int id)
        {
            return people.Single(p => p.Id == id);
        }
        public void create(PersonModel p)
        {
            people.Add(p);
        }
        public void Edit(PersonModel p, int id)
        {
            int index = people.FindIndex(x => x.Id == id);
            people[index] = p;
        }
        public void Delete(int id)
        {
            int index = people.FindIndex(x => x.Id == id);
            people.RemoveAt(index);
        }
    }
}
