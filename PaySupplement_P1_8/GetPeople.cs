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

        /// <summary>
        /// Get people born after a certain date.
        /// </summary>
        /// <param name="date">The date of people birthday.</param>
        /// <returns>Returns all people born after the specified date.</returns>
        public IEnumerable<Person> GetPeopleBornAfter(DateTime date)
        {
            return data.Where(p => p.Birthday > date);
        }

        /// <summary>
        /// Get people by name.
        /// </summary>
        /// <param name="name">The name of person in data set.</param>
        /// <returns>Returns all people with matching name.</returns>
        public IEnumerable<Person> GetPeopleByName(string name)
        {
            return data.Where(p => p.Name == name);
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

