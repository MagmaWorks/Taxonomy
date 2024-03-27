namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class DemocraticRepublicOfTheCongo : SingletonCountryBase<DemocraticRepublicOfTheCongo>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Democratic Republic of the Congo";
        private const string _countryCode = "CD";

        public DemocraticRepublicOfTheCongo() { }
    }
}

