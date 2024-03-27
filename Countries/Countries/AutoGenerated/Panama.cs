namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Panama : SingletonCountryBase<Panama>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Panama";
        private const string _countryCode = "PA";

        public Panama() { }
    }
}

