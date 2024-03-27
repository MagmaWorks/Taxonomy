namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Myanmar : SingletonCountryBase<Myanmar>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Myanmar";
        private const string _countryCode = "MM";

        public Myanmar() { }
    }
}

