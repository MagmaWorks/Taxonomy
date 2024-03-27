namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class PuertoRico : SingletonCountryBase<PuertoRico>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Puerto Rico";
        private const string _countryCode = "PR";

        public PuertoRico() { }
    }
}

