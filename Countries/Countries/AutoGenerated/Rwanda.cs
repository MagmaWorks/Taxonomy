namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Rwanda : SingletonCountryBase<Rwanda>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Rwanda";
        private const string _countryCode = "RW";

        public Rwanda() { }
    }
}

