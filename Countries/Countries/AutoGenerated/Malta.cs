namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Malta : SingletonCountryBase<Malta>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Malta";
        private const string _countryCode = "MT";

        public Malta() { }
    }
}

