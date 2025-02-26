using PaySupplement_P1_8;

namespace PaySupplement_P1_8Test
{
    public class UnitTest1
    {
        private readonly GetPeople _getPeople;

        public UnitTest1()
        {
            _getPeople = new GetPeople();
            _getPeople.InitializePeople();
        }

        [Fact]
        public void ShouldGetPeopleBornAfter_CorrectResults()
        {
            DateTime testDate = new DateTime(2000, 1, 1);
            var results = _getPeople.GetPeopleBornAfter(testDate);

            Assert.NotEmpty(results);
            Assert.All(results, p => Assert.True(p.Birthday > testDate));
        }

        [Fact]
        public void ShouldGetPeopleByName_CorrectResults()
        {
            var allPeople = _getPeople.GetAllPeople();
            var randomPerson = allPeople.First();

            var results = _getPeople.GetPeopleByName(randomPerson.Name);

            Assert.NotEmpty(results); 
            Assert.All(results, p => Assert.Equal(randomPerson.Name, p.Name));
        }

        [Fact]
        public void ShouldGetPersonById_ReturnCorrectPerson()
        {
            var allPeople = _getPeople.GetAllPeople();
            var randomPerson = allPeople.First();

            var foundPerson = _getPeople.GetPersonById(randomPerson.Id);

            Assert.NotNull(foundPerson);
            Assert.Equal(randomPerson.Id, foundPerson.Id);
            Assert.Equal(randomPerson.Name, foundPerson.Name);
            Assert.Equal(randomPerson.Birthday, foundPerson.Birthday);
        }
    }
}