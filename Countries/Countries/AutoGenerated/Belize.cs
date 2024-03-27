namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Belize : SingletonCountryBase<Belize>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Belize";
        private const string _countryCode = "BZ";

        public Belize() { }
    }
}

