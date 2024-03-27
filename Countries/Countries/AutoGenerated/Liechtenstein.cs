namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Liechtenstein : SingletonCountryBase<Liechtenstein>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Liechtenstein";
        private const string _countryCode = "LI";

        public Liechtenstein() { }
    }
}

