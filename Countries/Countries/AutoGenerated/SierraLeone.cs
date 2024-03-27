namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SierraLeone : SingletonCountryBase<SierraLeone>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Sierra Leone";
        private const string _countryCode = "SL";

        public SierraLeone() { }
    }
}

