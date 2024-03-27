namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Libya : SingletonCountryBase<Libya>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Libya";
        private const string _countryCode = "LY";

        public Libya() { }
    }
}

