namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Tuvalu : SingletonCountryBase<Tuvalu>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Tuvalu";
        private const string _countryCode = "TV";

        public Tuvalu() { }
    }
}

