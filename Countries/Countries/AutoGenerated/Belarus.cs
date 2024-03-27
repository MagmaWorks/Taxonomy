namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Belarus : SingletonCountryBase<Belarus>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Belarus";
        private const string _countryCode = "BY";

        public Belarus() { }
    }
}

