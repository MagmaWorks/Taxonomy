namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Aruba : SingletonCountryBase<Aruba>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Aruba";
        private const string _countryCode = "AW";

        public Aruba() { }
    }
}

