namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Iceland : SingletonCountryBase<Iceland>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Iceland";
        private const string _countryCode = "IS";

        public Iceland() { }
    }
}

