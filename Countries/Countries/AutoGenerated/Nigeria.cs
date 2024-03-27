namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Nigeria : SingletonCountryBase<Nigeria>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Nigeria";
        private const string _countryCode = "NG";

        public Nigeria() { }
    }
}

