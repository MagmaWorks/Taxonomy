namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class NewZealand : SingletonCountryBase<NewZealand>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "New Zealand";
        private const string _countryCode = "NZ";

        public NewZealand() { }
    }
}

