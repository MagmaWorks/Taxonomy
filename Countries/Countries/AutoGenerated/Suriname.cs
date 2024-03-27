namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Suriname : SingletonCountryBase<Suriname>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Suriname";
        private const string _countryCode = "SR";

        public Suriname() { }
    }
}

