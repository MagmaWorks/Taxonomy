namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Taiwan : SingletonCountryBase<Taiwan>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Taiwan";
        private const string _countryCode = "TW";

        public Taiwan() { }
    }
}

