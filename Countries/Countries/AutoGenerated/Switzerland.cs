namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Switzerland : SingletonCountryBase<Switzerland>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Switzerland";
        private const string _countryCode = "CH";

        public Switzerland() { }
    }
}

