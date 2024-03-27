namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class NorthKorea : SingletonCountryBase<NorthKorea>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "North Korea";
        private const string _countryCode = "KP";

        public NorthKorea() { }
    }
}

