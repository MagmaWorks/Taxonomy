namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Comoros : SingletonCountryBase<Comoros>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Comoros";
        private const string _countryCode = "KM";

        public Comoros() { }
    }
}

