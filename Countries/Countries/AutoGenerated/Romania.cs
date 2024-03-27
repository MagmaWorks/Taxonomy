namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Romania : SingletonCountryBase<Romania>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Romania";
        private const string _countryCode = "RO";

        public Romania() { }
    }
}

