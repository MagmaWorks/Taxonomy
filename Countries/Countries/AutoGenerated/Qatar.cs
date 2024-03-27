namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Qatar : SingletonCountryBase<Qatar>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Qatar";
        private const string _countryCode = "QA";

        public Qatar() { }
    }
}

