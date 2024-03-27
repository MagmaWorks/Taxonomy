namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Singapore : SingletonCountryBase<Singapore>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Singapore";
        private const string _countryCode = "SG";

        public Singapore() { }
    }
}

