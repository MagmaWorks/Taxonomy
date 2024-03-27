namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Slovenia : SingletonCountryBase<Slovenia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Slovenia";
        private const string _countryCode = "SI";

        public Slovenia() { }
    }
}

