using MagmaWorks.Taxonomy.Countries;

namespace CountryTests
{
    public class CountryTests
    {
        [Theory]
        [MemberData(nameof(CountryValues))]
        public void TestCountryEnum(Country country)
        {
            ICountry instance = Utility.GetCountry(country);
            Assert.NotNull(instance);
            Assert.NotEmpty(instance.CountryCode);
            Assert.NotEmpty(instance.Name);
        }

        public static IEnumerable<object[]> CountryValues()
        {
            foreach (var country in Enum.GetValues(typeof(Country)))
            {
                yield return new object[] { country };
            }
        }
    }
}
