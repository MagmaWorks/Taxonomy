namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Croatia : SingletonCountryBase<Croatia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Croatia";
        private const string _countryCode = "HR";

        public Croatia() { }
    }
}

