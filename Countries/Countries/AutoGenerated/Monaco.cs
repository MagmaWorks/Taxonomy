namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Monaco : SingletonCountryBase<Monaco>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Monaco";
        private const string _countryCode = "MC";

        public Monaco() { }
    }
}

