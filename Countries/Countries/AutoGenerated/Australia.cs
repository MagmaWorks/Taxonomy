namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Australia : SingletonCountryBase<Australia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Australia";
        private const string _countryCode = "AU";

        public Australia() { }
    }
}

