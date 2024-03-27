namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class AmericanSamoa : SingletonCountryBase<AmericanSamoa>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "American Samoa";
        private const string _countryCode = "AS";

        public AmericanSamoa() { }
    }
}

