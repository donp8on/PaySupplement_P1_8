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
    }
}