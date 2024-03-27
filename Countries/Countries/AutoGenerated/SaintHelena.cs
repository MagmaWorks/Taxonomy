namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SaintHelena : SingletonCountryBase<SaintHelena>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Saint Helena";
        private const string _countryCode = "SH";

        public SaintHelena() { }
    }
}

