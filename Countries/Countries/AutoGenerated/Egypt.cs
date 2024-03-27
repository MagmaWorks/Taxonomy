namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Egypt : SingletonCountryBase<Egypt>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Egypt";
        private const string _countryCode = "EG";

        public Egypt() { }
    }
}

