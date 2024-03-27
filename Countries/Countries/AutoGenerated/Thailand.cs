namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Thailand : SingletonCountryBase<Thailand>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Thailand";
        private const string _countryCode = "TH";

        public Thailand() { }
    }
}

