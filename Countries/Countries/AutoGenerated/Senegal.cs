namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Senegal : SingletonCountryBase<Senegal>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Senegal";
        private const string _countryCode = "SN";

        public Senegal() { }
    }
}

