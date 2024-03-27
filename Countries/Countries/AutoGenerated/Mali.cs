namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Mali : SingletonCountryBase<Mali>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Mali";
        private const string _countryCode = "ML";

        public Mali() { }
    }
}

