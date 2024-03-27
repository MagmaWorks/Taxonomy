namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Malawi : SingletonCountryBase<Malawi>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Malawi";
        private const string _countryCode = "MW";

        public Malawi() { }
    }
}

