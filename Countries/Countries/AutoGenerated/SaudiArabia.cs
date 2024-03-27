namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SaudiArabia : SingletonCountryBase<SaudiArabia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Saudi Arabia";
        private const string _countryCode = "SA";

        public SaudiArabia() { }
    }
}

