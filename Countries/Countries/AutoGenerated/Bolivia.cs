namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Bolivia : SingletonCountryBase<Bolivia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Bolivia";
        private const string _countryCode = "BO";

        public Bolivia() { }
    }
}

