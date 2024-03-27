namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Austria : SingletonCountryBase<Austria>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Austria";
        private const string _countryCode = "AT";

        public Austria() { }
    }
}

