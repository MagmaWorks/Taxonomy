namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Moldova : SingletonCountryBase<Moldova>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Moldova";
        private const string _countryCode = "MD";

        public Moldova() { }
    }
}

