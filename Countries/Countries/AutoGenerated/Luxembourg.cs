namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Luxembourg : SingletonCountryBase<Luxembourg>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Luxembourg";
        private const string _countryCode = "LU";

        public Luxembourg() { }
    }
}

