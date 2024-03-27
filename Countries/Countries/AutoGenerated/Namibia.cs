namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Namibia : SingletonCountryBase<Namibia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Namibia";
        private const string _countryCode = "NA";

        public Namibia() { }
    }
}

