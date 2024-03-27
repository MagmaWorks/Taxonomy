namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Kenya : SingletonCountryBase<Kenya>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Kenya";
        private const string _countryCode = "KE";

        public Kenya() { }
    }
}

