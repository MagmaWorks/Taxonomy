namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Korea : SingletonCountryBase<Korea>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Korea";
        private const string _countryCode = "KR";

        public Korea() { }
    }
}

