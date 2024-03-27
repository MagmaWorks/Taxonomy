namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Burundi : SingletonCountryBase<Burundi>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Burundi";
        private const string _countryCode = "BI";

        public Burundi() { }
    }
}

