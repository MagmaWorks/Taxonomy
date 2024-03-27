namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Oman : SingletonCountryBase<Oman>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Oman";
        private const string _countryCode = "OM";

        public Oman() { }
    }
}

