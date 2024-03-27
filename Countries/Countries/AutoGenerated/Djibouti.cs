namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Djibouti : SingletonCountryBase<Djibouti>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Djibouti";
        private const string _countryCode = "DJ";

        public Djibouti() { }
    }
}

