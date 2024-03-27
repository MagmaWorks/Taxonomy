namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Nepal : SingletonCountryBase<Nepal>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Nepal";
        private const string _countryCode = "NP";

        public Nepal() { }
    }
}

