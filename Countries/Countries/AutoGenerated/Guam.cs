namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Guam : SingletonCountryBase<Guam>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Guam";
        private const string _countryCode = "GU";

        public Guam() { }
    }
}

