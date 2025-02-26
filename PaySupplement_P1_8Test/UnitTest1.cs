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
    }
}