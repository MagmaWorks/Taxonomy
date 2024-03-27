namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Montenegro : SingletonCountryBase<Montenegro>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Montenegro";
        private const string _countryCode = "ME";

        public Montenegro() { }
    }
}

