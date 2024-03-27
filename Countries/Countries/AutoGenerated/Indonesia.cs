namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Indonesia : SingletonCountryBase<Indonesia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Indonesia";
        private const string _countryCode = "ID";

        public Indonesia() { }
    }
}

