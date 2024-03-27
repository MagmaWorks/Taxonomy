namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Maldives : SingletonCountryBase<Maldives>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Maldives";
        private const string _countryCode = "MV";

        public Maldives() { }
    }
}

