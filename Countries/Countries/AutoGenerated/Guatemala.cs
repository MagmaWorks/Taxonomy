namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Guatemala : SingletonCountryBase<Guatemala>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Guatemala";
        private const string _countryCode = "GT";

        public Guatemala() { }
    }
}

