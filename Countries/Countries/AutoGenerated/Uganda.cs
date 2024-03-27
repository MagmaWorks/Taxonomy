namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Uganda : SingletonCountryBase<Uganda>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Uganda";
        private const string _countryCode = "UG";

        public Uganda() { }
    }
}

