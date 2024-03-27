namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class France : SingletonCountryBase<France>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "France";
        private const string _countryCode = "FR";

        public France() { }
    }
}

