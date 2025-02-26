namespace PaySupplement_P1_8
{
    public class GetPeople
    {
        private List<Person> data = new List<Person>();

        public void InitializePeople()
        {
            Random random = new Random();
            data = Enumerable.Range(1, 1_000_000).Select(id => new Person
            {
                Id = id,
                Name = "Person" + random.Next(1, 10000),  // Random name
                Birthday = new DateTime(random.Next(1950, 2024), random.Next(1, 13), random.Next(1, 29))  // Random birthday
            }).ToList();
        }

        public IEnumerable<Person> GetPeopleBornAfter(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeopleByName(string name)
        {
            throw new NotImplementedException();
        }

        public Person? GetPersonById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAllPeople()
        {
            throw new NotImplementedException();
        }
    }
}

