namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Bahrain : SingletonCountryBase<Bahrain>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Bahrain";
        private const string _countryCode = "BH";

        public Bahrain() { }
    }
}

