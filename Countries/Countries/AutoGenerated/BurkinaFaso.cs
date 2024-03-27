namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class BurkinaFaso : SingletonCountryBase<BurkinaFaso>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Burkina Faso";
        private const string _countryCode = "BF";

        public BurkinaFaso() { }
    }
}

