namespace ScaffoldMvcTask1.Models
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
        public List<PersonModel> GetAll() => people;
        public PersonModel GetById(int id) => people.Single(x => x.Id == id);
        public void EditById(PersonModel p, int id) => people[people.FindIndex(x => x.Id == id)] = p;
        public void DeleteById(int id) => people.RemoveAt(people.FindIndex(x => x.Id == id));
        public void Add(PersonModel p) => people.Add(p);
    }
}